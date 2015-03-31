using System;

class MortgageAccount : BankAccount
{
    public MortgageAccount(Customer customer, string name, decimal balance, decimal interest)
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
        if (this.CustomerType == Customer.Company)
        {
            if (months <= 12)
            {
                return this.AccountBalance * (this.InterestRate / 2) * months; // Claculates half the rate for 1st 12 months
            }
            else
            {
                return (this.AccountBalance * (this.InterestRate / 2) * months)+  //Claculates half rate for first year plus normal interest rate 
                    base.CalculateInterest(months - 12);                          //for the rest of the period
            }
        }
        return base.CalculateInterest(months-6);
    }
}

