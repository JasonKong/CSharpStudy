/*
    Build-in types in C#
    1 Boolean type -- Only true and false
    2 Integral types -- sbyte -128 ~ 127 Signed 8-bit integer, 
                        byte 0 ~ 255 Unsigned 8-bit integer, 
                        ushort       Unsigned 16-bit integer, 
                        short        Signed 16-bit integer, 
                        int          32bit, 
                        uint, 
                        long         64bit,  
                        unlong, 
                        char         Unicode 16bit
    3 Floating types -- float and double
    4 Decimal types  -- 128 bit data type
    5 String type
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Boolean type
        bool b = true;
        Console.WriteLine(b);

        // Integral type
        int i = 0;
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);

        // Floating type
        double d = 123.1213343479;
        Console.WriteLine(d);

        // String type
        string firstName = "\"Jason\"";
        Console.WriteLine(firstName);

        // Using escape sequences
        string name = "Albany\nAuckland\nNew Zealand";
        Console.WriteLine(name);

        /* Verbatim Literal 逐字转义
         Using @ symbol prefix
         Verbatim literals make escape sequences translate as normal printable characters
         to enhance readability
        */
        //string path = "F:\\workspace\\C#\\CSharpStudy";
        string path = @"F:\workspace\C#\CSharpStudy"; // more readable
        Console.WriteLine(path);
    }
}

