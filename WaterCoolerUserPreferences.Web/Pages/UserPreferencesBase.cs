using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

using System.Net;
using WaterCoolerUserPreferences.Models;

namespace WaterCoolerUserPreferences.Web.Pages
{
    public class UserPreferencesBase : ComponentBase
    {
        public UserPreferences preferences { get; set; }
        protected override Task OnInitializedAsync()
        {
            LoadPreferences();
            return base.OnInitializedAsync();
        }

        private void LoadPreferences()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Work\Projects\Watercooler\Development\Data\preferences.json");
            preferences = JsonConvert.DeserializeObject<UserPreferences>(json);
        }
    }
}
