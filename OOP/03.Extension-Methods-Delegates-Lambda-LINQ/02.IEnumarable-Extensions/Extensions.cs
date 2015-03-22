using System;
using System.Collections.Generic;
using System.Text;

public static class IEnumExtensions
{
    public static decimal Sum<T>(this IEnumerable<T> collection)
    {
        decimal result = 0;

        foreach (var item in collection)
        {
            result += Convert.ToDecimal(item);
        }

        return result;
    }

    public static decimal Product<T>(this IEnumerable<T> collection)
    {
        decimal result = 1;

        foreach (var item in collection)
        {
            result *= Convert.ToDecimal(item);
        }

        return result;
    }

    public static decimal Average<T>(this IEnumerable<T> collection)
    {
        decimal result = 0;
        int elements = 0;

        foreach (var item in collection)
        {
            result += Convert.ToDecimal(item);
            elements++;
        }

        return result / elements;
    }

    public static decimal Min<T>(this IEnumerable<T> collection) where T : IComparable
    {
        decimal minimum = decimal.MaxValue, currentMin;

        foreach (var item in collection)
        {
            currentMin = Convert.ToDecimal(item);
            if (currentMin.CompareTo(minimum) < 0)
            {
                minimum = currentMin;
            }
        }

        return Convert.ToDecimal(minimum);
    }

    public static string ToString<T>(this IEnumerable<T> enumeration)
    {
        var result = new StringBuilder();
        result.Append("[ ");
        foreach (var item in enumeration)
        {
            result.Append(item);
            result.Append(" ");
        }
        result.Append("]");
        return result.ToString();
    }
}

