using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleKeep.Models
{
    public class Handler
    {
        public KeepNote keepNote = null;
        public static List<KeepNote> keepNotes = new List<KeepNote>();

        public void AddNote(KeepNote keepNote)
        {
            keepNotes.Add(keepNote);
        }

        public KeepNote UpdateTitle(int id, string title)
        {
            foreach (KeepNote item in keepNotes)
            {
                if (id == item.NoteId)
                {
                    item.NoteTitle = title;
                    return item;
                }
            }
            return null;
        }

        public void DeleteNote(int id)
        {
            foreach (KeepNote item in keepNotes)
            {
                if (id == item.NoteId)
                    keepNotes.Remove(item);
            }
        }

        public KeepNote GetNote(int id)
        {
            foreach (KeepNote item in keepNotes)
            {
                if (id == item.NoteId)
                    return item;
            }
            return null;
        }
    }
}
