using System.Diagnostics;
using System.Windows.Media;

namespace TheShivisiApp.Views;

public partial class BearerTokenWindow : RadWindow {
  public BearerTokenWindow() {
    InitializeComponent();
    textBox.Focus();
  }

  private void SendEmail_Click(object sender, RoutedEventArgs e) =>
    Process.Start(new ProcessStartInfo("mailto:tsa@alldev.co.uk") { UseShellExecute = true });

  private async void Ok_Click(object sender, RoutedEventArgs e) {
    if (!string.IsNullOrWhiteSpace(textBox.Text)) {
      using AppDbContext context = new();
      Settings settings = await context.Settings.SingleOrDefaultAsync();
      settings.BearerToken = textBox.Text;
      await context.SaveChangesAsync();
      DialogResult = true;
      Close();
    } else {
      textBox.BorderBrush = Brushes.Red;
      textBox.BorderThickness = new Thickness(1);
    }
  }

  private void Close_Click(object sender, RoutedEventArgs e) =>
    Close();
}
