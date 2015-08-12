namespace GameFifteen
{
    internal class MatrixConstants
    {
        internal readonly int[][] Directions = {
            new int[] {1,1},
            new int[] {1,0},
            new int[] {1,-1},
            new int[] {0,-1},
            new int[] {-1,-1},
            new int[] {-1,0},
            new int[] {-1,1},
            new int[] {0,1}
        };

        internal const string EnterPostiveNumberPrompt = "Enter a positive number";
        internal const string WrongInputError = "You haven't entered a correct positive number";

        internal const int MinSize = 1;
        internal const int MaxSize = 100;
    }
}