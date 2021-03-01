using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace TheShivisiApp.Views {
  /// <summary>
  /// Interaction logic for Settings.xaml
  /// </summary>
  public partial class Settings : RadWindow {
    #region Props, Fields & Consts
    private const string APP_ID = "The Shivisi App";
    private static readonly string App_Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\The Shivisi App";
    private static readonly string Startup_Folder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
    public bool RunsOnStartup { get; set; } = true;
    public bool SplashScreen { get; set; } = true;
    public int Interval { get; set; } = 30;
    public string NotifText { get; set; } = "Remember!" + Environment.NewLine + "You're not the one in charge here!";
    public bool Success { get; set; } = false;
    #endregion

    public Settings() {
      if (!Directory.Exists(App_Folder)) {
        Directory.CreateDirectory(App_Folder);
      }

      InitializeComponent();

      Success = ReadFromXml();
    }

    private void Save_Click(object sender, RoutedEventArgs e) {
      RunsOnStartup = startup.IsChecked ?? true;
      SplashScreen = splashScreen.IsChecked ?? true;
      Interval = (int)interval.Value;
      NotifText = notifText.CurrentText;
      Save();
    }

    public async Task Save() {
      busyIndicator.IsBusy = true;
      bool success = false;
      Exception exception = new Exception();

      await Task.Run(() => {
        try {
          SaveToXml();
          // Set startup config
          if (RunsOnStartup) {
            IWshRuntimeLibrary.WshShell wsh = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(Startup_Folder + "\\The Shivisi App.lnk") as IWshRuntimeLibrary.IWshShortcut;
            shortcut.TargetPath = "C:\\Program Files (x86)\\The Shivisi App\\The Shivisi App.exe";
            shortcut.Description = "Shortcut to 'The Shivisi App'";
            shortcut.Save();
          } else {
            File.Delete(Path.Combine(Startup_Folder, "The Shivisi App.lnk"));
          }

          success = true;
        } catch (Exception ex) {
          success = false;
          exception = ex;
        }
      });

      if (success) {
        Application.Current.MainWindow.Close();
      } else {
        Alert(new DialogParameters {
          Header = "Error",
          Content = "Error saving the settings" + Environment.NewLine + exception.Message
        });
        busyIndicator.IsBusy = false;
      }
    }

    private void SaveToXml() {
      string data = $@"<Settings>
                         <Startup>{RunsOnStartup}</Startup>
                         <SplashScreen>{SplashScreen}</SplashScreen>
                         <Interval>{Interval}</Interval>
                         <NotifText>{NotifText}</NotifText>
                       </Settings>";

      System.Xml.XmlDocument toSave = new System.Xml.XmlDocument();
      toSave.LoadXml(data);
      toSave.Save(Path.Combine(App_Folder, "Settings.xml"));
    }

    private bool ReadFromXml() {
      bool success;
      Exception exception = new Exception();

      try {
        if (File.Exists(Path.Combine(App_Folder, "Settings.xml"))) {
          System.Xml.XmlDocument readFile = new System.Xml.XmlDocument();
          readFile.Load(Path.Combine(App_Folder, "Settings.xml"));

          System.Xml.XmlNode startupNode = readFile.SelectSingleNode("/Settings/Startup");
          startup.IsChecked = startupNode.InnerText == "True";

          System.Xml.XmlNode splashScreenNode = readFile.SelectSingleNode("/Settings/SplashScreen");
          splashScreen.IsChecked = splashScreenNode.InnerText == "True";

          System.Xml.XmlNode intervalNode = readFile.SelectSingleNode("/Settings/Interval");
          interval.Value = int.TryParse(intervalNode.InnerText, out int outInterval) ? outInterval : 30;

          System.Xml.XmlNode notifTextNode = readFile.SelectSingleNode("/Settings/NotifText");
          notifText.CurrentText = notifTextNode.InnerText;
          notifText.WatermarkContent = "Remember!" + Environment.NewLine + "You're not the one in charge here!";
        } else {
          startup.IsChecked = true;
          splashScreen.IsChecked = true;
          interval.Value = 30;
          notifText.CurrentText = "";
          notifText.WatermarkContent = "Remember!" + Environment.NewLine + "You're not the one in charge here!";
        }

        success = true;
      } catch (Exception ex) {
        success = false;
        exception = ex;
      }

      if (!success) {
        Alert(new DialogParameters {
          Header = "Error",
          Content = "Error reading the settings" + Environment.NewLine + exception.Message
        });
        return false;
      }

      return true;
    }

    private void Cancel_Click(object sender, RoutedEventArgs e) {
      Close();
    }

    private void Test_Click(object sender, RoutedEventArgs e) {
      PopTheToast();
    }

    public void PopTheToast() {
      XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText03);
      XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
      stringElements[0].AppendChild(toastXml.CreateTextNode("The Shivisi App"));
      stringElements[1].AppendChild(toastXml.CreateTextNode(!string.IsNullOrWhiteSpace(notifText.CurrentText) ? notifText.CurrentText : "Remember!" + Environment.NewLine + "You're not the one in charge here!"));
      string imagePath = "file:///" + Path.GetFullPath("Data/ISBackDat");
      XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
      imageElements[0].Attributes.GetNamedItem("src").NodeValue = imagePath;
      ToastNotification toast = new ToastNotification(toastXml);
      ToastNotificationManager.CreateToastNotifier(APP_ID).Show(toast);
    }
  }
}
