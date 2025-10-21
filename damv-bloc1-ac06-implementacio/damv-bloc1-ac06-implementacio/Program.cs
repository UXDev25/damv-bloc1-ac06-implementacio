using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// PRECONDITION: The user must be ready to input integer values when prompted.
using System;
public class Program
{
    public static void Main() 
    {
        const string msgInput = "Enter an integer number within the interval (2, 30):";
        const string msgNumAttemps = "Attempt of 3: ";
        const string msgOk = "Valid number entered: ";
        const string msgKo = "Error: The number is not within the interval (2, 30). It must be between 3 and 29 (inclusive).";
        const string msgLost = "You have lost. No valid number entered.";
        const int maxAttemps = 3;
        const int minInt = 2;
        const int maxInt = 30;

        int number; 
        int attemps = 1;
        bool isValid = false;

        while (attemps <= maxAttemps && !isValid) 
        {
            Console.WriteLine(msgNumAttemps, attemps);
            Console.WriteLine(msgInput);
            number = Convert.ToInt32(Console.ReadLine());

            if (number > minInt && number < maxInt)
            {
                isValid = true;
            }
            else 
            {
                Console.WriteLine(msgKo);
                attemps++;
            }
        }

        if (isValid)
        {
            Console.WriteLine(msgOk, number);
        }
        else 
        {
            Console.WriteLine(msgLost);
        }

    }
}
// POSTCONDITION: Either 'isValid' is TRUE and a valid 'number' (3-29) has been read, or 'attempts' equals 4 and the user is informed of failure.




