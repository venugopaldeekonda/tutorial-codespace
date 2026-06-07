
using System;
using System.Text;

/*1.Strings and its usage*/
string myName1 = "Venugopalraodeekonda";
Console.WriteLine($"Hello {myName1} has {myName1.Length} letters in it.");

string greeting1 = "      Hello World!       ";
Console.WriteLine($"[{greeting1}]");

string trimmedGreeting = greeting1.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting1.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting1.Trim();
Console.WriteLine($"[{trimmedGreeting}]");


/*2.String immutable*/
string s11 = "A string is more ";
string s22 = "than the sum of its chars.";

// Concatenate s1 and s2. This actually creates a new
// string object and stores it in s1, releasing the
// reference to the original object.
s11 += s22;

System.Console.WriteLine(s11);
// Output: A string is more than the sum of its chars.


//3.Verbatim string literals
string title3 = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
//Output: "The Æolean Harp", by Samuel Taylor Coleridge

string filePath3 = @"C:\Users\scoleridge\Documents\";
//Output: C:\Users\scoleridge\Documents\

string text3 = @"My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
/* Output:
My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...
*/

string quote3 = @"Her name was ""Sara.""";
//Output: Her name was "Sara."

/* 4. String interpolation*/
string name4 = "Sara";
string poem4 = $@"My pensive {name4} ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
/* Output:
My pensive Sara ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...
*/  
/* 5. StringBuilder*/

StringBuilder sb5 = new StringBuilder();
sb5.Append("Hello");
sb5.Append(" ");
sb5.Append("World!");
string result = sb5.ToString();
Console.WriteLine(result);
// Output: Hello World!

/*6. String interpolation with StringBuilder*/
StringBuilder sb6 = new StringBuilder();
string name6 = "Sara";
sb6.Append($"My pensive {name6} ! thy soft cheek reclined");
sb6.AppendLine();   
sb6.Append("Thus on mine arm, most soothing sweet it is");
sb6.AppendLine();
sb6.Append("To sit beside our Cot,...");
string result2 = sb6.ToString();
Console.WriteLine(result2);
/* Output
My pensive Sara ! thy soft cheek reclined
Thus on mine arm, most soothing sweet it is
To sit beside our Cot,...
*/
/*7. String methods*/
string original7 = "Hello World!";
string upper7 = original7.ToUpper();          
string lower7 = original7.ToLower();
string substring7 = original7.Substring(0, 5);
string replaced7 = original7.Replace("World", "C#");
Console.WriteLine(upper7);       // Output: HELLO WORLD!
Console.WriteLine(lower7);       // Output: hello world!
Console.WriteLine(substring7);   // Output: Hello
Console.WriteLine(replaced7);    // Output: Hello C#!

/*8. String comparison*/
string str81 = "Hello";  
string str82 = "hello";
bool areEqual = str81.Equals(str82, StringComparison.OrdinalIgnoreCase);
Console.WriteLine(areEqual); // Output: True

