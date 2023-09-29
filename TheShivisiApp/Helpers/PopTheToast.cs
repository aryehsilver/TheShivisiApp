namespace TheShivisiApp.Helpers;

public class PopTheToast {
  public static void PopIt(string notifText, string source, int id) =>
    new ToastContentBuilder()
        .AddText("The Shivisi App")
        .AddText(!string.IsNullOrWhiteSpace(notifText) ? notifText : "Remember!" + Environment.NewLine + "You're not the one in charge here!")
        //.AddHeroImage(new Uri("file:///"))
        .AddAppLogoOverride(new Uri("file:///" + Path.GetFullPath("Data/Logo.png")), ToastGenericAppLogoCrop.Circle)
        .AddAttributionText(source)
        .AddArgument("Text", notifText)
        .AddArgument("Source", source)
        .AddArgument("Id", id)
        .Show(toast => toast.ExpirationTime = DateTime.Now.AddMinutes(1));

  public static void NewVersionAvailableToast(string version) =>
    new ToastContentBuilder()
        .AddText("The Shivisi App Update")
        .AddText("An update to The Shivisi App is available.")
        .AddAppLogoOverride(new Uri("file:///" + Path.GetFullPath("Data/Logo.png")), ToastGenericAppLogoCrop.Circle)
        //.AddAttributionText("")
        .AddButton(new ToastButton()
          .SetContent("Download")
          .AddArgument("Update", "download")
          .AddArgument("Version", version))
        .AddButton(new ToastButton()
          .SetContent("Dismiss")
          .AddArgument("Update", "dismiss"))
        .Show();
}
