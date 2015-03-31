//Problem 2. Bank accounts
//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
using System;
using System.Collections.Generic;

class BankTests
{
    static void Main()
    {
        BankAccount testAccount0 = new DepositAccount(Customer.Individual, "pesho", 298012, 23);
        BankAccount testAccount1 = new DepositAccount(Customer.Individual, "poor pesho", 823, 123.123m);
        BankAccount testAccount2 = new DepositAccount(Customer.Company, "pesho Co.", 1234.123m, 233.1m);

        BankAccount testAccount3 = new DepositAccount(Customer.Individual, "gosho", 128937.123m, 7.34m);
        BankAccount testAccount4 = new DepositAccount(Customer.Company, "gosho Co.", 1542352381.123m, 283.67m);

        BankAccount testAccount5 = new DepositAccount(Customer.Individual, "stamat", 23613, 2.3m);
        BankAccount testAccount6 = new DepositAccount(Customer.Company, "Stamat Co.", 5473137, 8347.123m);

        List<BankAccount> accounts = new List<BankAccount>();
        accounts.Add(testAccount0);
        accounts.Add(testAccount1);
        accounts.Add(testAccount2);
        accounts.Add(testAccount3);
        accounts.Add(testAccount4);
        accounts.Add(testAccount5);
        accounts.Add(testAccount6);
        int period1 = 10, period2 = 32;

        foreach (var account in accounts)
        {
            Console.WriteLine("Interest for {0} months: {1}", period1, account.CalculateInterest(period1));
            Console.WriteLine("Interest for {0} months: {1}", period2, account.CalculateInterest(period2));
        }
    }
}

