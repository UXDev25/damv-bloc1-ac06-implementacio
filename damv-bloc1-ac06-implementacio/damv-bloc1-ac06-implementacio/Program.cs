using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// PRECONDITION: The algorithm is ready to accept any integer input value.
using System;
public class Program
{
    public static void Main() 
    {
        const string msgInput = "Enter a value to check if it's a natural number: ";
        const string msgOk = " is a natural number.";
        const string msgKo = " is NOT a natural number.";

        int value;
        bool isNatural;

        Console.WriteLine(msgInput);
        value = Convert.ToInt32(Console.ReadLine());

        if (value <= 0 && value == value) 
        {
            isNatural = false;
        }
        else
        {
            isNatural = true;
        }

        if (isNatural)
        {
            Console.WriteLine(msgOk);
        }
        else 
        {
            Console.WriteLine(msgKo);
        }
    }
}
/* POSTCONDITION: The algorithm has read a 'value' and output a message indicating whether 'value' is a 
 natural number.*/




