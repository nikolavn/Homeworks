using System;

public abstract class BankAccount
{
    private Customer customerType;
    private string customerName;
    protected decimal accountBalance;
    private decimal interestRate;

    public Customer CustomerType
    {
        get
        {
            return this.customerType;
        }
        set
        {
            this.customerType = value;
        }
    }

    public string CustomerName
    {
        get
        {
            return this.customerName;
        }
        set
        {
            this.customerName = value;
        }
    }

    public decimal AccountBalance
    {
        get
        {
            return this.accountBalance;
        }
        set
        {
            this.accountBalance = value;
        }
    }

    public decimal InterestRate
    {
        get
        {
            return this.interestRate;
        }
        set
        {
            this.interestRate = value;
        }
    }

    public BankAccount(Customer customerType, string customerName, decimal accountBalance, decimal interestRate)
    {
        this.customerType = customerType;
        this.customerName = customerName;
        this.accountBalance = accountBalance;
        this.interestRate = interestRate;
    }

    public abstract decimal Deposit(decimal amount);

    public virtual decimal CalculateInterest(int months)
    {
        if (months <= 0)
        {
            throw new ArgumentException("Months can not be less or equal to zero.");
        }
        else
        {
            return this.AccountBalance * this.InterestRate * months;
        }
    }

    public override string ToString()
    {
        return string.Format
            (
            "\nAccount Info"+
            "\n\nAccount holder: {0}"+
            "\nAccount type: {1} {2}"+
            "\nAccount Balance: {3}"+
            "\nInterest rate: {4}",
            this.CustomerName,this.CustomerType,this.GetType(),this.AccountBalance,this.InterestRate
            );
    }
}

