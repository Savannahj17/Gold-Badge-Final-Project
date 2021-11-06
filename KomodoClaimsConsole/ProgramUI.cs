using KomodoClaimsClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsConsole
{
    class ProgramUI
    {
        ClaimsRepo _claimsRepo = new ClaimsRepo();

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
               "Here is where you can manage the claims queue \n" +
               "1. See all claims \n" +
               "2. Take care of the next claim \n" +
               "3. Enter a new claim \n" +
               "4. Exit \n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfClaim();
                        break;
                    case "3":
                        EnterNewClaim();
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

        public void SeeAllClaims()
        {
            Queue<Claims> queue = new Queue<Claims>();
            foreach (Claims claim in queue)
            {
                _claimsRepo.GetClaimById(claim.ClaimId);
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public void TakeCareOfClaim()
        {

        }
        public void EnterNewClaim()
        {
            Claims claim = new Claims();
            Console.WriteLine("Please enter a claim ID:");
            claim.ClaimId = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a claim description:");
            claim.Description = Console.ReadLine();
            Console.WriteLine("Please enter a claim amount ");
            claim.ClaimAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the date of the incident in an 8 digit format, for example: 11032021 for November 3, 2021.");
            claim.DateOfIncident = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the date of the claim in an 8 digit format, for example: 11032021 for November 3, 2021.");
            Console.ReadKey();
            Console.WriteLine("Please enter a validity statment regarding the claim.");
            claim.IsValid = bool.Parse(Console.ReadLine());
            _claimsRepo.AddClaimToQueue(claim);
            Console.WriteLine("Your new item has now been added to the menu. Return to main menu");
            string answer = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Press enter to return to the main menu");
            Console.ReadLine();
            Console.Clear();
            RunMenu();


        }
        private void SeedContentList()
        {
            Claims claimOne = new Claims(123, ClaimType.Car, "Car Accident", 4000, 10212020, 10222020, true);
            Claims claimTwo = new Claims(896, ClaimType.Theft, "Home Invasion", 5000, 11152021, 11152021, false);

            _claimsRepo.AddClaimToQueue(claimOne);
            _claimsRepo.AddClaimToQueue(claimTwo);
        }
    }
}
