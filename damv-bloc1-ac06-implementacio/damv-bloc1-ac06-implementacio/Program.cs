using System;
using System.Runtime.CompilerServices;

// PRECONDITION: The user is prompted to input three real numbers.

public class Program
{
    public static void Main() 
    {
        const string Msg_Input1 = "Enter the first number:";
        const string Msg_Input2 = "Enter the second number:";
        const string Msg_Input3 = "Enter the third number:";
        const string Msg_Result = "The average is: ";
        float num1, num2, num3, average;

        Console.WriteLine(Msg_Input1);
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Msg_Input1);
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Msg_Input1);
        num3 = Convert.ToInt32(Console.ReadLine());
        average = (num1 + num2 + num3) / 3;
        Console.WriteLine(Msg_Result + average);
    }
}
// POSTCONDITION: 'average' contains the arithmetic mean of the three numbers, and it is displayed.




