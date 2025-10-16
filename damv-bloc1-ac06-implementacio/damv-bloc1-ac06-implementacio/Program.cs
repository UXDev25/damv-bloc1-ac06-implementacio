using System;
using System.Runtime.CompilerServices;

// PRECONDITION: The user is prompted to input an amount in euros.

public class Program
{
    public static void Main() 
    {
        float Exchange_Rate = 1.12f;
        const string Msg_Input = "Enter the amount in euros: ";
        const string Msg_Result = "Amount in dollars: ";
        float euros, dollars;

        Console.WriteLine(Msg_Input);
        euros = Convert.ToInt32(Console.ReadLine());
        dollars = euros * Exchange_Rate;
        Console.WriteLine(Msg_Result + dollars);
    }
}
// POSTCONDITION: 'dollars' contains the converted amount, and it is displayed.




