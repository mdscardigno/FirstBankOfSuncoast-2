using System;

namespace FirstBankOfSuncoast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to First Bank Of Suncoast.");
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
