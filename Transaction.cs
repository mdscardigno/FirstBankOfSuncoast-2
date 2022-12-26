using System;

namespace FirstBankOfSuncoast
{
    public class Transaction
    {
        // Behavior
        //
        // Name:     Description
        // Input:    nothing? (we have everything as properties)
        // Output:   string (containing the description)
        // Work:     Combine the properties into a description string
        // Access:   Does the outside world need to access this? true
        //           We want our PROGRAM to be able to call for a Transaction Description

        //-Properties
        //--Amount (int) The amount of the transaction
        public int Amount { get; set; }
        //--Type (string) The type of transaction (deposit, withdraw, transfer)
        public string Type { get; set; }
        //--TimeStamp (DateTime) The time the transaction was created
        public DateTime TimeStamp { get; set; }
        //--Account (string) Checking, Savings
        public string Account { get; set; }

        public string Description()
        {
            return Bannerized($"{Type} of {Amount} on {TimeStamp} for {Account}");

        }
        private string Bannerized(string message)
        {
            var output = "";
            output += "******************************\n";
            output += message + "\n";
            output += "******************************\n";
            return output;
        }
    }
}