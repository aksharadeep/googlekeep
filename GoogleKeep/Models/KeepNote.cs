using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleKeep.Models
{
    public class KeepNote
    {

       public int NoteId { get; set; }
       public string NoteTitle { get; set; }


        public KeepNote(int noteId, string noteTitle)
        {
            this.NoteId = noteId;
            this.NoteTitle = noteTitle;
        }

    }
}
