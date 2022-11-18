using notesAndLedgersApp.Shared;
using System.Net.Http.Json;

namespace notesAndLedgersApp.Client.Services
{
    public class CampaignService : ICampaignService
    {
        public Campaign CurrentCampaign { get; set; } = new Campaign();
        public List<Campaign> Campaigns { get; set; } = new List<Campaign>();

        private HttpClient _http;

        public CampaignService(HttpClient http)
        {
            _http = http;
        }

        public async Task GetCampaigns()
        {
            var result = await _http.GetFromJsonAsync<List<Campaign>>("/api/campaign");
            if(result != null)
                Campaigns = result;
        }

        public async Task GetCampaign(int id)
        {
            var result = await _http.GetFromJsonAsync<Campaign>($"/api/campaign/{id}");
            if (result != null)
                CurrentCampaign = result;
        }

        public async Task CreateCampaign(Campaign campaign)
        {
            var result = await _http.PostAsJsonAsync("api/campaign", campaign);
        }

        public async Task UpdateCampaign(Campaign campaign)
        {
            var result = await _http.PutAsJsonAsync("api/campaign", campaign);
        }

        public async Task DeleteCampaign(int id)
        {
            var result = await _http.DeleteAsync($"api/campaign/{id}");
        }
    }
}
