using System;

/*
    Assignment Operator =
    Arithmetic Operator +, -, *, /, %
    Comparison Operator ==, !=, >, >=, <, <=
    Conditional Operator &&, ||
    Ternary Operator ?:
    Null Coalescing ?? 空接合运算符
*/
class Program
{
    static void Main(string[] args)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        bool isPassed = false;

        // without ternary operator
        //if (number1 >= 60 && number2 >= 60)
        //{
        //    isPassed = true;
        //}

        // using ternary operator
        isPassed = (number1 >= 60 && number2 >= 60) ? true : false;
        Console.WriteLine("Number: {0} and {1} is {2}", number1, number2, isPassed);
    }
}

