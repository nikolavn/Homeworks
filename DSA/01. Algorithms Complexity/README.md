## Data Structures, Algorithms and Complexity Homework

1. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else
                  end--;
      }
      return count;
  }
  ```
The expected running time of the algorithm is **~n*(n-1)** because the outer *for* loop will execute **n** number of times and the inner *while* loop will execute another maximum of **n-1** times. Complexity is **O(n^2)**

2. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
The expected running time of this algorithm is **n*m**. It will iterate **n** times for each row and then another **m** times for each column in the current row.

3. **(*) What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++)
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1))
          sum += CalcSum(matrix, row + 1);
      return sum;
  }

  Console.WriteLine(CalcSum(matrix, 0));
  ```
