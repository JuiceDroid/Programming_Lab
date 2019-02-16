using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesClassLibrary
{
    public interface IDatabase
    {
        void AddNote(Note note);
        void RemoveNote(Guid id);
        Note FetchNote(Guid id);
    }
}
