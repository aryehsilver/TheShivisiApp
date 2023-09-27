namespace TheShivisiApp.Views;

public partial class QuoteWindow : RadWindow {
  private int Id;

  public QuoteWindow(string text, string source, string id) {
    InitializeComponent();
    textBlock.Text = text;
    sourceBlock.Text = source;
    if (int.TryParse(id, out Id) && Id > 0) {
      edit.Visibility = Visibility.Visible;
    }
  }

  private async void Edit_Click(object sender, RoutedEventArgs e) {
    using AppDbContext context = new();
    new EditQuoteWindow(await context.Quotes.FirstOrDefaultAsync(q => q.Id == Id)).Show();
    Close();
  }
}
