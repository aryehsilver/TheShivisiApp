using Microsoft.EntityFrameworkCore;

namespace TheShivisiApp.Models;

public class AppDbContext : DbContext {
  private static readonly string App_Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\The Shivisi App";

  public DbSet<Settings> Settings { get; set; } = null!;
  public DbSet<Quote> Quotes { get; set; } = null!;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
    optionsBuilder.UseSqlite(@$"Data Source={App_Folder}\\TSA_Quotes.db");

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Settings>().HasData(new Settings {
      Id = 1,
      Interval = 30,
      RunOnStartUp = true,
      ShowSplashScreen = true,
      UseRandomQuote = true
    });

    SeedData.TheData(modelBuilder);
  }
}