/*9. String splitting and joining*/
string sentence9 = "Hello World from C#";
string[] words9 = sentence9.Split(' ');
foreach (string word in words9){
    Console.WriteLine(word);
}
/* Output:
Hello
World
from
C#
*/  
string joined9 = string.Join(", ", words9);
Console.WriteLine(joined9); // Output: Hello, World, from, C#    
/*10. String formatting*/
int number10 = 42;
string formatted10 = string.Format("The answer to the Ultimate Question of Life, The Universe, and Everything is {0}.", number10);
Console.WriteLine(formatted10); // Output: The answer to the Ultimate Question of Life, The Universe, and Everything is 42.       
/*11. String interpolation with expressions*/
string name11 = "Sara";
int age11 = 30;
string interpolated = $"My pensive {name11} ! You are {age11} years old.";
Console.WriteLine(interpolated); // Output: My pensive Sara ! You are 30 years old.
/*12. String interpolation with verbatim strings*/
string filePath12 = @"C:\Users\scoleridge\Documents\";
string interpolatedPath12 = $@"The file is located at: {filePath12}";
Console.WriteLine(interpolatedPath12); // Output: The file is located at: C:\Users\scoleridge\Documents\      
/*13. String interpolation with expressions and verbatim strings*/
string name13 = "Sara";
int age13 = 30;
string filePath13 = @"C:\Users\scoleridge\Documents\";
string interpolated13 = $@"My pensive {name13} ! You are {age13} years
old. The file is located at: {filePath13}";
Console.WriteLine(interpolated13);
/* Output   
My pensive Sara ! You are 30 years old. The file is located at: C:\Users\scoleridge\Documents\
*/
/*14. String interpolation with expressions, verbatim strings, and formatting*/
string name14 = "Sara";
int age14 = 30;
string filePath14 = @"C:\Users\scoleridge\Documents\";
string interpolated14 = $@"My pensive {name14} ! You are {age14} years    old. The file is located at: {filePath14}";
Console.WriteLine(interpolated14);
/* Output       
My pensive Sara ! You are 30 years    old. The file is located at: C:\Users\scoleridge\Documents\
*/
/*15. String interpolation with expressions, verbatim strings, formatting, and alignment*/
string name15 = "Sara";
int age15 = 30;
string filePath15 = @"C:\Users\scoleridge\Documents\";
string interpolated15 = $@"My pensive {name15,-10} ! You are {age15,5} years old. The file is located at: {filePath15}";
Console.WriteLine(interpolated15);
/* Output
My pensive Sara       ! You are    30 years old. The file is located at: C:\Users\scoleridge\Documents\
*/  
/*16. String interpolation with expressions, verbatim strings, formatting, alignment, and culture-specific formatting*/
string name16 = "Sara";
int age16 = 30;
string filePath16 = @"C:\Users\scoleridge\Documents\";
string interpolated16 = $@"My pensive {name16,-10} ! You are {age16,5} years old. The file is located at: {filePath16}";
Console.WriteLine(interpolated16);
/* Output
My pensive Sara       ! You are    30 years old. The file is located at
C:\Users\scoleridge\Documents\
*/
/*17. String interpolation with expressions, verbatim strings, formatting, alignment, culture-specific formatting, and conditional expressions*/
string name17 = "Sara";
int age17 = 30;
string filePath17 = @"C:\Users\scoleridge\Documents\";
string interpolated17 = $@"My pensive {name17,-10} ! You are {age17,5} years old. The file is located at: {filePath17}. You are {(age17 >= 18 ? "an adult" : "a minor")}.";
Console.WriteLine(interpolated);
/* Output
My pensive Sara       ! You are    30 years old. The file is located at
C:\Users\scoleridge\Documents\. You are an adult.
*/
/*18. String interpolation with expressions, verbatim strings, formatting, alignment, culture-specific formatting, conditional expressions, and nested interpolations*/
string name18 = "Sara";
int age18 = 30;
string filePath18 = @"C:\Users\scoleridge\Documents\";
string interpolated18 = $@"My pensive {name18,-10} ! You are {age18,5} years old. The file is located at: {filePath18}. You are {(age18 >= 18 ? "an adult" : "a minor")}. {($"Your name has {name18.Length} letters.")}";
Console.WriteLine(interpolated18);
/* Output
My pensive Sara       ! You are    30 years old. The file is located at
C:\Users\scoleridge\Documents\. You are an adult. Your name has 4 letters.
*/  
/*19. String interpolation with expressions, verbatim strings, formatting, alignment, culture-specific formatting, conditional expressions, nested interpolations, and string literals*/
string name19 = "Sara";
int age19 = 30;
string filePath19 = @"C:\Users\scoleridge\Documents\";
string interpolated19 = $@"My pensive {name19,-10} ! You are {age19,5} years old. The file is located at: {filePath19}. You are {(age19 >= 18 ? "an adult" : "a minor")}. {($"Your name has {name19.Length} letters.")} {@"This is a verbatim string literal."}";
Console.WriteLine(interpolated19);
/* Output
My pensive Sara       ! You are    30 years old. The file is located at C:\Users\scoleridge\Documents\. You are an adult. Your name has 4 letters. This is a verbatim string literal.
*/
/*20. String interpolation with expressions, verbatim strings, formatting, alignment, culture-specific formatting, conditional expressions, nested interpolations, string literals, and escape sequences*/
string name20 = "Sara";
int age20 = 30;
string filePath20 = @"C:\Users\scoleridge\Documents\";
string interpolated20 = $@"My pensive {name20,-10} ! You are {age20,5} years old. The file is located at: {filePath20}. You are {(age20 >= 18 ? "an adult" : "a minor")}. {($"Your name has {name20.Length} letters.")} {@"This is a verbatim string literal."} {@"This is a verbatim string literal with an escape sequence: \nNew line."}";
Console.WriteLine(interpolated20);
/* Output
My pensive Sara       ! You are    30 years old. The file is located at C:\Users\scoleridge\Documents\. You are an adult. Your name has 4 letters. This is a verbatim string literal. This is a verbatim string literal with an escape sequence: \nNew line.
*/
/*21. String interpolation with expressions, verbatim strings, formatting, alignment, culture-specific formatting, conditional expressions, nested interpolations, string literals, escape sequences, and composite formatting*/
string name21 = "Sara";
int age21 = 30;
string filePath21 = @"C:\Users\scoleridge\Documents\";      
string interpolated21 = $@"My pensive {name21,-10} ! You are {age21,5} years old. The file is located at: {filePath21}. You are {(age21 >= 18 ? "an adult" : "a minor")}. {($"Your name has {name21.Length} letters.")} {@"This is a verbatim string literal."} {@"This is a verbatim string literal with an escape sequence: \nNew line."} {string.Format("The answer to the Ultimate Question of Life, The Universe, and Everything is {0}.", 42)}";
Console.WriteLine(interpolated21);
/* Output
My pensive Sara       ! You are    30 years old. The file is located at
C:\Users\scoleridge\Documents\. You are an adult. Your name has 4 letters. This is a verbatim string literal. This is a verbatim string literal with an escape sequence: \nNew line. The answer to the Ultimate Question of Life, The Universe, and Everything is 42.
*/

