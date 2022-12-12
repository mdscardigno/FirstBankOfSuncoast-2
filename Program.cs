using System;

namespace FirstBankOfSuncoast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to First Bank Of Suncoast.");

            var userWantsToQuit = false;
            while (userWantsToQuit == false)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine();
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdraw");
                Console.WriteLine("Transfer");
                Console.WriteLine("Balance");
                Console.WriteLine("History");
                Console.WriteLine("Quit");

                var userChoice = PromptForString("What would you like to do?. Choice:  ").ToUpper().Trim();

                switch (userChoice)
                {
                    case "DEPOSIT":
                        Console.WriteLine("You chose to deposit.");
                        break;
                    case "WITHDRAW":
                        Console.WriteLine("You chose to withdraw.");
                        break;
                    case "TRANSFER":
                        Console.WriteLine("You chose to transfer.");
                        break;
                    case "BALANCE":
                        Console.WriteLine("You chose to check your balance.");
                        break;
                    case "HISTORY":
                        Console.WriteLine("You chose to check your history.");
                        break;
                    case "QUIT":
                        Console.WriteLine("You chose to quit.");
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
