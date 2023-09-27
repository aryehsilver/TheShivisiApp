namespace TheShivisiApp.Views;

public partial class EditQuoteWindow : RadWindow {
  private AppDbContext _context;
  public Quote Quote { get; set; } = new();

  public EditQuoteWindow(Quote quote) {
    InitializeComponent();
    _context = new();
    Quote = quote;
    window.Header = quote.Id > 0 ? "Edit quote" : "New quote";
    quoteText.Text = quote.QuotedText;
    source.Text = quote.Source;
    quoteText.WatermarkContent = $"Remember!{Environment.NewLine}You're not the one in charge here!";
    saveButton.Focus();
  }

  private async void Save_Click(object sender, RoutedEventArgs e) {
    Quote.QuotedText = quoteText.Text;
    Quote.Source = source.Text;
    _context.Quotes.Update(Quote);
    await _context.SaveChangesAsync();
  }

  private void Cancel_Click(object sender, RoutedEventArgs e) =>
    Close();
}
