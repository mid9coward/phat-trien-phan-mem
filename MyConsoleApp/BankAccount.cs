using System;
using System.Collections.Generic;

// Enum to represent transaction type
enum TransactionType
{
    Deposit,
    Withdrawal
}

// Class to represent a bank account and its transactions
class BankAccount
{
    public int AccountNumber { get; private set; }
    public Customer Owner { get; private set; }
    public double Balance { get; private set; }
    private List<Transaction> transactions;

    public BankAccount(int accountNumber, Customer owner)
    {
        AccountNumber = accountNumber;
        Owner = owner;
        Balance = 0;
        transactions = new List<Transaction>();
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        transactions.Add(new Transaction(TransactionType.Deposit, amount));
        Console.WriteLine($"${amount} deposited successfully.");
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            transactions.Add(new Transaction(TransactionType.Withdrawal, amount));
            Console.WriteLine($"${amount} withdrawn successfully.");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void PrintTransactionHistory()
    {
        Console.WriteLine($"Transaction history for Account {AccountNumber}:");
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}
