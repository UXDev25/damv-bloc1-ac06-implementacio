using System;
using System.Runtime.CompilerServices;

// PRECONDITION: The user is prompted to input two integers.
public class Program
{
    public static void Main() 
    { 
        const string MSG_INPUT1 = "Enter the first integer:";
        const string MSG_INPUT2 = "Enter the second integer:";
        const string MSG_INPUT3 = "The sum is: ";
        int num1, num2, sum;

        Console.WriteLine(MSG_INPUT1);
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MSG_INPUT2);
        num2 = Convert.ToInt32(Console.ReadLine());
        sum = num1 + num2;
        Console.WriteLine(MSG_INPUT3 + sum);
    }
}
// POSTCONDITION: 'sum' contains the sum of 'num1' and 'num2', and it is displayed.



