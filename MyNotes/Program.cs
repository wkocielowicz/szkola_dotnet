using System.Globalization;
using System;

namespace MyNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MyNotes
            //// *** MAIN MENU LEVEL ***: - DONE!
            //// 1. Create new note (id, title, text, category, date of creation, date of modification) - DONE!
            //// 2. Search note - DONE!
            ////// *** SEARCH MENU LEVEL ***
            ////// 2a. by category - DONE!
            ////// 2b. by text - DONE!
            ////// 2c. by date of creation - DONE!
            ////// 2d. by date of modification - DONE!
            ////// 2e. show all notes - DONE!
            //////// *** SELECT NOTE MENU LEVEL ***
            //////// 2.1. Select note to show (select 1. 2. 3. .....) - DONE!
            ////////// *** NOTE MENU LEVEL ***
            ////////// 2.1.1. edit note - DONE!
            ////////// 2.1.2. delete note - DONE!
            ////////// 2.1.3. back to main menu - DONE!

            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            NoteService noteService = new NoteService();

            Console.WriteLine("Welcome to MyNotes app!");
            while (true)
            {
                var menu = actionService.GetMenuActionsByLevel("Main menu");
                Console.WriteLine("\n*** MAIN MENU ***");
                MenuActionService.ShowMenu(menu);

                int selectionOfMainMenu;
                Console.WriteLine("What do you want to do? Enter option number: 1, 2 or 3:");

                while (!(int.TryParse(Console.ReadLine(), out selectionOfMainMenu) & (selectionOfMainMenu == 1 || selectionOfMainMenu == 2 || selectionOfMainMenu == 3)))
                {
                    Console.WriteLine("Invalid input. Enter correct option.");
                    Console.WriteLine("What do you want to do? Enter option number: 1, 2 or 3:");
                }

                switch (selectionOfMainMenu)
                {
                    case 1:
                        Console.WriteLine("\n*** CREATOR OF NEW NOTE ***");
                        noteService.AddNewNote();
                        break;
                    case 2:
                        Console.WriteLine("\n*** SEARCH NOTE ***");
                        menu = actionService.GetMenuActionsByLevel("Search menu");
                        MenuActionService.ShowMenu(menu);

                        int selectionOfSearchMenu;
                        List<int> listOfOption = new List<int>() { 1, 2, 3, 4, 5 };
                        Console.WriteLine("What do you want to do? Enter option number: 1, 2, 3, 4 or 5:");
                        while (!(int.TryParse(Console.ReadLine(), out selectionOfSearchMenu) & listOfOption.Contains(selectionOfSearchMenu)))
                        {
                            Console.WriteLine("Invalid input. Enter correct option.");
                            Console.WriteLine("What do you want to do? Enter option number: 1, 2, 3, 4 or 5:");
                        }
                        switch (selectionOfSearchMenu)
                        {
                            case 1:
                                Console.WriteLine("\n*** SEARCH NOTE BY CATEGORY ***");
                                string category = null;
                                List<Note> notesByCategory = noteService.GetNotesByCategory(category);
                                while (notesByCategory.Count == 0)
                                {
                                    Console.WriteLine("Enter the name of category: ");
                                    category = Console.ReadLine();
                                    notesByCategory = noteService.GetNotesByCategory(category);
                                    if (notesByCategory.Count > 0)
                                    {
                                        NoteService.ShowNotes(notesByCategory);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No match!");
                                        break;
                                    }
                                }
                                if (notesByCategory.Count > 0)
                                {
                                    int selectedId = noteService.ShowSelectedNoteById(notesByCategory);

                                    Console.WriteLine("\n*** SELECTED NOTE MENU ***");
                                    menu = actionService.GetMenuActionsByLevel("Note menu");
                                    MenuActionService.ShowMenu(menu);
                                    int selectionOfNoteMenu = NoteMenu();
                                    switch (selectionOfNoteMenu)
                                    {
                                        case 1:
                                            noteService.EditTextOfNote(selectedId);
                                            break;
                                        case 2:
                                            noteService.DeleteNote(selectedId);
                                            break;
                                        case 3:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("\n*** SEARCH NOTE BY TEXT ***");
                                string? text = null;
                                List<Note> notesByText = new List<Note>();
                                while (notesByText.Count == 0)
                                {
                                    Console.WriteLine("Enter some text: ");
                                    text = Console.ReadLine();
                                    notesByText = noteService.GetNotesByText(text);
                                    if (notesByText.Count > 0)
                                    {
                                        NoteService.ShowNotes(notesByText);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No match!");
                                        break;
                                    }
                                }
                                if (notesByText.Count > 0)
                                {
                                    int selectedId = noteService.ShowSelectedNoteById(notesByText);
                                    Console.WriteLine("\n*** SELECTED NOTE MENU ***");
                                    menu = actionService.GetMenuActionsByLevel("Note menu");
                                    MenuActionService.ShowMenu(menu);
                                    int selectionOfNoteMenu = NoteMenu();
                                    switch (selectionOfNoteMenu)
                                    {
                                        case 1:
                                            noteService.EditTextOfNote(selectedId);
                                            break;
                                        case 2:
                                            noteService.DeleteNote(selectedId);
                                            break;
                                        case 3:
                                            break;
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("\n*** SEARCH NOTE BY DATE OF CREATION ***");
                                DateTime dateOfCreationBegin;
                                DateTime dateofCreationEnd;
                                List<Note> notesByDateOfCreation = new List<Note>();
                                while (notesByDateOfCreation.Count == 0)
                                {
                                    Console.WriteLine("Enter date of begin in format [M/d/yyyy], e.g. 2/23/2024:");
                                    while (!(DateTime.TryParseExact(Console.ReadLine(), "M'/'d'/'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfCreationBegin)))
                                    {
                                        Console.WriteLine("Invalid input! Enter date of begin in format [M/d/yyyy], e.g. 2/23/2024:");
                                    }

                                    Console.WriteLine("Enter date of end in format [M/d/yyyy], e.g. 2/24/2024:");
                                    while (!((DateTime.TryParseExact(Console.ReadLine(), "M'/'d'/'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateofCreationEnd)) & (dateofCreationEnd >= dateOfCreationBegin)))
                                    {
                                        Console.WriteLine("Invalid input! The data of end can't be eariel than data of begin. Enter date of end in format [M/d/yyyy], e.g. 2/24/2024:");
                                    }

                                    notesByDateOfCreation = noteService.GetNotesByDateOfCreation(dateOfCreationBegin, dateofCreationEnd.AddDays(1)); // We add 1 day, becasue we want to include the entire day
                                                                                                                                 // given until its full end. The date converted from
                                                                                                                                 // the console by default has 12:00 AM assumed.
                                    if (notesByDateOfCreation.Count > 0)
                                    {
                                        NoteService.ShowNotes(notesByDateOfCreation);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No match!");
                                        break;
                                    }
                                }
                                if (notesByDateOfCreation.Count > 0)
                                {
                                    int selectedId = noteService.ShowSelectedNoteById(notesByDateOfCreation);
                                    Console.WriteLine("\n*** SELECTED NOTE MENU ***");
                                    menu = actionService.GetMenuActionsByLevel("Note menu");
                                    MenuActionService.ShowMenu(menu);
                                    int selectionOfNoteMenu = NoteMenu();
                                    switch (selectionOfNoteMenu)
                                    {
                                        case 1:
                                            noteService.EditTextOfNote(selectedId);
                                            break;
                                        case 2:
                                            noteService.DeleteNote(selectedId);
                                            break;
                                        case 3:
                                            break;
                                    }
                                }
                                break;
                            case 4:
                                Console.WriteLine("\n*** SEARCH NOTE BY DATE OF MODIFICATION ***");
                                DateTime dateOfModificationBegin;
                                DateTime dateOfModificationEnd;
                                List<Note> notesByDateOfModification = new List<Note>();
                                while (notesByDateOfModification.Count == 0)
                                {
                                    Console.WriteLine("Enter date of begin in format [M/d/yyyy], e.g. 2/23/2024:");
                                    while (!(DateTime.TryParseExact(Console.ReadLine(), "M'/'d'/'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfModificationBegin)))
                                    {
                                        Console.WriteLine("Invalid input! Enter date of begin in format [M/d/yyyy], e.g. 2/23/2024:");
                                    }

                                    Console.WriteLine("Enter date of end in format [M/d/yyyy], e.g. 2/24/2024:");
                                    while (!((DateTime.TryParseExact(Console.ReadLine(), "M'/'d'/'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfModificationEnd)) & (dateOfModificationEnd >= dateOfModificationBegin)))
                                    {
                                        Console.WriteLine("Invalid input! The data of end can't be eariel than data of begin. Enter date of end in format [M/d/yyyy], e.g. 2/24/2024:");
                                    }

                                    notesByDateOfCreation = noteService.GetNotesByDateOfModification(dateOfModificationBegin, dateOfModificationEnd.AddDays(1)); // We add 1 day, becasue we want to include the entire day
                                                                                                                                 // given until its full end. The date converted from
                                                                                                                                 // the console by default has 12:00 AM assumed.
                                    if (notesByDateOfCreation.Count > 0)
                                    {
                                        NoteService.ShowNotes(notesByDateOfCreation);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No match!");
                                        break;
                                    }
                                }
                                if (notesByDateOfModification.Count > 0)
                                {
                                    int selectedId = noteService.ShowSelectedNoteById(notesByDateOfModification);
                                    Console.WriteLine("\n*** SELECTED NOTE MENU ***");
                                    menu = actionService.GetMenuActionsByLevel("Note menu");
                                    MenuActionService.ShowMenu(menu);
                                    int selectionOfNoteMenu = NoteMenu();
                                    switch (selectionOfNoteMenu)
                                    {
                                        case 1:
                                            noteService.EditTextOfNote(selectedId);
                                            break;
                                        case 2:
                                            noteService.DeleteNote(selectedId);
                                            break;
                                        case 3:
                                            break;
                                    }
                                }
                                break;
                            case 5:
                                NoteService.ShowNotes(noteService.Notes);
                                if (noteService.Notes.Count > 0)
                                {
                                    int selectedId = noteService.ShowSelectedNoteById(noteService.Notes);
                                    Console.WriteLine("\n*** SELECTED NOTE MENU ***");
                                    menu = actionService.GetMenuActionsByLevel("Note menu");
                                    MenuActionService.ShowMenu(menu);
                                    int selectionOfNoteMenu = NoteMenu();
                                    switch (selectionOfNoteMenu)
                                    {
                                        case 1:
                                            noteService.EditTextOfNote(selectedId);
                                            break;
                                        case 2:
                                            noteService.DeleteNote(selectedId);
                                            break;
                                        case 3:
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Your list of notes is empty.");
                                }
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Do you want to exit? y/n:");
                        string[] correctInput = { "y", "n" };
                        string? input;
                        while (!(correctInput.Contains(input = Console.ReadLine())))
                        {
                            Console.WriteLine("Invalid input! Enter correct answer (y/n)");
                        }
                        if (input == "y")
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }

        public static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Create new note", "Main menu");
            actionService.AddNewAction(2, "Search note", "Main menu");
            actionService.AddNewAction(3, "Quit", "Main menu");

            actionService.AddNewAction(1, "by category", "Search menu");
            actionService.AddNewAction(2, "by text", "Search menu");
            actionService.AddNewAction(3, "by date of creation", "Search menu");
            actionService.AddNewAction(4, "by date of modification", "Search menu");
            actionService.AddNewAction(5, "show list of all notes", "Search menu");

            actionService.AddNewAction(1, "Edit the text of this note", "Note menu");
            actionService.AddNewAction(2, "Delete this note", "Note menu");
            actionService.AddNewAction(3, "Back to main menu", "Note menu");

            return actionService;
        }

        public static int NoteMenu()
        {
            int selectionOfNoteMenu;
            List<int> listOfOption = new List<int>() { 1, 2, 3 };
            Console.WriteLine("What do you want to do? Enter option number: 1, 2 or 3:");
            while (!(int.TryParse(Console.ReadLine(), out selectionOfNoteMenu) & listOfOption.Contains(selectionOfNoteMenu)))
            {
                Console.WriteLine("Invalid input. Enter correct option.");
                Console.WriteLine("What do you want to do? Enter option number: 1, 2 or 3:");
            }
            return selectionOfNoteMenu;
        }
    }
}
