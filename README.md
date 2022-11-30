# FirstBankOfSuncoast

## Problem

-Create a banking app that allows us to make and track withdrawals and deposits in two accounts, checking and savings.

- Keep track of the balance history by looking at all of the transactions that have been done.
  -The transaction will be saved in a file, using csv format to record the data.
  C R U D
  -Create: (Deposit/Withdraw) (create) a new transaction.
  -Read: Transaction History.
  -Update: Update Checking and Savings.
  -Delete: Removing funds from the account (Withdraw).

## EXAMPLES:

-If a suer deposit 10 to their savings, then withdraws 8 from their savings, then deposit 25, to their checking, they have three transactions to consider. Compute the checking and saving balance, using the transaction list, when needed.
-I go to the bank and check my balance for both my Savings and Checking accounts.
-I go to the bank and try to withdraw 30 but I only have 12 because I am broke. The bank does not process my transaction.
-I request a list of my transactions from my Savings and Checking accounts.
-My account cant never go negative.
-I go to the bank and deposit 10 into my checking account. Withdraw 5 from 20 in Savings and deposit 3 back into Checking. That is three transactions. i have 13 in checking left and 15 in savings left.
-Deposits 20 to checking, deposit 20 to savings, withdraw 12 from checking. 3 transactions, 8 in checking 20 in savings.
-Deposits 30 to savings, deposit 45 to checking, withdraw 40 from savings. The system does not allow me to overdraft.
So 2 transaction, 30 in savings and 45 in checking.

## |Type | Account | Amount|

| Deposit | Savings | 20 |
| Deposit | Savings | 2000 |
| Deposit | Checking| 3000 |
|Withdraw | Checking|42 |

## Data Structure

-Create a Class called Transaction

## Properties of Transaction Class

--Amount (int): (how much is in the transaction)
--Type (string): Deposit, Withdraw
--TimeStamp: (DateTime)
--Account: (string): Checking, Savings

-Add a List<Transactions>

## Algorithm

1. Welcome to the app.
2. Class Transaction - List of Transaction.
3. App should load past transactions from a file when it first starts (fileReader).
4. While the User has not chosen to 'quit' (bool keepGoing is false).
5. Display the Menu Options:
   Deposit
   Withdraw
   Balance
   Transaction History
   Quit
6. If (Deposit):
   ---Ask the user if they would like to choose Savings or Checking?
   ---Answer = Account
   ---Ask how much they want to input into savings?
   ---Answer = Amount
   Add as new instance of Transaction:
   ---Account
   ---Amount
   ---Type
   ---TimeStamp
   --Add Transaction
   Write all the transactions to the file (the four lines of code for the fileWriter).

7.If (Withdraw):
---Ask the user if they would like to choose Savings or Checking?
---If (Savings):
Filter out Savings:
----Filter out the Deposit and Sum the Total of the Deposit
----Filter out the Withdraw and Sum the Total of the Withdraw
----Difference = Deposit Amount - Withdraw Amount
Ask how much they want to withdraw from savings?
----If (difference < Asking amount>):
------Display message: "No funds available"
----If (difference > Asking Amount)
------Add new instance of Transaction:
------Account
------Amount
------Type
------TimeStamp
------Add Transaction
----Write all the transaction to the file (the four lines of code for the fileWriter)
---If (Checking):
Filter Out Checking
----Filter out the Deposit and Sum the Total of the Deposit
----Filter out the Withdraw and Sum the Total of the Withdraw
----Difference = Deposit Amount - Withdraw Amount
Ask how much they want to withdraw from checking?
----If (Difference < Asking Amount>)
------Add a new instance of Transaction:
------Account
------Amount
------Type
------TimeStamp
------Add Transaction
----Write all the transaction to the file (the four lines of code for the fileWriter)

8. If (Transaction History):
   --Ask the User if they would like to choose Savings or Checking?.
   --If(Savings):
   Filter out the Account by Savings
   Foreach (var saved in savings)
   Print out your transaction history for savings
   --If (Checking):
   Filter out the Account by Checking
   Foreach(var saved in checking)
   Print out all your transactions history for checking.

9. If(Balance):
   Ask the User if they would like to choose Savings or Checking?.
   If(Savings):
   Filter out Savings
   --Filter out the Deposit and Sum the Total of the Deposit
   --Filter out the Withdraw and Sum the Total of the Withdraw
   --Difference = Deposit Amount - Withdraw Amount
   Print out the Difference .
10. If(Quit):
    bool keepGoing = false

11. Say goodbye and come back again.
