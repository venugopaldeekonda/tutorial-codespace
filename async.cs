// 1. Async Programming in C#
/* Asynchronous programming is a programming paradigm that allows you to write code that can perform multiple tasks concurrently without blocking the main thread. In C#, you can use the async and await keywords to create asynchronous methods. */
using System;
using System.Threading.Tasks;
class Program               
{
    static async Task Main()
    {
        Console.WriteLine("Starting the program...");
        await PerformAsyncOperation();
        Console.WriteLine("Program has completed.");
    }
    static async Task PerformAsyncOperation()
    {
        Console.WriteLine("Performing an asynchronous operation...");
        await Task.Delay(2000); // Simulate a time-consuming operation
        Console.WriteLine("Asynchronous operation completed.");
    }
}
/* Output:
Starting the program...
Performing an asynchronous operation...
Asynchronous operation completed.
Program has completed.
*/
/* In this example, the Main method is marked as async, which allows it to use the await keyword to call the PerformAsyncOperation method. The PerformAsyncOperation method simulates a time-consuming operation using Task.Delay, which is an asynchronous method that completes after a specified time. The program continues to run without blocking the main thread, allowing other operations to occur concurrently. */        
/* 2. Async implementation using all features of async/await  */
using System;
using System.Threading.Tasks;           
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting the program...");
        try
        {
            string result = await PerformAsyncOperation();
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Program has completed.");
        }
    }
    static async Task<string> PerformAsyncOperation()
    {
        Console.WriteLine("Performing an asynchronous operation...");
        await Task.Delay(2000); // Simulate a time-consuming operation
        if (DateTime.Now.Second % 2 == 0) // Simulate a condition for throwing an exception
        {
            throw new InvalidOperationException("An error occurred during the asynchronous operation.");
        }
        return "Asynchronous operation completed successfully.";
    }
}
/* Output (varies based on the current second):
Starting the program...
Performing an asynchronous operation...         
An error occurred: An error occurred during the asynchronous operation.
Program has completed.
*/
/* In this example, the PerformAsyncOperation method returns a string result and may throw an exception
based on a condition. The Main method uses a try-catch block to handle any exceptions that may occur during the asynchronous operation, and a finally block to ensure that a completion message is always printed. This demonstrates how to use all features of async/await in C#. */
/*3. Program to demonstrate all the extension methods in task class*/
using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Task<int> task = Task.Run(() => 42);
        int result = await task; // Await the task to get the result
        Console.WriteLine($"Result: {result}"); // Output: Result: 42
    }
}
/* In this example, we create a Task that runs a lambda expression returning the integer 42. We then await the task to get the result and print it to the console. This demonstrates the use of the Task class and its extension methods in C#. The Task class provides various methods for creating and managing asynchronous operations, such as Task.Run, Task.Delay, and Task.WhenAll, among others. */
/*4. Program to demonstrate all the extension methods in task class with error handling*/
using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        try
        {
            Task<int> task = Task.Run(() =>
            {                if (DateTime.Now.Second % 2 == 0) // Simulate a condition for throwing an exception
                {                    throw new InvalidOperationException("An error occurred during the task execution.");
                }
                return 42;
            });
            int result = await task; // Await the task to get the result
            Console.WriteLine($"Result: {result}"); // Output: Result: 42
        }
        catch (Exception ex)        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}/* In this example, we create a Task that may throw an exception based on a condition. We use a try-catch block to handle any exceptions that may occur during the task execution. If the task completes successfully, we print the result to the console. This demonstrates how to use the Task class with error handling in C#. The Task class provides a robust way to manage asynchronous operations, and using try-catch blocks allows you to handle any exceptions that may arise during the execution of tasks effectively. */



