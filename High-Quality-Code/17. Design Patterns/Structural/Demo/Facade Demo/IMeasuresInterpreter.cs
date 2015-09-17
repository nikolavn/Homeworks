using System;

namespace Facade_Demo
{
    public interface IMeasuresInterpreter
    {
        bool IsBelowMaximum(int max);

        bool IsAboveMinimum(int min);
    }
}
