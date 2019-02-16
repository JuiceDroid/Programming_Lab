using NotesClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Controller
    {
        IDatabase database;
        MainWindow mainWindow;
        public Controller(MainWindow window)
        {
            database = new DatabaseMockup();
            mainWindow = window;
        }

        internal void AddNoteClicked(string title, string content)
        {
            database.AddNote(new Note(title, content));
            mainWindow.CreateNewNoteWindow(title, content);
        }
    }
}
