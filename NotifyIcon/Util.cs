using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Resources;
using System.Windows.Threading;

namespace NotifyIcon {
  /// <summary>
  /// Util and extension methods.
  /// </summary>
  internal static class Util {
    public static readonly object SyncRoot = new();

    #region IsDesignMode

    private static readonly bool isDesignMode;

    /// <summary>
    /// Checks whether the application is currently in design mode.
    /// </summary>
    public static bool IsDesignMode => isDesignMode;

    #endregion

    #region construction

    static Util() => isDesignMode =
          (bool)
              DependencyPropertyDescriptor.FromProperty(DesignerProperties.IsInDesignModeProperty,
                  typeof(FrameworkElement))
                  .Metadata.DefaultValue;

    #endregion

    #region CreateHelperWindow

    /// <summary>
    /// Creates an transparent window without dimension that
    /// can be used to temporarily obtain focus and/or
    /// be used as a window message sink.
    /// </summary>
    /// <returns>Empty window.</returns>
    public static Window CreateHelperWindow() => new() {
      Width = 0,
      Height = 0,
      ShowInTaskbar = false,
      WindowStyle = WindowStyle.None,
      AllowsTransparency = true,
      Opacity = 0
    };

    #endregion

    #region WriteIconData

    /// <summary>
    /// Updates the taskbar icons with data provided by a given
    /// <see cref="NotifyIconData"/> instance.
    /// </summary>
    /// <param name="data">Configuration settings for the NotifyIcon.</param>
    /// <param name="command">Operation on the icon (e.g. delete the icon).</param>
    /// <returns>True if the data was successfully written.</returns>
    /// <remarks>See Shell_NotifyIcon documentation on MSDN for details.</remarks>
    public static bool WriteIconData(ref NotifyIconData data, NotifyCommand command) => WriteIconData(ref data, command, data.ValidMembers);


    /// <summary>
    /// Updates the taskbar icons with data provided by a given
    /// <see cref="NotifyIconData"/> instance.
    /// </summary>
    /// <param name="data">Configuration settings for the NotifyIcon.</param>
    /// <param name="command">Operation on the icon (e.g. delete the icon).</param>
    /// <param name="flags">Defines which members of the <paramref name="data"/>
    /// structure are set.</param>
    /// <returns>True if the data was successfully written.</returns>
    /// <remarks>See Shell_NotifyIcon documentation on MSDN for details.</remarks>
    public static bool WriteIconData(ref NotifyIconData data, NotifyCommand command, IconDataMembers flags) {
      //do nothing if in design mode
      if (IsDesignMode) {
        return true;
      }

      data.ValidMembers = flags;
      lock (SyncRoot) {
        return WinApi.Shell_NotifyIcon(command, ref data);
      }
    }

    #endregion

    #region GetBalloonFlag

    /// <summary>
    /// Gets a <see cref="BalloonFlags"/> enum value that
    /// matches a given <see cref="BalloonIcon"/>.
    /// </summary>
    public static BalloonFlags GetBalloonFlag(this BalloonIcon icon) =>
      icon switch {
        BalloonIcon.None => BalloonFlags.None,
        BalloonIcon.Info => BalloonFlags.Info,
        BalloonIcon.Warning => BalloonFlags.Warning,
        BalloonIcon.Error => BalloonFlags.Error,
        _ => throw new ArgumentOutOfRangeException(nameof(icon)),
      };

    #endregion

    #region ImageSource to Icon

    /// <summary>
    /// Reads a given image resource into a WinForms icon.
    /// </summary>
    /// <param name="imageSource">Image source pointing to
    /// an icon file (*.ico).</param>
    /// <returns>An icon object that can be used with the
    /// taskbar area.</returns>
    public static Icon ToIcon(this ImageSource imageSource) {
      if (imageSource == null) {
        return null;
      }

      Uri uri = new(imageSource.ToString());
      StreamResourceInfo streamInfo = Application.GetResourceStream(uri);

      if (streamInfo == null) {
        string msg = "The supplied image source '{0}' could not be resolved.";
        msg = string.Format(msg, imageSource);
        throw new ArgumentException(msg);
      }

      return new Icon(streamInfo.Stream);
    }

