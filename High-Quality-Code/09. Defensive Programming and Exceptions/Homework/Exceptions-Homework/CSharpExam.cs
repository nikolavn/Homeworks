using System;

public class CSharpExam : Exam
{
    private const int examMinimumScore = 0;
    private const int examMaximumScore = 100;

    public int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Score can not be negative");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < examMinimumScore || this.Score > examMaximumScore)
        {
            throw new ArgumentOutOfRangeException("Exam score should be between " + examMinimumScore + " and " + examMaximumScore);
        }
        else
        {
            return new ExamResult(this.Score, examMinimumScore, examMaximumScore, "Exam results calculated by score.");
        }
    }
}
