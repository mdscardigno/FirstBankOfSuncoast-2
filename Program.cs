using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstBankOfSuncoast
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to First Bank Of Suncoast.");

            // var transaction = new List<Transaction>();
            //making test transactions
            var transactions = new List<Transaction>()
            {
                //scaffolding for data / seeded data / test data/ fake data / hardcoded data / static data
                //data example:
                //|Type   |  |Account |  |Amount  |
                //---------------------------------
                //|Deposit|  |Savings |  |2500    |
                new Transaction{Type = "Deposit", Amount = 2500, Account = "Savings", TimeStamp = DateTime.Now},
                //|Deposit|  |Savings |  |2000    |
                new Transaction{Type = "Deposit", Amount = 2000, Account = "Savings", TimeStamp = DateTime.Now},
                //|Deposit|  |Checking|  |3000    |
                new Transaction{Type = "Deposit", Amount = 3000, Account = "Checking", TimeStamp = DateTime.Now},
                //|Withdraw|  |Checking|  |1000    |
                new Transaction{Type = "Withdraw", Amount = 1000, Account = "Checking", TimeStamp = DateTime.Now},
                //---------------------------------
            };
            Console.WriteLine("Here is your transaction history:");
            Console.WriteLine();
            Console.WriteLine("Type\tAccount\tAmount\tTimeStamp");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var item in transactions)
            {

                Console.WriteLine($"{item.Type}\t{item.Account}\t{item.Amount}\t{item.TimeStamp}");

            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"You have a total of: {transactions.Count} transactions.");

            var userWantsToQuit = false;
            while (userWantsToQuit == false)
            {
                Console.WriteLine("Please make a selection from the Menu Options bellow: ");
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
                        // Console.WriteLine("You chose to withdraw.");
                        //Filter out Savings or Checking
                        var accountWithdrawChoice = PromptForString("Would you like to withdraw from your Savings or Checking balance?: ");
                        //show the max amount they can withdraw
                        var withdrawMax = ComputeBalance(transactions, accountWithdrawChoice);
                        //ask how much they want to withdraw from savings
                        var withdrawAmount = PromptForInteger($"How much would you like to withdraw from your {accountWithdrawChoice} Account? -- up to {withdrawMax}: ");

                        //if(difference < asking amount)
                        // if (withdrawMax < withdrawAmount)
                        if (withdrawAmount > withdrawMax)
                        {
                            //--Say: "No enough funds"
                            Console.WriteLine("Sorry. No funds available.");
                        }

                        //if(difference > asking amount)
                        else
                        {
                            //--add a new instance of Transaction:
                            var newTransaction = new Transaction()
                            {
                                //--Account
                                Account = accountWithdrawChoice,
                                //--Amount
                                Amount = withdrawAmount,
                                //--Type
                                Type = "Withdraw",
                                //--TimeStamp
                                TimeStamp = DateTime.Now,
                            };
                            //--add transaction
                            transactions.Add(newTransaction);
                        }

                        //--write all the transactions to the file (the four lines of code for fileWriter)

                        break;
                    case "T":
                        // Console.WriteLine("You chose to transfer.");
                        //Filter out Savings or Checking
                        var accountTransferChoice = PromptForString("Would you like to transfer from your Savings or Checking balance?: ");
                        //show the max amount they can transfer
                        var transferMax = ComputeBalance(transactions, accountTransferChoice);
                        //ask how much they want to transfer from savings
                        var transferAmount = PromptForInteger($"How much would you like to transfer from your {accountTransferChoice} Account? -- up to {transferMax}: ");

                        //if(difference < asking amount)
                        // if (transferMax < transferAmount)
                        if (transferAmount > transferMax)
                        {
                            //--Say: "No enough funds"
                            Console.WriteLine("Sorry. No funds available.");
                        }

                        //if(difference > asking amount)
                        else
                        {
                            //--add a new instance of Transaction:
                            var newTransaction = new Transaction()
                            {
                                //--Account
                                Account = accountTransferChoice,
                                //--Amount
                                Amount = transferAmount,
                                //--Type
                                Type = "Transfer",
                                //--TimeStamp
                                TimeStamp = DateTime.Now,
                            };
                            //--add transaction
                            transactions.Add(newTransaction);
                        }

                        //--write all the transactions to the file (the four lines of code for fileWriter)

                        break;
                    case "B":
                        // Console.WriteLine("You chose to check your balance.");
                        var accountBalanceChoice = PromptForString("Would you like to see your Savings or Checking balance?: ");
                        //Filter out the account Type
                        // var balanceFilteredTransactions = transactions.Where(transaction => transaction.Account == accountBalanceChoice);
                        // //subtract the total of the withdraw from the total of the deposit
                        // // var totalBalance = depositBalanceTransactions.Sum(transaction => transaction.Amount) -
                        // //                    withdrawBalanceTransactions.Sum(transaction => transaction.Amount);
                        // var totalBalance = balanceFilteredTransactions.Where(transaction => transaction.Type == "Deposit").Sum(transaction => transaction.Amount) -
                        //                    balanceFilteredTransactions.Where(transaction => transaction.Type == "Withdraw").Sum(transaction => transaction.Amount);

                        var totalBalance = ComputeBalance(transactions, accountBalanceChoice);

                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine($"Your {accountBalanceChoice} Account Balance is: {totalBalance}");
                        Console.WriteLine("------------------------------------------------------------");
                        break;
                    case "H":  //left off here and video 0:30:40
                        Console.WriteLine("You chose to check your history.");
                        //Ask the user if they would like to choose Savings or Checking?
                        var accountHistoryChoice = PromptForString("Would you like to see your Savings or Checking history?: ");
                        //Filter out the account
                        //-- Filter out by giving a small list of transactions that match the account
                        var filteredTransactions = transactions.Where(transaction => transaction.Account == accountHistoryChoice);
                        Console.WriteLine();
                        //Foreach (var transaction in transactions)
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine($"Here is your Transaction History for your {accountHistoryChoice} Account: ");
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------");
                        foreach (var transaction in filteredTransactions)
                        {
                            //Print out the transaction history for savings
                            // Console.WriteLine($"{transaction.Type}\t{transaction.Account}\t{transaction.Amount}\t{transaction.TimeStamp}");
                            Console.WriteLine($"{transaction.Amount} - {transaction.Type}");
                            Console.WriteLine("------------------------------------------------------------");
                        }
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

        //Make a method to compute the balance
        //
        //
        //name: ComputeBalance
        //input: List of transactions -- choice of account we are interested in (Savings or Checking)
        //work to do: (those lines of LINQ code above)
        //output: int balance

        static public int ComputeBalance(List<Transaction> transactionForBalancing, string accountTypeToBalance)
        {
            var balanceFilteredTransactions = transactionForBalancing.Where(transaction => transaction.Account == accountTypeToBalance);
            //subtract the total of the withdraw from the total of the deposit
            // var totalBalance = depositBalanceTransactions.Sum(transaction => transaction.Amount) -
            //                    withdrawBalanceTransactions.Sum(transaction => transaction.Amount);
            var balance = balanceFilteredTransactions.Where(transaction => transaction.Type == "Deposit").Sum(transaction => transaction.Amount) -
                               balanceFilteredTransactions.Where(transaction => transaction.Type == "Withdraw").Sum(transaction => transaction.Amount);
            return balance;
        }
    }
}