/*22. Create a method to sort given string array in alphabetical order and print the sorted array.*/
string[] names22 = { "Sara", "Venugopal", "Deekonda", "John", "Alice" };
Array.Sort(names22);
foreach (string name in names22){
    Console.WriteLine(name);
}
/* Output:
Alice
Deekonda
John
Sara
Venugopal
*/
/*23. Create a method to reverse a given string and print the reversed string.*/
string original23 = "Hello World!";
char[] charArray23 = original23.ToCharArray();              
Array.Reverse(charArray23);
string reversed23 = new string(charArray23);
Console.WriteLine(reversed23); // Output: !dlroW olleH
/*24. Create a method to check if a given string is a palindrome and print the result.*/
string original24 = "A man, a plan              , a canal, Panama";
string cleaned24 = new string(original24.Where(char.IsLetterOrDigit).ToArray()).ToLower();
string reversed24 = new string(cleaned24.Reverse().ToArray());
bool isPalindrome24 = cleaned24 == reversed24;
Console.WriteLine(isPalindrome24); // Output: True
/*25. Create a method to count the number of occurrences of a specific character in a given string and print the count.*/
string original25 = "Hello World!";
char characterToCount25 = 'o';
int count25 = original25.Count(c => c == characterToCount25);
Console.WriteLine(count25); // Output: 2       
/*26. Create a method to determine whether a string represents a numeric value and print the result.*/
string original26 = "12345";    
bool isNumeric26 = int.TryParse(original26, out _);
Console.WriteLine(isNumeric26); // Output: True
/*27. Create a method to determine whether a string represents a valid email address and print the result.*/
using System.Text.RegularExpressions;
string original27 = "john.doe@example.com";
bool isValidEmail27 = Regex.IsMatch(original27, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
Console.WriteLine(isValidEmail27); // Output: True  
/*28. Create a method to determine whether a string represents a valid URL and print the result.*/
using System.Text.RegularExpressions;
string original28 = "https://www.example.com";
bool isValidUrl28 = Regex.IsMatch(original28, @"^(https?|ftp)://[^\s/$.?#].[^\s]*$");
Console.WriteLine(isValidUrl28);
 // Output: True
/*29. Create a method to determine whether a string represents a valid date and print the result.*/
string original29 = "2024-06-01";
bool isValidDate29 = DateTime.TryParse(original29, out _);
Console.WriteLine(isValidDate29); // Output: True
/*30. Create a method to determine whether a string represents a valid time and print the result
.*/
string original30 = "14:30:00";
bool isValidTime30 = TimeSpan.TryParse(original30, out _);
Console.WriteLine(isValidTime30); // Output: True
/*31. Create a method to determine whether a string represents a valid GUID and print the result.*/
string original31 = "d3b07384-d9a0-4c1e-9a0b-1c2d3e4f5g6h";
bool isValidGuid31 = Guid.TryParse(original31, out _);
Console.WriteLine(isValidGuid31); // Output: False  
/*32. Create a method to determine whether a string represents a valid hexadecimal number and print the result.*/
string original32 = "1A3F";
bool isValidHex32 = int.TryParse(original32, System.Globalization.NumberStyles.HexNumber, null, out _);
Console.WriteLine(isValidHex32); // Output: True
/*33. Create a method to determine whether a string represents a valid binary number and print the result.*/
string original33 = "101010";
bool isValidBinary33 = original33.All(c => c == '0' || c == '1');
Console.WriteLine(isValidBinary33); // Output: True
/*34. Create a method to determine whether a string represents a valid octal number and print the result.*/
string original34 = "1234567";
bool isValidOctal34 = original34.All(c => c >= '0' && c <= '7');
Console.WriteLine(isValidOctal34); // Output: True
/*35. Create a method to determine whether a string represents a valid numeric value (C# Programming Guide)*/
/* 1. To determine whether a string is a valid representation of a specified numeric type, 
use the static TryParse method that is implemented by all primitive numeric types and also by types such as DateTime and IPAddress. */
using System;
class Program
{
    static void Main()
    {       



