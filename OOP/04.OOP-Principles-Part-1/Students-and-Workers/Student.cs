using System;
using System.Collections.Generic;

public class Student : Human
{
    private double grade = 0;

    public Student(string firstName, string lastName, double grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }

    public double Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            if (value < 2)
            {
                throw new ArgumentException("Grade should be greater than 2.");
            }
            this.grade = value;
        }
    }

    public override string ToString()
    {
        return string.Format
            (
            "Name: {0} {1}, Grade: {2}",
            this.FirstName, this.LastName, this.Grade
            );
    }
}

