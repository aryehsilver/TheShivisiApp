using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.IO;
using System.Timers;
using System.Windows;
using Telerik.Windows.Controls;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace TheShivisiApp {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {
    private const string APP_ID = "The Shivisi App";
    private TaskbarIcon notifyIcon;

    protected override void OnStartup(StartupEventArgs e) {
      base.OnStartup(e);
      //create the notifyicon (it's a resource declared in NotifyIconResources.xaml)
      notifyIcon = (TaskbarIcon)FindResource("NotifyIcon");

      StyleManager.ApplicationTheme = new FluentTheme();
      ShowSplashScreen();
      RunTimer();
      //PopTheToast();
    }

    private static void ShowSplashScreen() {
      SplashScreen splash = new SplashScreen("Data/ISplashDat");
      splash.Show(true, true);
      splash.Close(TimeSpan.FromSeconds(3));
    }

    private void RunTimer() {
      Timer timer = new Timer {
        // [1 min = 60,000 | 5 min = 300,000 | 30 min = 1,800,000 | 1 hr = 3,600,000]
        Interval = 1800000
      };
      timer.Start();
      timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e) {
      PopTheToast();
      //MessageBox.Show("The timer interval has been reached.", "Timer", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private static void PopTheToast() {
      // Get a toast XML template
      XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText03);

      // Fill in the text elements
      XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
      stringElements[0].AppendChild(toastXml.CreateTextNode("The Shivisi App"));
      stringElements[1].AppendChild(toastXml.CreateTextNode("Remember!" + Environment.NewLine + "You're not the one in charge here!"));

      // Specify the absolute path to an image
      string imagePath = "file:///" + Path.GetFullPath("Data/ISBackDat");
      XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
      imageElements[0].Attributes.GetNamedItem("src").NodeValue = imagePath;

      // Create the toast and attach event listeners
      ToastNotification toast = new ToastNotification(toastXml);

      // Show the toast. Be sure to specify the AppUserModelId on your application's shortcut!
      ToastNotificationManager.CreateToastNotifier(APP_ID).Show(toast);
    }

    protected override void OnExit(ExitEventArgs e) {
      notifyIcon.Dispose(); //the icon would clean up automatically, but this is cleaner
      base.OnExit(e);
    }
  }
}
