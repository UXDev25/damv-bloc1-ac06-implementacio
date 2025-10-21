using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// PRECONDITION: The algorithm is ready to accept any integer input value.
using System;
public class Program
{
    public static void Main() 
    {
        const string msgInput = "Enter a value to check if it's within the interval (5, 50):";
        const string msgOk = " is within the interval (5, 50).";
        const string msgKo = " is NOT within the interval (5, 50).";

        int number;

        Console.WriteLine(msgInput);
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 5 && number < 50) 
        {
            Console.WriteLine(msgOk); ;
        }
        else
        {
            Console.WriteLine(msgKo);
        }
    }
}
// POSTCONDITION: The algorithm has read a 'number' and output a message indicating whether 'number' is strictly between 5 and 50.




