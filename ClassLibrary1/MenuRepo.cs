using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MenuRepo
    {
        protected readonly List<MenuItem> _menu = new List<MenuItem>();
        public bool AddItemToMenu(MenuItem item)
        {
            int startingCount = _menu.Count;
            _menu.Add(item);
            bool wasAdded = _menu.Count > startingCount ? true : false;
            return wasAdded;
            
        }
       
        public List<MenuItem> GetAllItems()
        {
            return _menu;
        }
      
        public MenuItem GetItemByName(string mealName)
        {
            foreach(MenuItem item in _menu)
            {
                if (item.MealName == mealName)
                {
                    return item;
                }
            }
            return null;
        }
      
        public bool DeleteExistingItem(MenuItem existingItem)
        {
            bool deleteResult = _menu.Remove(existingItem);
            return deleteResult;
        }
    }
}
