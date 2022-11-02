using notesAndLedgersApp.Shared;
using System.Net.Http.Json;

namespace notesAndLedgersApp.Client.Services
{
    public class CampaignService : ICampaignService
    {
        public List<Campaign> Campaigns { get; set; } = new List<Campaign>();

        private HttpClient _http;

        public CampaignService(HttpClient http)
        {
            Campaigns = new List<Campaign>();
            _http = http;
        }

        public Task CreateCampaign(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCampaign(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetCampaigns()
        {
            var result = await _http.GetFromJsonAsync<List<Campaign>>("/api/campaign");
            if(result != null)
                Campaigns = result;
        }

        public Task UpdateCampaign(int id)
        {
            throw new NotImplementedException();
        }
    }
}
