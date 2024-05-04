using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes
{
    public class MenuActionService
    {
        private List<MenuAction> _menuActions;
        public MenuActionService() 
        {
            _menuActions = new List<MenuAction>();
        }
        public void AddNewAction (int id, string name, string level)
        {
            MenuAction action = new MenuAction();
            action.Id = id;
            action.Name = name;
            action.Level = level;
            _menuActions.Add(action);
        }

        public List<MenuAction> GetMenuActionsByLevel (string level)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (MenuAction action in _menuActions)
            {
                if (action.Level == level)
                {
                    result.Add(action);
                }
            }
            return result;
        }

        public static void ShowMenu(List <MenuAction> menuActions)
        {
            foreach (MenuAction action in menuActions)
            {
                Console.WriteLine($"{action.Id}. {action.Name}");
            }
        }
    }
}
