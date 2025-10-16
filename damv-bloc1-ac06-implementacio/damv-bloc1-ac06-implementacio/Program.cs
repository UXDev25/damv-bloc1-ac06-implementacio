using System;
using System.Runtime.CompilerServices;

// PRECONDITION: The user is prompted to input two integers.
public class Program
{
    public static void Main() 
    { 
        const string Msg_Input1 = "Enter the first integer:";
        const string Msg_Input2 = "Enter the second integer:";
        const string Msg_Input3 = "The sum is: ";
        int num1, num2, sum;

        Console.WriteLine(Msg_Input1);
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Msg_Input2);
        num2 = Convert.ToInt32(Console.ReadLine());
        sum = num1 + num2;
        Console.WriteLine(Msg_Input3 + sum);
    }
}
// POSTCONDITION: 'sum' contains the sum of 'num1' and 'num2', and it is displayed.