    #endregion

    #region evaluate listings

    /// <summary>
    /// Checks a list of candidates for equality to a given
    /// reference value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value">The evaluated value.</param>
    /// <param name="candidates">A liste of possible values that are
    /// regarded valid.</param>
    /// <returns>True if one of the submitted <paramref name="candidates"/>
    /// matches the evaluated value. If the <paramref name="candidates"/>
    /// parameter itself is null, too, the method returns false as well,
    /// which allows to check with null values, too.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="candidates"/>
    /// is a null reference.</exception>
    public static bool Is<T>(this T value, params T[] candidates) {
      if (candidates == null) {
        return false;
      }

      foreach (T t in candidates) {
        if (value.Equals(t)) {
          return true;
        }
      }

      return false;
    }

    #endregion

    #region match MouseEvent to PopupActivation

    /// <summary>
    /// Checks if a given <see cref="PopupActivationMode"/> is a match for
    /// an effectively pressed mouse button.
    /// </summary>
    public static bool IsMatch(this MouseEvent me, PopupActivationMode activationMode) =>
      activationMode switch {
        PopupActivationMode.LeftClick => me == MouseEvent.IconLeftMouseUp,
        PopupActivationMode.RightClick => me == MouseEvent.IconRightMouseUp,
        PopupActivationMode.LeftOrRightClick => me.Is(MouseEvent.IconLeftMouseUp, MouseEvent.IconRightMouseUp),
        PopupActivationMode.LeftOrDoubleClick => me.Is(MouseEvent.IconLeftMouseUp, MouseEvent.IconDoubleClick),
        PopupActivationMode.DoubleClick => me.Is(MouseEvent.IconDoubleClick),
        PopupActivationMode.MiddleClick => me == MouseEvent.IconMiddleMouseUp,
        PopupActivationMode.All => me != MouseEvent.MouseMove,//return true for everything except mouse movements
        _ => throw new ArgumentOutOfRangeException(nameof(activationMode)),
      };

    #endregion

    #region execute command

    /// <summary>
    /// Executes a given command if its <see cref="ICommand.CanExecute"/> method
    /// indicates it can run.
    /// </summary>
    /// <param name="command">The command to be executed, or a null reference.</param>
    /// <param name="commandParameter">An optional parameter that is associated with
    /// the command.</param>
    /// <param name="target">The target element on which to raise the command.</param>
    public static void ExecuteIfEnabled(this ICommand command, object commandParameter, IInputElement target) {
      if (command == null) {
        return;
      }

      if (command is RoutedCommand rc) {
        //routed commands work on a target
        if (rc.CanExecute(commandParameter, target)) {
          rc.Execute(commandParameter, target);
        }
      } else if (command.CanExecute(commandParameter)) {
        command.Execute(commandParameter);
      }
    }

    #endregion

    /// <summary>
    /// Returns a dispatcher for multi-threaded scenarios
    /// </summary>
    /// <returns>Dispatcher</returns>
    internal static Dispatcher GetDispatcher(this DispatcherObject source) {
      //use the application's dispatcher by default
      if (Application.Current != null) {
        return Application.Current.Dispatcher;
      }

      //fallback for WinForms environments
      if (source.Dispatcher != null) {
        return source.Dispatcher;
      }

      // ultimately use the thread's dispatcher
      return Dispatcher.CurrentDispatcher;
    }


    /// <summary>
    /// Checks whether the <see cref="FrameworkElement.DataContextProperty"/>
    ///  is bound or not.
    /// </summary>
    /// <param name="element">The element to be checked.</param>
    /// <returns>True if the data context property is being managed by a
    /// binding expression.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="element"/>
    /// is a null reference.</exception>
    public static bool IsDataContextDataBound(this FrameworkElement element) {
      if (element == null) {
        throw new ArgumentNullException(nameof(element));
      }

      return element.GetBindingExpression(FrameworkElement.DataContextProperty) != null;
    }
  }
}