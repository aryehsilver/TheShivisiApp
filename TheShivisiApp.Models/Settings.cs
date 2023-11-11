namespace TheShivisiApp.Models;

public class Settings {
  public int Id { get; set; }
  public bool RunOnStartUp { get; set; } = true;
  public bool ShowSplashScreen { get; set; } = true;
  public bool CheckUpdatesOnStartup { get; set; } = true;
  public bool UseRandomQuote { get; set; } = true;
  public int Interval { get; set; } = 30;
  public string NotifText { get; set; } = "";
  public DateTime LastUpdated { get; set; } = DateTime.Now;
  public string BearerToken { get; set; } = "=@$11~AN-F@S$3~O-A0~Xk$-R=q~w$B-i~a$ol-M@q=_$Dt~g@k-$m2~WE-T6~b=@MZ$7-uF@~1$RA-@KT=$Yh@~h-~sq$qA~O=@-dD~Nu$Cl0~A-8~Oy$Zz~I-TN~GQ~R=@C~TN-2$H~cj~M-$ku~W=";
}
