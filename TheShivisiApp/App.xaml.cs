namespace TheShivisiApp;

public partial class App : Application {
  #region Props, Fields & consts
  private AppDbContext _context;
  private TaskbarIcon _notifyIcon;
  private Timer _timer;
  public DateTime LastRead { get; set; }
  public Settings Settings { get; set; } = new();
  #endregion

  protected override void OnStartup(StartupEventArgs e) {
    base.OnStartup(e);

    bool showSettings = true;

    // Listen to notification activation
    ToastNotificationManagerCompat.OnActivated += toastArgs => {
      // Obtain the arguments from the notification
      ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

      // Obtain any user input (text boxes, menu selections) from the notification
      //ValueSet userInput = toastArgs.UserInput;

      // Need to dispatch to UI thread if performing UI operations
      Current.Dispatcher.Invoke(async delegate {
        if (!args.Any(a => a.Key == "Update")) {
          QuoteWindow quoteWindow = new(args.FirstOrDefault(a => a.Key == "Text").Value, args.FirstOrDefault(a => a.Key == "Source").Value, args.FirstOrDefault(a => a.Key == "Id").Value);
          quoteWindow.Show();
          quoteWindow.IsTopmost = true;
          quoteWindow.IsTopmost = false;
          quoteWindow.Focus();
        } else {
          if (args.Any(a => a.Key == "Update" && a.Value == "download")) {
            await UpdateHelper.DownloadUpdate(args.FirstOrDefault(a => a.Key == "Version").Value);
          }
        }
      });

      showSettings = false;
    };

    if (showSettings) {
      _context = new();
      _context.Database.Migrate();

      //create the notifyIcon (it's a resource declared in NotifyIconResources.xaml)
      _notifyIcon = (TaskbarIcon)FindResource("NotifyIcon");

      StyleManager.ApplicationTheme = new Windows11Theme();
      Windows11Palette.LoadPreset(Windows11Palette.ColorVariation.Dark);
      ThemeEffectsHelper.IsAcrylicEnabled = false;

      Settings = _context.Settings.SingleOrDefault();
      LastRead = DateTime.Now;

      ShowSplashScreen();
      RunTimer();
    }

    _ = UpdateHelper.CheckForUpdates();
    UpdateHelper.CleanUpInstallationFiles();
  }

  private void ShowSplashScreen() {
    if (Settings.ShowSplashScreen) {
      SplashScreen splash = new("Data/SplashScreen.png");
      splash.Show(true, true);
      splash.Close(TimeSpan.FromSeconds(5));
    }
  }

  private void RunTimer() {
    _timer = new Timer {
      // [1 min = 60,000 | 5 min = 300,000 | 30 min = 1,800,000 | 1 hr = 3,600,000]
      Interval = Settings.Interval * 60000
    };
    _timer.Start();
    _timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
  }

  private async void Timer_Elapsed(object sender, ElapsedEventArgs e) {
    // ISSUE: This will only get hit the next time the timer finishes it's elapsed time.
    // What if the user has chosen a smaller interval, say from 30 min down to 5,
    // how will the app know to change it until another 30 min passes and we hit the elapsed?
    // Settings need to raise an event which will be picked up here...
    await CheckTimeStamps();
    if (Settings.UseRandomQuote) {
      Random random = new();
      List<Quote> quotesList = await _context.Quotes.ToListAsync();
      int rnd = random.Next(quotesList.Count);
      Quote quote = quotesList.FirstOrDefault(q => q.Id == rnd);
      PopTheToast.PopIt(quote.QuotedText, quote.Source, quote.Id);
    } else {
      PopTheToast.PopIt($"Remember!{Environment.NewLine}You're not the one in charge here!", $"Via TSA - {$"Version {VersionHelper.GetRunningVersion()}".Remove(13)}", 0);
    }
  }

  private async Task CheckTimeStamps() {
    DateTime lastUpdated = Settings.LastUpdated;
    if (LastRead < lastUpdated) {
      Settings = await _context.Settings.SingleOrDefaultAsync();
      _timer.Interval = Settings.Interval * 60000;
      LastRead = DateTime.Now;
    }
  }

  protected override void OnExit(ExitEventArgs e) {
    _notifyIcon.Dispose(); // the icon would clean up automatically, but this is cleaner
    base.OnExit(e);
  }
}
