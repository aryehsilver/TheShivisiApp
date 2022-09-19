namespace TheShivisiApp;

  public partial class App : Application {
    #region Props, Fields & consts
    private static readonly string App_Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\The Shivisi App";
    private TaskbarIcon notifyIcon;
    private Timer timer;
    public DateTime LastRead { get; set; }
    public bool RunsOnStartup { get; set; } = true;
    public bool SplashScreen { get; set; } = true;
    public double Interval { get; set; } = 30;
    public string NotifText { get; set; } = "Remember!" + Environment.NewLine + "You're not the one in charge here!";
    #endregion

    protected override void OnStartup(StartupEventArgs e) {
      base.OnStartup(e);
      //create the notifyicon (it's a resource declared in NotifyIconResources.xaml)
      notifyIcon = (TaskbarIcon)FindResource("NotifyIcon");

      StyleManager.ApplicationTheme = new FluentTheme();
      FluentPalette.LoadPreset(FluentPalette.ColorVariation.Dark);
      ThemeEffectsHelper.IsAcrylicEnabled = false;

      Start();
    }

    public void Start() {
      if (!Directory.Exists(App_Folder)) {
        Directory.CreateDirectory(App_Folder);
      }

      ReadFromXml();

      ShowSplashScreen();
      RunTimer();
    }

    private void ReadFromXml() {
      bool success;
      Exception exception = new();

      try {
        if (File.Exists(Path.Combine(App_Folder, "Settings.xml"))) {
          System.Xml.XmlDocument readFile = new();
          readFile.Load(Path.Combine(App_Folder, "Settings.xml"));

          System.Xml.XmlNode startupNode = readFile.SelectSingleNode("/Settings/Startup");
          RunsOnStartup = startupNode.InnerText == "True";

          System.Xml.XmlNode splashScreenNode = readFile.SelectSingleNode("/Settings/SplashScreen");
          SplashScreen = splashScreenNode.InnerText == "True";

          System.Xml.XmlNode intervalNode = readFile.SelectSingleNode("/Settings/Interval");
          Interval = double.TryParse(intervalNode.InnerText, out double outInterval) ? outInterval : 30;

          System.Xml.XmlNode notifTextNode = readFile.SelectSingleNode("/Settings/NotifText");
          NotifText = notifTextNode.InnerText;
        } else {
          RunsOnStartup = true;
          SplashScreen = true;
          Interval = 30;
          NotifText = "Remember!" + Environment.NewLine + "You're not the one in charge here!";
        }

        LastRead = DateTime.Now;

        if (Interval <= 0) {
          RadWindow.Alert(new DialogParameters {
            Header = "Error",
            Content = "The interval value must be greater than 0" + Environment.NewLine + "1 minute intervals will be used instead"
          });
          Interval = 1;
        }
        success = true;
      } catch (Exception ex) {
        success = false;
        exception = ex;
      }

      if (!success) {
        RadWindow.Alert(new DialogParameters {
          Header = "The Shivisi App - Error",
          Content = "Error reading the settings" + Environment.NewLine + exception.Message
        });
      }
    }

    private void ShowSplashScreen() {
      if (SplashScreen) {
      SplashScreen splash = new("Data/SplashScreen.png");
        splash.Show(true, true);
      splash.Close(TimeSpan.FromSeconds(5));
      }
    }

    private void RunTimer() {
      timer = new Timer {
        // [1 min = 60,000 | 5 min = 300,000 | 30 min = 1,800,000 | 1 hr = 3,600,000]
        Interval = Interval * 60000
      };
      timer.Start();
      timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e) {
      // ISSUE: This will only get hit the next time the timer finishes it's elapsed time.
      // What if the user has chosen a smaller interval, say from 30 min down to 5,
      // how will the app know to change it until another 30 min passes and we hit the elapsed?
      // Settings need to raise an event which will be picked up here...
      CheckTimeStamps();
      PopTheToast.PopIt(NotifText);
    }

    private void CheckTimeStamps() {
      DateTime time = File.GetLastWriteTime(Path.Combine(App_Folder, "Settings.xml"));
      if (LastRead < time) {
        System.Xml.XmlDocument readFile = new();
        readFile.Load(Path.Combine(App_Folder, "Settings.xml"));

        System.Xml.XmlNode intervalNode = readFile.SelectSingleNode("/Settings/Interval");
        timer.Interval = (double.TryParse(intervalNode.InnerText, out double outInterval) ? outInterval : 30) * 60000;

        System.Xml.XmlNode notifTextNode = readFile.SelectSingleNode("/Settings/NotifText");
        NotifText = notifTextNode.InnerText;

        LastRead = DateTime.Now;
      }
    }

    protected override void OnExit(ExitEventArgs e) {
      notifyIcon.Dispose(); // the icon would clean up automatically, but this is cleaner
      base.OnExit(e);
    }
  }
