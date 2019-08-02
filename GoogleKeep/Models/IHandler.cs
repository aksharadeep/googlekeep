using System.Collections.Generic;

namespace GoogleKeep.Models
{
    public interface IHandler
    {
       KeepNote GetNoteById(int id);
       List<KeepNote> GetNotes();
       bool AddNote(KeepNote keepNote);
       KeepNote UpdateNote(int id, KeepNote keepNote);
       bool DeleteNote(int id);
    }
}
