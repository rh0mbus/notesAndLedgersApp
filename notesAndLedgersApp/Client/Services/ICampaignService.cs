using notesAndLedgersApp.Shared;

namespace notesAndLedgersApp.Client.Services
{
    public interface ICampaignService
    {
        List<Campaign> Campaigns { get; set; }
        Task GetCampaigns();
        Task GetCampaign(int id);
        Task CreateCampaign(Campaign campaign);
        Task UpdateCampaign(Campaign campaign);
        Task DeleteCampaign(int id);
    }
}
