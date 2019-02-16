using NotesClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notes
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;

        public MainWindow()
        {
            InitializeComponent();
            controller  = new Controller(this);
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            controller.AddNoteClicked(TitleTextBox.Text, ContentTextBox.Text);
        }

        public void CreateNewNoteWindow(string title, string noteContent)
        {
            var noteWindow = new NoteWindow { Owner = this };
            noteWindow.NoteContentTextBox.Text = noteContent;
            noteWindow.Title = title;
            noteWindow.Show();
        }

    }
    
}
