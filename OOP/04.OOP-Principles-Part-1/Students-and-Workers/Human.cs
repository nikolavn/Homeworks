using System;

public abstract class Human
{
    private string firstName = null;
    private string lastName = null;

    public Human(string firstName,string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }
}

