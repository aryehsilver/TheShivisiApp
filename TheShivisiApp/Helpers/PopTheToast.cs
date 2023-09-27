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
}
