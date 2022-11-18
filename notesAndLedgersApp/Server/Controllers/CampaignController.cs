using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using notesAndLedgersApp.Server.Data;
using notesAndLedgersApp.Shared;

namespace notesAndLedgersApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        List<Campaign> Campaigns = new List<Campaign>();
        private DataContext _context;

        public CampaignController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCampaigns()
        {
            Campaigns = _context.Campaigns.ToList();
            return Ok(Campaigns);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCampaign(Campaign campaign)
        {
            campaign.StartDate = DateTime.Now;
            campaign.Character = new Character();

            _context.Campaigns.Add(campaign);
            await _context.SaveChangesAsync();
            return Ok(campaign);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCampaign(Campaign campaign)
        {
            var campaignToUpdate = await _context.Campaigns.FirstOrDefaultAsync(c => c.Id == campaign.Id);
            if (campaignToUpdate == null)
                return NotFound($"No campaign found with id {campaign.Id}");

            return Ok("Campaign updated");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCampaign(int id)
        {
            var dbCampaign = await _context.Campaigns.FirstOrDefaultAsync(c => c.Id == id);

            if (dbCampaign == null) return NotFound($"Campaign with is: {id} not found!");
            _context.Campaigns.Remove(dbCampaign);

            await _context.SaveChangesAsync();

            return Ok($"Campaign deleted ID: {id}");
        }

    }
}
