using System;
using System.Collections.Generic;
using System.Linq;


class Matrix<T> where T : struct,IComparable
{
    private int rows;
    private int cols;
    private T[,] matrix;

    public int Rows
    {
        get
        {
            return this.rows;
        }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Rows have to be more than 0");
            }

            this.rows = value;
        }
    }

    public int Cols
    {
        get
        {
            return this.cols;
        }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Cols have to be more than 0");
            }

            this.cols = value;
        }
    }

    public int Size { get; set; }

    public Matrix(int size)
    {
        this.Size = size;
        this.Rows = size;
        this.Cols = size;
        this.matrix = new T[this.Rows, this.Cols];
    }

    public T this[int row, int col]
    {
        get
        {
            if (0 <= row && row < this.Rows & 0 <= col && col < this.Cols)
            {
                return this.matrix[row, col];
            }
            else
            {
                throw new IndexOutOfRangeException("Item indexes have to be between 0 and " + this.Size);
            }

        }
        set
        {
            if (0 <= row && row < this.Rows & 0 <= col && col < this.Cols)
            {
                this.matrix[row, col] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Item indexes have to be between 0 and " + this.Size);
            }
        }
    }

    public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        Matrix<T> result = new Matrix<T>(matrix1.Size);

        if (matrix1.Size != matrix2.Size)
        {
            throw new ArgumentException("Matrices are of different size.");
        }

        for (int row = 0; row < matrix1.Rows; row++)
        {
            for (int col = 0; col < matrix1.Cols; col++)
            {
                result[row, col] = (dynamic)matrix1[row, col] + matrix2[row, col];
            }
        }

        return result;
    }

    public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        Matrix<T> result = new Matrix<T>(matrix1.Size);

        if (matrix1.Size != matrix2.Size)
        {
            throw new ArgumentException("Matrices are of different size.");
        }

        for (int row = 0; row < matrix1.Rows; row++)
        {
            for (int col = 0; col < matrix1.Cols; col++)
            {
                if (matrix1[row, col].CompareTo(matrix2[row, col]) < 0) //Check is done in case matrix is of type uint, ulong, byte and ushort
                {
                    result[row, col] = (dynamic)matrix2[row, col] - matrix1[row, col];
                }
                else
                {
                    result[row, col] = (dynamic)matrix1[row, col] + matrix2[row, col];
                }
            }
        }

        return result;
    }

    public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        Matrix<T> result = new Matrix<T>(matrix1.Size);

        if (matrix1.Size != matrix2.Size)
        {
            throw new ArgumentException("Matrices are of different size.");
        }

        for (int row = 0; row < matrix1.Rows; row++)
        {
            for (int col = 0; col < matrix1.Cols; col++)
            {
                result[row, col] = (dynamic)matrix1[row, col] * matrix2[row, col];
            }
        }

        return result;
    }

    public static bool operator true(Matrix<T> matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if (matrix[row,col]==(dynamic)0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if (matrix[row, col] == (dynamic)0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public void Print()
    {
        for (int row = 0; row < this.matrix.GetLength(0); row++)
        {
            for (int col = 0; col < this.matrix.GetLength(1); col++)
            {
                Console.Write(this.matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}

