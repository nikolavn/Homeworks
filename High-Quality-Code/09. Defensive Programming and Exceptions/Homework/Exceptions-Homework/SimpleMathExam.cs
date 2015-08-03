using System;

public class SimpleMathExam : Exam
{
    private const int examProblemsMinCount = 0;
    private const int examProblemsMaxCount = 10;
    private const double passingGradePercentOfProblems = 0.6;
    private const double averageGradePercentOfProblems = 0.8;
    private const string examNotPassedComment = "Bad result: nothing done.";
    private const string examPassedAverageComment = "Average result: almost everything done.";
    private const string examPassedExcellentComment = "Excellent result: everything done.";
    
    private int problemsSolved;   

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            problemsSolved = 0;
        }
        if (problemsSolved > 10)
        {
            problemsSolved = 10;
        }

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }

        set
        {
            if (value < examProblemsMinCount)
            {
                this.problemsSolved = examProblemsMinCount;
            }

            if (value > examProblemsMaxCount)
            {
                this.problemsSolved = examProblemsMaxCount;
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        string comment;

        if (this.ProblemsSolved < passingGradePercentOfProblems*examProblemsMaxCount)
        {
            comment = examNotPassedComment;
        }
        else if (this.ProblemsSolved <= averageGradePercentOfProblems*examProblemsMaxCount)
        {
            comment = examPassedAverageComment;
        }
        else
        {
            comment = examPassedExcellentComment;
        }

        return new ExamResult(this.problemsSolved,examProblemsMinCount,examProblemsMaxCount,comment);
    }
}
