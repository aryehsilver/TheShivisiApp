using System.Windows.Controls;
using System.Windows.Input;

namespace TheShivisiApp.Views;

public partial class QuotesListWindow : RadWindow {
  private AppDbContext _context;
  private Quote Quote { get; set; } = new();
  private ObservableCollection<Quote> Quotes { get; set; } = new();
  private ObservableCollection<Quote> SearchedQuotes { get; set; } = new();

  public QuotesListWindow() {
    InitializeComponent();
    _context = new();
    Quotes = _context.Quotes.ToObservableCollection();
    list.ItemsSource = Quotes;
    search.Focus();
  }

  private void New_Click(object sender, RoutedEventArgs e) =>
    new EditQuoteWindow(new()).Show();

  private void Delete_Click(object sender, RoutedEventArgs e) =>
    Confirm(new DialogParameters {
      Content = "Are you sure you want to delete this quote?",
      Header = "Confirm delete",
      Closed = OnClosed
    });

  private void Edit_Click(object sender, RoutedEventArgs e) =>
    new EditQuoteWindow(Quote).Show();

  private async void OnClosed(object sender, WindowClosedEventArgs e) {
    bool? result = e.DialogResult;
    if (result == true) {
      _context.Quotes.Remove(Quote);
      await _context.SaveChangesAsync();
      Quotes.Remove(Quote);
    }
  }

  private void ListSelected_Changed(object sender, SelectionChangedEventArgs e) =>
    Quote = list.SelectedItem as Quote;

  private void On_Focus(object sender, KeyboardFocusChangedEventArgs e) =>
    (sender as RadListBoxItem).IsSelected = true;

  private void SearchText_Changed(object sender, TextChangedEventArgs e) {
    string searchText = (sender as TextBox).Text;
    SearchedQuotes = Quotes.Where(q => q.QuotedText.ToLower().Contains(searchText.ToLower())).ToObservableCollection();
    list.ItemsSource = SearchedQuotes;
  }

  private async void Text_Changed(object sender, TextChangedEventArgs e) {
    //Quote.QuotedText = (sender as TextBox).Text;
    //_context.Quotes.Update(Quote);
    //await _context.SaveChangesAsync();
  }
}
