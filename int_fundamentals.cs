/*How to determine whether a string represents a numeric value (C# Programming Guide)*/
/* 1. To determine whether a string is a valid representation of a specified numeric type, 
use the static TryParse method that is implemented by all primitive numeric types and also by 
types such as DateTime and IPAddress. */
using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        string[] values = { "1", "1.0", "1e-10", "1f", "1D", "1M" };
        foreach (string value in values)
        {
            if (int.TryParse(value, out int i))
            {
                Console.WriteLine($"'{value}' is an integer.");
            }
            else if (double.TryParse(value, out double d))
            {
                Console.WriteLine($"'{value}' is a double.");
            }
            else
            {
                Console.WriteLine($"'{value}' is not a valid numeric value.");
            }
        }
    }
}
/* Output:
'1' is an integer.
'1.0' is a double.
'1e-10' is a double.
'1f' is not a valid numeric value.
'1D' is not a valid numeric value.
'1M' is not a valid numeric value.
*/
/* 2. To determine whether a string is a valid representation of any numeric type, use the static TryParse method that is implemented by the System.Numerics.BigInteger type. */

class Program
{
    static void Main()
    {
        string[] values = { "1", "1.0", "1e-10", "1f", "1D", "1M" };
        foreach (string value in values)
        {            if (BigInteger.TryParse(value, out BigInteger bigInt))
            {             Console.WriteLine($"'{value}' is a numeric value.");
            }       else
            {
                Console.WriteLine($"'{value}' is not a valid numeric value.");
            }       
        }  
    }
}
/* Output:
'1' is a numeric value.
'1.0' is a numeric value.
'1e-10' is a numeric value.
'1f' is a numeric value.
'1D' is a numeric value.
'1M' is a numeric value.
*/
/* 3. To determine whether a string is a valid representation of any numeric type, use the static TryParse method that is implemented by the System.Numerics.BigInteger type. */

class Program
{
    static void Main()
    {        string[] values = { "1", "1.0", "1e-10", "1f", "1D", "1M" };
        foreach (string value in values)
        {            if (BigInteger.TryParse(value, out BigInteger bigInt))
            {             Console.WriteLine($"'{value}' is a numeric value.");
            }       else
            {             Console.WriteLine($"'{value}' is not a valid numeric value.");
            }       }               
    }
}
/* Output:
'1' is a numeric value.
'1.0' is not a valid numeric value.
'1e-10' is not a valid numeric value.
'1f' is not a valid numeric value.
'1D' is not a valid numeric value.
'1M' is not a valid numeric value.
*/  
/* 4. To determine whether a string is a valid representation of any numeric type, use the static TryParse method that is implemented by the System.Numerics.BigInteger type. */
class Program
{
    static void Main()
    {        string[] values = { "1", "1.0", "1e-10", "1f", "1D", "1M" };
        foreach (string value in values)
        {            if (BigInteger.TryParse(value, out BigInteger bigInt))
            {             Console.WriteLine($"'{value}' is a numeric value.");
            }       else
            {             Console.WriteLine($"'{value}' is not a valid numeric value.");
            }       }               
    }
}/* Output:
'1' is a numeric value.
'1.0' is not a valid numeric value.
'1e-10' is not a valid numeric value.
'1f' is not a valid numeric value.
'1D' is not a valid numeric value.
'1M' is not a valid numeric value.
*/  

