using Newtonsoft.Json;
using Preferences.Models;
using System.Net;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var webClient = new WebClient();
var json = webClient.DownloadString(@"C:\Work\Projects\Watercooler\Development\Data\preferences.json");
var preferences = JsonConvert.DeserializeObject<UserPreferences>(json);
Console.WriteLine(preferences.topics.Count);
foreach (var item in preferences.topics)
{
    Console.WriteLine(item.topic);
}