using System;

class LoanAccount : BankAccount
{
    public LoanAccount(Customer customer, string name, decimal balance, decimal interest) 
        : base(customer, name, balance, interest) 
    {
 
    }

    public override decimal Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount should be positive.");
        }

        this.AccountBalance += amount;

        return this.AccountBalance;
    }

    public override decimal CalculateInterest(int months)
    {
        if (this.CustomerType == Customer.Individual)
        {
            return base.CalculateInterest(months-3);
        }
        return base.CalculateInterest(months-2);
    }
}

