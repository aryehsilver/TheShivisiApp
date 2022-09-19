using System.Globalization;
using System.Windows.Controls;

namespace TheShivisiApp.Helpers;

public class GridHelper {
  // Sadly, the two methods DefineGridRows() and DefineGridCols() are horribly similar. Unfortunately, the differences are enough to make it not worth trying to refactor them to use one common helper method
  private const string StarRegex = @"^(\d*\.)?\d+\*$";

  #region GridRows

  public static DependencyProperty GridRowsProperty = DependencyProperty.RegisterAttached("GridRows", typeof(string),
    MethodBase.GetCurrentMethod().DeclaringType,
    new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsArrange, GridRowsPropertyChanged));

  public static string GetGridRows(Grid theGrid) =>
    Convert.ToString(theGrid.GetValue(GridRowsProperty));

  public static void SetGridRows(Grid theGrid, string value) =>
    theGrid.SetValue(GridRowsProperty, value);

  private static void GridRowsPropertyChanged(object sender, DependencyPropertyChangedEventArgs e) {
    Grid This = sender as Grid;
    if (This == null) {
      throw new Exception("Only elements of type 'Grid' can utilize the 'GridRows' attached property");
    }
    DefineGridRows(This);
  }

  private static void DefineGridRows(Grid theGrid) {
    string[] rows = GetGridRows(theGrid).Split(Convert.ToChar(","));
    theGrid.RowDefinitions.Clear();
    for (int rowNumber = 0; rowNumber < rows.Length; rowNumber++) {
      string row = rows[rowNumber].ToLower();
      if (row == "gs" || row.StartsWith("gs:")) {
        int colSpan = 1;
        if (row.StartsWith("gs:")) {
          string colSpanStr = row.Substring(3);
          if (!int.TryParse(colSpanStr, out colSpan)) {
            throw new FormatException("A grid splitter row must have an integer column span");
          }
        }
        theGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Pixel) });
        GridSplitter gs = new GridSplitter {
          Height = 3,
          MinHeight = 3,
          MaxHeight = 3,
          Margin = new Thickness(0, 2, 0, 2),
          HorizontalAlignment = HorizontalAlignment.Stretch,
          VerticalAlignment = VerticalAlignment.Center
        };
        Grid.SetColumn(gs, 0);
        Grid.SetRow(gs, rowNumber);
        Grid.SetColumnSpan(gs, colSpan);
        theGrid.Children.Add(gs);
      } else {
        string rowHeight = row;
        string minHeight;
        double minHeightNumber = 0;
        if (row.IndexOf(":") != -1) {
          string[] bits = row.Split(new[] { ':' });
          rowHeight = bits[0];
          minHeight = bits[1];
          if (!double.TryParse(minHeight, out minHeightNumber)) {
            throw new FormatException("The minimum height for a row must be an number. The value \"" + minHeight + "\" is not valid");
          }
        }
        switch (rowHeight.Trim().ToLower()) {
          case "auto":
            theGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto), MinHeight = minHeightNumber });
            break;
          case "*":
            theGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star), MinHeight = minHeightNumber });
            break;
          default:
            if (System.Text.RegularExpressions.Regex.IsMatch(rowHeight, StarRegex)) {
              theGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(Convert.ToInt32(rowHeight.Substring(0, rowHeight.IndexOf(Convert.ToChar("*")))), GridUnitType.Star), MinHeight = minHeightNumber });
            } else if (IsFloat(rowHeight)) {
              theGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(Convert.ToDouble(rowHeight), GridUnitType.Pixel), MinHeight = minHeightNumber });
            } else {
              throw new Exception("The only acceptable value for the 'GridRows' attached property is a comma separated list comprised of the following options:" + Environment.NewLine + Environment.NewLine
                + "Auto,*,x (where x is the pixel height of the row), x* (where x is the row height multiplier), gs:x (for a grid splitter, where x is the column span)");
            }
            break;
        }
      }
    }
  }

  #endregion

  #region GridCols

  public static DependencyProperty GridColsProperty = DependencyProperty.RegisterAttached("GridCols", typeof(string),
    MethodBase.GetCurrentMethod().DeclaringType,
    new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsArrange, GridColsPropertyChanged));

  public static string GetGridCols(Grid theGrid) =>
    Convert.ToString(theGrid.GetValue(GridColsProperty));

  public static void SetGridCols(Grid theGrid, string value) =>
    theGrid.SetValue(GridColsProperty, value);

  private static void GridColsPropertyChanged(object sender, DependencyPropertyChangedEventArgs e) {
    Grid This = sender as Grid;
    if (This == null) {
      throw new Exception("Only elements of type 'Grid' can utilize the 'GridCols' attached property");
    }
    DefineGridCols(This);
  }

  private static void DefineGridCols(Grid theGrid) {
    string[] cols = GetGridCols(theGrid).Split(Convert.ToChar(","));
    theGrid.ColumnDefinitions.Clear();
    for (int colNumber = 0; colNumber < cols.Length; colNumber++) {
      string col = cols[colNumber].ToLower();
      if (col == "gs" || col.StartsWith("gs:")) {
        int rowSpan = 1;
        if (col.StartsWith("gs:")) {
          string rowSpanStr = col.Substring(3);
          if (!int.TryParse(rowSpanStr, out rowSpan)) {
            throw new FormatException("A grid splitter row must have an integer row span");
          }
        }
        theGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(7, GridUnitType.Pixel) });
        GridSplitter gs = new GridSplitter {
          Width = 3,
          MinWidth = 3,
          MaxWidth = 3,
          Margin = new Thickness(2, 0, 2, 0),
          HorizontalAlignment = HorizontalAlignment.Center,
          VerticalAlignment = VerticalAlignment.Stretch
        };
        Grid.SetColumn(gs, colNumber);
        Grid.SetRow(gs, 0);
        Grid.SetRowSpan(gs, rowSpan);
        theGrid.Children.Add(gs);
      } else {
        string colWidth = col;
        string minWidth;
        double minWidthNumber = 0;
        if (col.IndexOf(":") != -1) {
          string[] bits = col.Split(new[] { ':' });
          colWidth = bits[0];
          minWidth = bits[1];
          if (!double.TryParse(minWidth, out minWidthNumber)) {
            throw new FormatException("The minimum width for a column must be an number. The value \"" + minWidth + "\" is not valid");
          }
        }
        switch (colWidth.Trim().ToLower()) {
          case "auto":
            theGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto), MinWidth = minWidthNumber });
            break;
          case "*":
            theGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star), MinWidth = minWidthNumber });
            break;
          default:
            if (System.Text.RegularExpressions.Regex.IsMatch(colWidth, StarRegex)) {
              theGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(Convert.ToDouble(colWidth.Substring(0, colWidth.IndexOf(Convert.ToChar("*"))), CultureInfo.InvariantCulture), GridUnitType.Star), MinWidth = minWidthNumber });
            } else if (IsFloat(colWidth)) {
              theGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(Convert.ToDouble(colWidth, CultureInfo.InvariantCulture), GridUnitType.Pixel), MinWidth = minWidthNumber });
            } else {
              throw new Exception("The only acceptable value for the 'GridCols' attached property is a comma separated list comprised of the following options:" + Environment.NewLine + Environment.NewLine
                + "Auto,*,x (where x is the pixel width of the column), x* (where x is the column width multiplier), gs:x (for a grid splitter, where x is the row span)");
            }
            break;
        }
      }
    }
  }

  #endregion

  #region Miscellaneous

  private static bool IsFloat(string s) =>
    float.TryParse(s, out float n);

  #endregion
}
