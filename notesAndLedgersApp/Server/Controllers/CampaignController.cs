using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using notesAndLedgersApp.Shared;

namespace notesAndLedgersApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        List<Session> sessions = new List<Session> {
            new Session { Id = 0, SessionName = "Siege of Locust Valley", SessionDate = DateTime.Now, SessionComments = "Lots of combat!"  },
            new Session { Id = 1, SessionName = "A Night at the Inn", SessionDate = DateTime.Now, SessionComments = "Lots of combat!" },
        };

        [HttpGet]
        public async Task<IActionResult> GetSessions()
        {
            return Ok(sessions);
        }

    }
}
