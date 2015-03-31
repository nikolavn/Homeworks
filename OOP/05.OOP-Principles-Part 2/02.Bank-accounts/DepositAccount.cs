using System;

class DepositAccount : BankAccount,IWithdrawable
{
    public DepositAccount(Customer customer, string name, decimal balance, decimal interest)
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

    public decimal Withdraw(decimal amount)
    {
        this.accountBalance -= amount;

        return this.AccountBalance;
    }

    public override decimal CalculateInterest(int months)
    {
        if (this.AccountBalance < 1000)
        {
            Console.WriteLine("Account balance: {0}. No interest on accounts with less than 1000.",this.AccountBalance);
        }
        return base.CalculateInterest(months);
    }
}

