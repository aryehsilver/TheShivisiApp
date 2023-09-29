namespace TheShivisiApp.Views;

public partial class SettingsWindow : RadWindow {
  #region Props, Fields & Consts
  private AppDbContext _context;
  private static readonly string Startup_Folder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
  public Settings Settings { get; set; } = new();
  #endregion

  public SettingsWindow() {
    InitializeComponent();
    _context = new();
    version.Text = $"Version {VersionHelper.GetRunningVersion()}".Remove(13);

    Settings = _context.Settings.SingleOrDefault();
    lastUpdated.Text = $"Last updated: {Settings.LastUpdated:dddd dd MMMM yyyy hh:mm tt}";
    startup.IsChecked = Settings.RunOnStartUp;
    splashScreen.IsChecked = Settings.ShowSplashScreen;
    interval.Value = Settings.Interval;
    notifText.CurrentText = Settings.NotifText;
    notifText.WatermarkContent = "Remember!" + Environment.NewLine + "You're not the one in charge here!";
    random.IsChecked = Settings.UseRandomQuote;
    if (Settings.UseRandomQuote) {
      notifText.IsEnabled = false;
    }
  }

  private async void Save_Click(object sender, RoutedEventArgs e) {
    busyIndicator.IsBusy = true;
    try {
      Settings.RunOnStartUp = startup.IsChecked ?? true;
      Settings.ShowSplashScreen = splashScreen.IsChecked ?? true;
      Settings.Interval = (int)interval.Value;
      Settings.NotifText = notifText.CurrentText;
      Settings.UseRandomQuote = random.IsChecked ?? true;
      Settings.LastUpdated = DateTime.Now;
      _context.Update(Settings);
      await _context.SaveChangesAsync();

      if (Settings.RunOnStartUp) {
        SetStartupLink();
      } else {
        File.Delete(Path.Combine(Startup_Folder, "The Shivisi App.lnk"));
      }

      Application.Current.MainWindow.Close();
    } catch (Exception ex) {
      Alert(new DialogParameters {
        Header = "Error",
        Content = "Error saving the settings" + Environment.NewLine + ex.Message
      });
      busyIndicator.IsBusy = false;
    }
  }

  private static void SetStartupLink() {
    IWshRuntimeLibrary.WshShell wsh = new();
    IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(Startup_Folder + "\\The Shivisi App.lnk") as IWshRuntimeLibrary.IWshShortcut;
    shortcut.TargetPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "The Shivisi App.exe");
    shortcut.Description = "Shortcut to 'The Shivisi App'";
    shortcut.Save();
  }

  private void RandomQuotes_Click(object sender, RoutedEventArgs e) {
    notifText.IsEnabled = !notifText.IsEnabled;
    Settings.UseRandomQuote = random.IsChecked ?? true;
  }

  private void ViewQuotes_Click(object sender, RoutedEventArgs e) =>
    new QuotesListWindow().Show();

  private void Cancel_Click(object sender, RoutedEventArgs e) =>
    Close();

  private async void Test_Click(object sender, RoutedEventArgs e) {
    if (Settings.UseRandomQuote) {
      Random random = new();
      List<Quote> quotesList = await _context.Quotes.ToListAsync();
      int rnd = random.Next(quotesList.Count);
      Quote quote = quotesList.FirstOrDefault(q => q.Id == rnd);
      PopTheToast.PopIt(quote.QuotedText, quote.Source, quote.Id);
    } else {
      PopTheToast.PopIt(!string.IsNullOrWhiteSpace(notifText.CurrentText) ? notifText.CurrentText : $"Remember!{Environment.NewLine}You're not the one in charge here!", $"Via TSA - {$"Version {VersionHelper.GetRunningVersion()}".Remove(13)}", 0);
    }
  }

  private void Hyperlink_Click(object sender, RoutedEventArgs e) =>
    new AboutWindow().Show();
}
