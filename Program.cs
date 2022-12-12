using System;
using System.Collections.Generic;

namespace FirstBankOfSuncoast
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to First Bank Of Suncoast.");

            // var transaction = new List<Transaction>();
            //making test transactions
            var transaction = new List<Transaction>()
            {
                //data example:
                //|Type   |  |Account |  |Amount  |
                //---------------------------------
                //|Deposit|  |Savings |  |2500    |
                //|Deposit|  |Savings |  |2000    |
                //|Deposit|  |Checking|  |3000    |
                //|Deposit|  |Checking|  |3000    |
                //---------------------------------
                new Transaction{...},
                new Transaction{...},
                new Transaction{...},
                new Transaction{...},

            };




            var userWantsToQuit = false;
            while (userWantsToQuit == false)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine();
                Console.WriteLine("(D)eposit");
                Console.WriteLine("(W)ithdraw");
                Console.WriteLine("(T)ransfer");
                Console.WriteLine("(B)alance");
                Console.WriteLine("(H)istory");
                Console.WriteLine("(Q)uit");

                var userChoice = PromptForString("What would you like to do?. Choice:  ").ToUpper().Trim();

                switch (userChoice)
                {
                    case "D":
                        Console.WriteLine("You chose to deposit.");
                        break;
                    case "W":
                        Console.WriteLine("You chose to withdraw.");
                        break;
                    case "T":
                        Console.WriteLine("You chose to transfer.");
                        break;
                    case "B":
                        Console.WriteLine("You chose to check your balance.");
                        break;
                    case "H":
                        Console.WriteLine("You chose to check your history.");
                        break;
                    case "Q":
                        Console.WriteLine("You chose to quit. Have a great day!. Come back and see us soon!");
                        userWantsToQuit = true;
                        break;
                    default:
                        Console.WriteLine("That is not a valid choice.");
                        break;
                }

            }
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            var userInput = PromptForString(prompt);
            var userInputAsInteger = int.Parse(userInput);
            return userInputAsInteger;
        }
    }
}
