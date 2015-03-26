using System;

public class Worker : Human
{
    private double weekSalary = 0.0;
    private double workHoursPerDay = 0.0;

    public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public double WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Work hours can't be negative.");
            }
            this.workHoursPerDay = value;
        }
    }

    public double WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Week salary can't be negative.");
            }
            this.weekSalary = value;
        }
    }

    public double MoneyPerHour()
    {
        return this.WeekSalary / this.WorkHoursPerDay;
    }

    public override string ToString()
    {
        return string.Format
            (
            "Name: {0} {1}, \nHrs per week: {2}, Weekly Salary: {3}, Money per hour: {4:F2}",
            this.FirstName, this.LastName, this.WorkHoursPerDay, this.WeekSalary, this.MoneyPerHour()
            );
    }
}

