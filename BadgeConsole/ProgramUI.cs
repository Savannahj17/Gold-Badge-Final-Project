using BadgeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeConsole
{
    public class ProgramUI
    {
        private readonly BadgeRepo _badgeRepo = new BadgeRepo();

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
                Console.WriteLine("Hello Security Administration! Here's a list of options for you to manage badges and their access. \n" +
                    "What would you like to do? \n" +
                    "1. Add a badge \n" +
                    "2. Remove doors from a specific badge \n" +
                    "3. Update doors on existing badge \n" +
                    "4. Show a list of all badge numbers and the doors that they can access \n" +
                    "5. Exit");


                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateNewBadge();
                        break;
                    case "2":
                        UpdateDoorsOnBadge();
                        break;
                    case "3":
                        RemoveAllDoorsFromBadge();
                        break;
                    case "4":
                        ShowListOfAllBadgesAndAccess();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    //exit
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 5. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateNewBadge()
        {
            Badge badge = new Badge();
            Console.WriteLine("Time to add your badge to your collection. \n" +
                "Let's get started! \n" +
                "Please enter the badge Id of the badge you would like to add: ");
            badge.BadgeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the doors that this badge has access to: ");
            badge.DoorNames = Console.ReadLine(); //create empty list
                                                  //string - add a loop and then add door to list
            //once no, exit while loop
            //set list = door names
            Console.WriteLine("Please enter the name associated with this badge: ");
            string starRatingInput = Console.ReadLine();

        }

        private void ShowAllBadges()
        {
            Console.WriteLine("Badge Id: \t" +
                "Door Access: \t" + " ");
            
            Dictionary<int, List<string>> _badgeDictionary = _badgeRepo.GetAllBadges();
            foreach (KeyValuePair<int, List<string>> kvp in _badgeDictionary)
            {

                Console.WriteLine(kvp.Key,kvp.Value);
                Console.WriteLine("----------------------------------------------");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ShowBadgeById()
        {
            Console.Clear();
            Console.WriteLine("Enter a badge ID");
            int badgeId = int.Parse(Console.ReadLine());
            Badge foundId = __badges.getBadgeById(badgeId);
            if (badgeId != null)
            {
                DisplayContent(foundId);
            }
            else
            {
                Console.WriteLine("Invalid. Cound not find any results.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private bool RemoveAllDoorsFromBadge()
        {
            Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();
            Console.WriteLine("Please enter badge ID you wish to remove all doors from.");
            foreach (KeyValuePair<int, List<string>> kvp in _badgeDictionary)
            {
                if (badgeId == kvp.Key)
                {
                    return kvp.Value;
                }

            }
            int badgeId = int.Parse(Console.ReadLine());
            bool deleted = _badgeRepo.DeleteDoorsFromBadge(badgeId);
            if(deleted == null)
            {
                return true;
            }


            //call remove method
            //if true door have been remove
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();                                   //false - badge wasnt found
        }
        private void DisplayAllDoors(Badge badge)
        {

        }
        private void SeedContentList()
        {

        }


    }

}


//Update doors
//Do methods that i can
//If a feature doesnt work, just remove it