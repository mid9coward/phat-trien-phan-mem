using System;
using System.Collections.Generic;

// Enum to represent transaction type
enum TransactionType
{
    Deposit,
    Withdrawal
}

// Class to represent a bank customer
class Customer
{
    public string Name { get; private set; }
    public int CustomerId { get; private set; }

    public Customer(string name, int customerId)
    {
        Name = name;
        CustomerId = customerId;
    }
}

// Class to represent a bank account
class Account
{
    public int AccountNumber { get; private set; }
    public Customer Owner { get; private set; }
    public double Balance { get; private set; }
    private List<Transaction> transactions;

    public Account(int accountNumber, Customer owner)
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

// Class to represent a transaction
class Transaction
{
    public TransactionType Type { get; private set; }
    public double Amount { get; private set; }
    public DateTime Timestamp { get; private set; }

    public Transaction(TransactionType type, double amount)
    {
        Type = type;
        Amount = amount;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        string transactionType = Type == TransactionType.Deposit ? "Deposit" : "Withdrawal";
        return $"{Timestamp} - {transactionType} of ${Amount}";
    }
}

// Main class
class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("John Doe", 1001);
        Account account = new Account(123456, customer);

        Console.WriteLine($"Welcome, {customer.Name}!");
        Console.WriteLine($"Your account number is: {account.AccountNumber}");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. View Transaction History");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;
                case 3:
                    account.PrintTransactionHistory();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

     

