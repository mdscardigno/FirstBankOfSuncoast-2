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
                Console.WriteLine("Quit");
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
