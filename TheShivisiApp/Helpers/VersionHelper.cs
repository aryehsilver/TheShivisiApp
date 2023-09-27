namespace TheShivisiApp.Helpers;

public static class VersionHelper {
  public static Version GetRunningVersion() =>
    Assembly.GetExecutingAssembly().GetName().Version;
}
