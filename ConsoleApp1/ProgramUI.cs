using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProgramUI
    {

        private readonly MenuRepo _menuRepo = new MenuRepo();


        public void Run()
        {
            SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to your application! \n" +
               "Here is where you can manage the Cafe Menu \n" +
               "1. Add an item to the menu list \n" +
               "2. Delete an item from the menu list \n" +
               "3. See all items on the menu list \n" +
               "4. Exit \n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddItemToMenu();
                        break;
                    case "2":
                        DeleteItemFromMenu();
                        break;
                    case "3":
                        ShowAllItemsOnMenu();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 4. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void AddItemToMenu()
        {
            MenuItem item = new MenuItem();
            Console.WriteLine("Please enter a meal number:");
            item.MealNumber =  int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a meal name:");
            item.MealName = Console.ReadLine();
            Console.WriteLine("Please enter a meal description:");
            item.Description =Console.ReadLine();
            Console.WriteLine("Please enter the ingredients of the meal, for example: eggs, milk, etc. ");
            item.Ingredients = Console.ReadLine();
            Console.WriteLine("Please enter a meal price: ");
            item.Price = double.Parse(Console.ReadLine());
            _menuRepo.AddItemToMenu(item);
            Console.WriteLine("Your new item has now been added to the menu. Would you like to add another one? Please enter yes or no.");
            string answer = Console.ReadLine().ToLower();
            Console.Clear();
            if(answer == "yes")
            {
                AddItemToMenu();
            }
            else
            {
                Console.WriteLine("Press enter to return to the main menu");
                Console.ReadLine();
                Console.Clear();
                RunMenu();
            }
        }
        private void DeleteItemFromMenu()
        {
            MenuItem item = new MenuItem();
            Console.WriteLine("Please enter the name of the item that you would like to delete");
            Console.ReadLine();
            _menuRepo.DeleteExistingItem(item);
            Console.WriteLine("Would you like to delete another item from the menu?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                DeleteItemFromMenu();
            }
            else
            {
                Console.WriteLine("Press enter to return to the main menu");
                Console.ReadLine();
                Console.Clear();
                RunMenu();
            }
        }
        private void ShowAllItemsOnMenu()
        {
            _menuRepo.GetAllItems();

        }
            
        private void SeedContentList()
        {
                 
        }
        
    }
}
