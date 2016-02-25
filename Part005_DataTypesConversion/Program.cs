using System;

/*
    Implicit & explicit conversion 隐式转换和显式转换

    Implicit conversion is done by compiler.
      For example, convert int -> float will not loose any data and 
      no exception will be thrown, which means an implicit conversion can be done.

      To the opposite, convert float -> int will loose the fractional part(小数部分的)
      and also a possiblity of overflow exception.
      Hence, explicit conversion is required for this case.

    In C#, using cast operator or convert class for explicit conversion


*/

class Program
{
    static void Main(string[] args)
    {
        int i = 100;
        // Implicit conversion
        float f = i;
        Console.WriteLine(f); // result is 100

        float f2 = 123.45F;
        // explicit conversion
        int i2 = (int)f2;
        Console.WriteLine(i2); // result is 123

        float f3 = 231809839405.22F;
        Console.WriteLine((int)f3); // result is -2147483648 overflow
        // using convert
        //Console.WriteLine(Convert.ToInt32(f3)); // Overflow exception


        // Parse() and TryParse()
        // For example, a number is in string
        string num1 = "100";
        string num2 = "aaa";

        // Parse() method throw exception if it cannot parse the value
        Console.WriteLine(int.Parse(num1));
        //Console.WriteLine(int.Parse(num2)); // format exception
        
        // TryParse() returns a boolean which means succeeded or failed
        int result = 0;
        Console.WriteLine(int.TryParse(num1, out result)); // true
        Console.WriteLine(result); // 100
        result = 0;
        Console.WriteLine(int.TryParse(num2, out result)); // false
        Console.WriteLine(result); // 0

    }
}

