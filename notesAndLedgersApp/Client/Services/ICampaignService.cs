using notesAndLedgersApp.Shared;

namespace notesAndLedgersApp.Client.Services
{
    public interface ICampaignService
    {
        List<Campaign> Campaigns { get; set; }
        Task GetCampaigns();
        Task CreateCampaign(Campaign campaign);
        Task UpdateCampaign(int id);
        Task DeleteCampaign(int id);
    }
}
