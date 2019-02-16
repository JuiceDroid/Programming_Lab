using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mockupdatabase just to show these could be save in some kind of database
namespace NotesClassLibrary
{
    public class DatabaseMockup : IDatabase
    {
        private static List<Note> notes;

        public DatabaseMockup()
        {
            notes = new List<Note>();
        }

        public void AddNote(Note note)
        {
            notes.Add(note);
        }

        public Note FetchNote(Guid id)
        {
            return notes.Find(note => note.Id.Equals(id));
        }

        public void RemoveNote(Guid id)
        {
            notes.RemoveAll(note => note.Id.Equals(id));
        }
    }
}
