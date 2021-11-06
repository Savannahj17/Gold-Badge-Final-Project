using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MenuItem
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public MenuItem()
        {

        }
        public MenuItem(int mealNumber, string mealName, string description, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Price = price;
        }
    }
}
