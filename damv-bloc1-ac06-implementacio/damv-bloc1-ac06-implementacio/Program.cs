using System;
using System.Runtime.CompilerServices;

// PRECONDITION: The user is prompted to input a temperature in Celsius.
public class Program
{
    public static void Main() 
    { 
        const string MSG_INPUT = "Enter temperature in celsius:";
        const string MSG_RESULT = "Temperature in kelvin: ";
        float celsius, kelvin;

        Console.WriteLine(MSG_INPUT);
        celsius = Convert.ToInt32(Console.ReadLine());
        kelvin = celsius + 273.15f;
        Console.WriteLine(MSG_RESULT + kelvin);
    }
}
// POSTCONDITION: 'kelvin' contains the converted temperature, and it is displayed.



