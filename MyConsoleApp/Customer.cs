using System;

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
