using System;

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

