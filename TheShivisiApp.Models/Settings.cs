namespace TheShivisiApp.Models;

public class Settings {
  public int Id { get; set; }
  public bool RunOnStartUp { get; set; } = true;
  public bool ShowSplashScreen { get; set; } = true;
  public bool UseRandomQuote { get; set; } = true;
  public int Interval { get; set; } = 30;
  public string NotifText { get; set; } = "";
  public DateTime LastUpdated { get; set; } = DateTime.Now;
}
