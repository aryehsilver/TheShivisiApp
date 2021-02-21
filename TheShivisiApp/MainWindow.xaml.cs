using System;
using System.IO;
using System.Windows;
using Telerik.Windows.Controls;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace TheShivisiApp {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : RadWindow {
    private const string APP_ID = "The Shivisi App";
    public MainWindow() {
      InitializeComponent();
      DataContext = this;
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      // Get a toast XML template
      XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText03);

      // Fill in the text elements
      XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
      stringElements[0].AppendChild(toastXml.CreateTextNode("The Shivisi App"));
      stringElements[1].AppendChild(toastXml.CreateTextNode("Here is your notification to remind you that there is only one in charge here"));

      // Specify the absolute path to an image
      string imagePath = "file:///" + Path.GetFullPath("ISBackDat");
      XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
      imageElements[0].Attributes.GetNamedItem("src").NodeValue = imagePath;

      // Create the toast and attach event listeners
      ToastNotification toast = new ToastNotification(toastXml);

      // Show the toast. Be sure to specify the AppUserModelId on your application's shortcut!
      ToastNotificationManager.CreateToastNotifier(APP_ID).Show(toast);
    }
  }
}
