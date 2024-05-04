using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes
{
    public class NoteService
    {
        public List<Note> Notes { get; set; }
        int idCounter = 1;
        public NoteService()
        {
            Notes = new List<Note>();
        }
        public void AddNewNote()
        {
            Note note = new Note();
            note.Id = idCounter++;
            Console.WriteLine("Enter the title of note:");
            note.Title = Console.ReadLine();
            Console.WriteLine("Enter the text of the note:");
            note.Text = Console.ReadLine();
            Console.WriteLine("Enter the category of the note:");
            note.Category = Console.ReadLine();
            note.CreatedDateTime = DateTime.Now;
            note.ModifiedDateTime = DateTime.Now;
            Notes.Add(note);
            Console.WriteLine("Done!");
        }

        public void EditTextOfNote(int id)
        {
            foreach (Note note in Notes)
            {
                if (note.Id == id)
                {
                    Console.WriteLine("Enter the new text of the note:");
                    note.Text = Console.ReadLine();
                    note.ModifiedDateTime = DateTime.Now;
                    Console.WriteLine("Done!");
                }
            }  
        }

        public int ShowSelectedNoteById(List<Note> searchedNotes)
        {
            Console.WriteLine("Which note do you want to see? Enter selected number id:");
            int selectedNumberId = 0;
            List<int> listOfId = new List<int>();
            listOfId = GetIdOfNotes(searchedNotes);

            while (!(int.TryParse(Console.ReadLine(), out selectedNumberId) & listOfId.Contains(selectedNumberId)))
            {
                Console.WriteLine("Invalid input. Enter number id to show selected note:");
            }
            foreach (Note note in Notes)
            {
                if (note.Id == selectedNumberId)
                {
                    Console.WriteLine();
                    Console.WriteLine("OK, this is selected note:");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"{note.Id}. {note.Title}");
                    Console.WriteLine($"{note.Text}");
                    Console.WriteLine($"Date of creation: {note.CreatedDateTime}, Date of last modification: {note.ModifiedDateTime}");
                    Console.WriteLine("------------------------------------------------------");
                    return selectedNumberId;
                }
            }
            Console.WriteLine();
            return 0;
        }

        public List<Note> GetNotesByCategory(string category)
        {
            List<Note> result = new List<Note>();
            foreach (Note note in Notes)
            {
                if (note.Category == category)
                {
                    result.Add(note);
                }
            }
            return result;
        }

        public List<Note> GetNotesByText(string text)
        {
            if (text == null)
            {
                return null;
            }
            else
            {
                List<Note> result = new List<Note>();
                foreach (Note note in Notes)
                {
                    if (note.Text.Contains(text))
                    {
                        result.Add(note);
                    }
                }
                return result;
            }
        }

        public List<Note> GetNotesByDateOfCreation(DateTime dateTimeBegin, DateTime dateTimeEnd)
        {
            List<Note> result = new List<Note>();
            foreach (Note note in Notes)
            {
                if (note.CreatedDateTime >= dateTimeBegin & note.CreatedDateTime <= dateTimeEnd)
                {
                    result.Add(note);
                }
            }
            return result;
        }

        public List<Note> GetNotesByDateOfModification(DateTime dateTimeBegin, DateTime dateTimeEnd)
        {
            List<Note> result = new List<Note>();
            foreach (Note note in Notes)
            {
                if (note.ModifiedDateTime >= dateTimeBegin & note.ModifiedDateTime <= dateTimeEnd)
                {
                    result.Add(note);
                }
            }
            return result;
        }

        public static void ShowNotes(List<Note> notes)
        {
            Console.WriteLine();
            Console.WriteLine("OK, this is list of selected notes:");
            Console.WriteLine("------------------------------------------------------");
            foreach (Note note in notes)
            {
                Console.WriteLine($"{note.Id}. {note.Title}, Last modified: {note.ModifiedDateTime}");
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
        }

        public void DeleteNote(int id)
        {
            for (int i = 0; i < Notes.Count; i++)
            {
                if (Notes[i].Id == id)
                {
                    Notes.Remove(Notes[i]);
                    break;
                }
            }
            Console.WriteLine("Done!");
        }

        public static List<int> GetIdOfNotes(List<Note> notes)
        {
            List <int> idOfNotes = new List<int>();
            foreach (Note note in notes)
            {
                idOfNotes.Add(note.Id);
            }
            return idOfNotes;
        }
    }
}
