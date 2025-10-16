using System;
using System.Runtime.CompilerServices;

// PRECONDITION: The user is prompted to input a temperature in Celsius.
public class Program
{
    public static void Main() 
    { 
        const string Msg_Input = "Enter temperature in celsius:";
        const string Msg_Result = "Temperature in kelvin: ";
        float celsius, kelvin;

        Console.WriteLine(Msg_Input);
        celsius = Convert.ToInt32(Console.ReadLine());
        kelvin = celsius + 273.15f;
        Console.WriteLine(Msg_Result + kelvin);
    }
}
// POSTCONDITION: 'kelvin' contains the converted temperature, and it is displayed.



