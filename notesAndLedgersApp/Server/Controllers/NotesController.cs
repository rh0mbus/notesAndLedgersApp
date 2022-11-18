using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using notesAndLedgersApp.Shared;

namespace notesAndLedgersApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {

        List<Note> notes = new List<Note> 
        { 
                new Note
                {
                    Content = "This is some test content for a note - Lorem ipsum dolor etc...",
                    Description = "A simple note",
                    Title = "Note title",
                    Id = 1,
                },
                new Note
                {
                    Content = "This is some test content for another note - Lorem ipsum dolor etc...",
                    Description = "Another simple note",
                    Title = "Another note title",
                    Id = 2,
                },
        };

        [HttpGet]
        public async Task<IActionResult> GetAllNotes()
        {
            return Ok(notes);
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateANote(Note newNote)
        //{
        //    return Ok("Note created");
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateNote(int id)
        //{
        //    return Ok($"Note {id} updated");
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteNote(int id)
        //{
        //    return Ok($"Note {id} deleted!");
        //}
    }
}
