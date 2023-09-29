using System.Windows.Input;

namespace TheShivisiApp.ViewModels;

/// <summary>
/// Provides bindable properties and commands for the NotifyIcon. In this sample, the
/// view model is assigned to the NotifyIcon in XAML. Alternatively, the startup routing
/// in App.xaml.cs could have created this view model, and assigned it to the NotifyIcon.
/// </summary>
public class NotifyIconViewModel {
  public ICommand ShowWindowCommand => new DelegateCommand {
    //CanExecuteFunc = () => Application.Current.MainWindow == null,
    CommandAction = () => {
      new SettingsWindow().Show();
    }
  };

  public ICommand ShowQuotesCommand => new DelegateCommand {
    //CanExecuteFunc = () => Application.Current.MainWindow == null,
    CommandAction = () => {
      new QuotesListWindow().Show();
    }
  };

  public ICommand NewQuoteWindowCommand => new DelegateCommand {
    //CanExecuteFunc = () => Application.Current.MainWindow == null,
    CommandAction = () => {
      new EditQuoteWindow(new()).Show();
    }
  };

  public ICommand CheckForUpdatesCommand => new DelegateCommand {
    //CanExecuteFunc = () => Application.Current.MainWindow == null,
    CommandAction = () => {
      new AboutWindow(true).Show();
    }
  };

  /// <summary>
  /// Hides the main window. This command is only enabled if a window is open.
  /// </summary>
  public ICommand HideWindowCommand => new DelegateCommand {
    CommandAction = () => Application.Current.MainWindow.Close(),
    CanExecuteFunc = () => Application.Current.MainWindow != null
  };

  /// <summary>
  /// Shuts down the application.
  /// </summary>
  public ICommand ExitApplicationCommand =>
    new DelegateCommand { CommandAction = () => Application.Current.Shutdown() };
}

public class DelegateCommand : ICommand {
  public Action CommandAction { get; set; }
  public Func<bool> CanExecuteFunc { get; set; }

  public void Execute(object parameter) =>
    CommandAction();

  public bool CanExecute(object parameter) =>
    CanExecuteFunc == null || CanExecuteFunc();

  public event EventHandler CanExecuteChanged {
    add => CommandManager.RequerySuggested += value;
    remove => CommandManager.RequerySuggested -= value;
  }
}
