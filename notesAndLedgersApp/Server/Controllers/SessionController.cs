using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using notesAndLedgersApp.Server.Data;
using notesAndLedgersApp.Shared;

namespace notesAndLedgersApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private DataContext _context;

        private List<Session> Sessions = new List<Session>();

        public SessionController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetSessions()
        {
            Sessions = _context.Sessions.ToList();
            return Ok(Sessions);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSession(Session session)
        {
            session.SessionDate = DateTime.Now;
            session.SessionNotes = new List<Note> { new Note() };
            session.Transactions = new List<Transaction> { new Transaction() };

            _context.Sessions.Add(session);
            await _context.SaveChangesAsync();

            return Ok("hi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSession(Session session)
        {
            var dbSession = _context.Sessions.FirstOrDefault(s => s.Id == session.Id);
            if (dbSession == null) return NotFound($"No session found with Id: {session.Id}");
            dbSession.SessionNotes = session.SessionNotes;
            dbSession.Transactions = session.Transactions;

            return Ok(await GetSessions());
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSession(Session session)
        {
            var dbSession = await _context.Sessions.FirstOrDefaultAsync(s => s.Id == session.Id);
            if (dbSession == null) return NotFound($"Session with ID: {session.Id} was not found!");

            return Ok(await GetSessions());
        }
    }
}
