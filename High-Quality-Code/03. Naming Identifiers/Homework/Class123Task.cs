using System;

class VariableToString
{    
    class BoolToString
    {
        public void DisplayBoolAsString(bool variable)
        {
            string variableAsString = variable.ToString();
            
            Console.WriteLine(variableAsString);
        }
    }
    
    static void Main()
    {
        VariableToString.BoolToString testInput = new VariableToString.BoolToString();
        testInput.DisplayBoolAsString(true);
    }
}

