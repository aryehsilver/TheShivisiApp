using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.IO;

namespace TheShivisiApp.Helpers {
  public class PopTheToast {
    public static void PopIt(string notifText) =>
      new ToastContentBuilder()
          .AddText("The Shivisi App")
          .AddText(!string.IsNullOrWhiteSpace(notifText) ? notifText : "Remember!" + Environment.NewLine + "You're not the one in charge here!")
          //.AddHeroImage(new Uri("file:///"))
          .AddAppLogoOverride(new Uri("file:///" + Path.GetFullPath("Data/ShivisiAppNewLogoVariant.png")), ToastGenericAppLogoCrop.Circle)
          .AddAttributionText("Via TSA")
          .Show(toast => toast.ExpirationTime = DateTime.Now.AddMinutes(1));
  }
}
