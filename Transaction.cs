using System;

namespace FirstBankOfSuncoast
{
    public class Transaction
    {
        //-Properties
        //--Amount (int) The amount of the transaction
        public int Amount { get; set; }
        //--Type (string) The type of transaction (deposit, withdraw, transfer)
        public string Type { get; set; }
        //--TimeStamp (DateTime) The time the transaction was created
        public DateTime TimeStamp { get; set; }
        //--Account (string) Checking, Savings
        public string Account { get; set; }

    }
}