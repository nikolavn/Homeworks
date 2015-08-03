using System;

public class ExamResult
{
    public string comments;
    public int grade;
    public int minGrade;
    public int maxGrade;
    

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        
        if (minGrade < 0)
        {
            throw new Exception();
        }
        if (maxGrade <= minGrade)
        {
            throw new Exception();
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public string Comments 
    {
        get 
        { 
            return this.comments; 
        }
        private set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Comments can not be null or empty");
            }

            this.comments = value;
        }
    }

    public int Grade 
    {
        get
        {
            return this.grade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade can not be negative");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Min Grade can not be negative");
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            if (value < 0 || value < this.minGrade)
            {
                throw new ArgumentException("Max Grade can not be negative or less than min grade");
            }

            this.maxGrade = value;
        }
    }
}
