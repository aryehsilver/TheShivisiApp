using System.Diagnostics;

namespace TheShivisiApp.Views;

public partial class AboutWindow : RadWindow {
  private string _version = "";

  public AboutWindow(bool checkForUpdates = false) {
    InitializeComponent();
    version.Text = ("Current version: " + VersionHelper.GetRunningVersion()).Remove(22);
    date.Text = DateTime.Now.Year.ToString();
    if (checkForUpdates) {
      CheckForUpdates_Click(null, null);
    }
  }

  private void Tab_Changed(object sender, RadSelectionChangedEventArgs e) =>
    window.Header = ((RadTabItem)e.AddedItems[0]).Header.ToString();

  private void Releases_Click(object sender, RoutedEventArgs e) =>
    Process.Start(new ProcessStartInfo("https://github.com/aryehsilver/TheShivisiApp/releases") { UseShellExecute = true });

  private void Creator_Click(object sender, RoutedEventArgs e) =>
    Process.Start(new ProcessStartInfo("https://alldev.co.uk") { UseShellExecute = true });

  private async void CheckForUpdates_Click(object sender, RoutedEventArgs e) {
    busyLoader.IsBusy = true;
    update.Content = "";
    (bool updateAvailable, _version) = await UpdateHelper.CheckForUpdates();
    if (updateAvailable) {
      doUpdate.Content = $"Update to {_version}";
      doUpdate.Visibility = Visibility.Visible;
      update.Visibility = Visibility.Collapsed;
      update.Content = "Check for updates";
    } else {
      update.Content = "You're up to date";
      update.IsEnabled = false;
    }
    busyLoader.IsBusy = false;
  }

  private async void DoUpdate_Click(object sender, RoutedEventArgs e) {
    string content = doUpdate.Content.ToString();
    busyLoader.IsBusy = true;
    doUpdate.Content = "";
    await UpdateHelper.DownloadUpdate(_version);
    busyLoader.IsBusy = false;
    doUpdate.Content = content;
  }
}
