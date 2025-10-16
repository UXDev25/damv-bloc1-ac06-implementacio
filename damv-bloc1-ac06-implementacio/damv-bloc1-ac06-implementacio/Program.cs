using System;
using System.Runtime.CompilerServices;

// PRECONDITION: The user is prompted to input the width and height of a rectangle.

public class Program
{
    public static void Main() 
    { 
        const string Msg_Input_Widh = "Enter the width of the rectangle:";
        const string Msg_Input_Height = "Enter the height of the rectangle:";
        const string Msg_Result = "The area of the rectangle is: ";
        float width, height, area;

        Console.WriteLine(Msg_Input_Width);
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Msg_Input_Height);
        height = Convert.ToInt32(Console.ReadLine());
        area = width * height;
        Console.WriteLine(Msg_Result + area);
    }
}
// POSTCONDITION: 'area' contains the product of 'width' and 'height', and it is displayed.



