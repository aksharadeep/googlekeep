using System.Collections.Generic;
using System.Linq;

namespace GoogleKeep.Models
{
    public class Handler : IHandler
    {

        List<KeepNote> notes = new List<KeepNote>();

        public bool AddNote(KeepNote keepNote)
        {
            notes.Add(keepNote);
            return true;
        }

        public bool DeleteNote(int noteId)
        {
            KeepNote note = notes.FirstOrDefault(n => n.NoteId == noteId);
            if (note != null)
            {
                notes.Remove(note);
                return true;
            }
            return false;
        }

        public KeepNote GetNoteById(int noteId)
        {
            KeepNote note = notes.FirstOrDefault(n => n.NoteId == noteId);
            return note;
        }

        public List<KeepNote> GetNotes()
        {
            return notes;
        }

        public KeepNote UpdateNote(int noteId, KeepNote keepNote)
        {
            KeepNote _note = notes.FirstOrDefault(n => n.NoteId == noteId);
            if (_note != null)
            {
                _note.NoteTitle = keepNote.NoteTitle;
                _note.NoteDescription = keepNote.NoteDescription;
            }
            return _note;
        }
    }
}
