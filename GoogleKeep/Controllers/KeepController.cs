using GoogleKeep.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoogleKeep.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class KeepController : ControllerBase
    {
        private readonly IHandler handler;
        public KeepController(IHandler KeepHandler)
        {
            handler = KeepHandler;
        }
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(handler.GetNotes());
        }

        [HttpGet("{noteId}")]
        public ActionResult Get(int noteId)
        {
            var note = handler.GetNoteById(noteId);
            if (note == null)
            {
                return NotFound("No Notes exists with that id to display");
            }
            else
            {
                return Ok(note);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] KeepNote note)
        {
            bool result = handler.AddNote(note);
            return Created("/api/KeepNote", result);
        }

        // PUT api/values
        [HttpPut("{noteId}")]
        public IActionResult Put(int noteId, [FromBody] KeepNote note)
        {
            var result = handler.UpdateNote(noteId, note);
            if (result == null)
            {
                return NotFound("No notes exists with that id to update");
            }
            return Ok(result);
        }

        // DELETE api/values/5
       
        [HttpDelete("{noteId}")]
        public IActionResult Delete(int noteId)
        {
            bool result = handler.DeleteNote(noteId);
            if (result)
            {
                return Ok();
            }
            return NotFound("No notes exists with that id to delete");
        }
    }
}
