using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleKeep.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoogleKeep.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Handler handler = new Handler();
        // GET api/values
        [HttpGet]
        public KeepNote Get(int id)
        {
            return handler.GetNote(id);
        }

        [HttpPost]
        public void Post([FromBody] KeepNote keepNote)
        {
            handler.AddNote(keepNote);
        }

        // PUT api/values/5
        [HttpPut]
        public KeepNote Put(int id, string title)
        {
           KeepNote keepNote= handler.UpdateTitle(id,title);
            return keepNote;
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
            handler.DeleteNote(id);
        }
    }
}
