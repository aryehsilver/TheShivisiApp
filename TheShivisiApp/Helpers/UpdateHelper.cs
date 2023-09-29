using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TheShivisiApp.Helpers;

public static class UpdateHelper {
  public static async Task<(bool, string)> CheckForUpdates() {
    string Url = "https://api.github.com/repos/aryehsilver/TheShivisiApp/releases";
    try {
      using HttpClient client = CreateClient();
      List<Release> release = JsonConvert.DeserializeObject<List<Release>>(await client.GetStringAsync(Url));
      string version = VersionHelper.GetRunningVersion().ToString();
      if (release.FirstOrDefault().TagName.Replace("v", "") != version.Remove(5)) {
        PopTheToast.NewVersionAvailableToast(release.FirstOrDefault().TagName.Replace("v", ""));
        return (true, release.FirstOrDefault().TagName.Replace("v", ""));
      }
    } catch (Exception ex) {
      Debug.WriteLine("Check for update error: " + ex.Message);
    }

    return (false, "");
  }

  public static async Task DownloadUpdate(string version) {
    string Url = $"https://github.com/aryehsilver/TheShivisiApp/releases/download/v{version}/The.Shivisi.App.Setup.exe";
    Debug.WriteLine(Url);
    string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\The Shivisi App";
    try {
      if (!Directory.Exists(filePath)) {
        Directory.CreateDirectory(filePath);
      }
      filePath += "\\New_Version.exe";
      await DownloadTheFile(filePath, Url);
      StartInstallerAndExit(filePath);
    } catch (Exception ex) {
      Debug.WriteLine("Download update error: " + ex.Message);
    }
  }

  private static async Task DownloadTheFile(string filePath, string url) {
    using HttpClient client = CreateClient();
    using Stream downloadStream = await client.GetStreamAsync(url);
    using FileStream fileStream = File.Create(filePath);
    await downloadStream.CopyToAsync(fileStream);
  }

  private static HttpClient CreateClient() {
    HttpClient client = new();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "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");
    client.DefaultRequestHeaders.Add("User-Agent", "TSA");
    return client;
  }

  private static void StartInstallerAndExit(string filePath) {
    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
    Application.Current.Shutdown();
  }
}

#region Json Classes
public class Author {
  public string Login { get; set; } = "";
  public int Id { get; set; }
  public string NodeId { get; set; } = "";
  [JsonProperty("avatar_url")]
  public string AvatarUrl { get; set; } = "";
  [JsonProperty("gravatar_id")]
  public string GravatarId { get; set; } = "";
  public string Url { get; set; } = "";
  [JsonProperty("html_url")]
  public string HtmlUrl { get; set; } = "";
  [JsonProperty("followers_url")]
  public string FollowersUrl { get; set; } = "";
  [JsonProperty("following_url")]
  public string FollowingUrl { get; set; } = "";
  [JsonProperty("gists_url")]
  public string GistsUrl { get; set; } = "";
  [JsonProperty("starred_url")]
  public string StarredUrl { get; set; } = "";
  [JsonProperty("subscriptions_url")]
  public string SubscriptionsUrl { get; set; } = "";
  [JsonProperty("organizations_url")]
  public string OrganizationsUrl { get; set; } = "";
  [JsonProperty("repos_url")]
  public string ReposUrl { get; set; } = "";
  [JsonProperty("events_url")]
  public string EventsUrl { get; set; } = "";
  [JsonProperty("received_events_url")]
  public string ReceivedEventsUrl { get; set; } = "";
  public string Type { get; set; } = "";
  [JsonProperty("site_admin")]
  public bool SiteAdmin { get; set; }
}

public class Asset {
  public string Url { get; set; } = "";
  public int Id { get; set; }
  [JsonProperty("node_id")]
  public string NodeId { get; set; } = "";
  public string Name { get; set; } = "";
  public object Label { get; set; } = null;
  public Author Uploader { get; set; } = new();
  [JsonProperty("content_type")]
  public string ContentType { get; set; } = "";
  public string State { get; set; } = "";
  public long Size { get; set; }
  [JsonProperty("download_count")]
  public int DownloadCount { get; set; }
  [JsonProperty("created_at")]
  public DateTime CreatedAt { get; set; }
  [JsonProperty("updated_at")]
  public DateTime UpdatedAt { get; set; }
  [JsonProperty("browser_download_url")]
  public string BrowserDownloadUrl { get; set; } = "";
}

public class Release {
  public string Url { get; set; } = "";
  [JsonProperty("assets_url")]
  public string AssetsUrl { get; set; } = "";
  [JsonProperty("upload_url")]
  public string UploadUrl { get; set; } = "";
  [JsonProperty("html_url")]
  public string HtmlUrl { get; set; } = "";
  public int Id { get; set; }
  public Author Author { get; set; } = new();
  [JsonProperty("node_id")]
  public string NodeId { get; set; } = "";
  [JsonProperty("tag_name")]
  public string TagName { get; set; } = "";
  [JsonProperty("target_commitish")]
  public string TargetCommitish { get; set; } = "";
  public string Name { get; set; } = "";
  public bool Draft { get; set; }
  [JsonProperty("prerelease")]
  public bool Prerelease { get; set; }
  [JsonProperty("created_at")]
  public DateTime CreatedAt { get; set; }
  [JsonProperty("published_at")]
  public DateTime PublishedAt { get; set; }
  public List<Asset> Assets { get; set; } = new();
  [JsonProperty("tarball_url")]
  public string TarballUrl { get; set; } = "";
  [JsonProperty("zipball_url")]
  public string ZipballUrl { get; set; } = "";
  public string Body { get; set; } = "";
}
#endregion