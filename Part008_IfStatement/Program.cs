using System;

/// <summary>
/// 1 if statement
/// 2 difference between || and |
///                    && and &
/// 3 swich statement
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        /* 
            When using ||, if the first condition is true,
            it doesn't check the second condition
        */
        if (number == 10 || number == 20)
        {
            Console.WriteLine("Your number is 10 or 20");
        }

        /* 
            When using |, even if the first condition is true,
            it also check the second condition
        */
        if (number == 10 | number == 20)
        {
            Console.WriteLine("Your number is 10 or 20");
        }
        else
        {

        }

        /*
            Similarly, when using &&, if the first condition is false,
            it doesn't check the second condition.
            While using &, even if the first condition is false,
            it also check the second condition
        */
        if (number != 10 && number != 20)
        {
            Console.WriteLine("Your number is neither 10 nor 20");
        }
        else
        {

        }

        // Multiple if-else statements can be replaced with a switch statement
        if (number == 10)
        {
            Console.WriteLine("Your number is 10");
        }
        else if (number == 20)
        {
            Console.WriteLine("Your number is 20");
        }
        else if (number == 30)
        {
            Console.WriteLine("Your number is 30");
        }
        else
        {

            Console.WriteLine("Your number is not 10, 20 and 30");
        }

        switch (number)
        {
            case 10:
                Console.WriteLine("Your number is 10");
                break;
            case 20:
                Console.WriteLine("Your number is 20");
                break;
            case 30:
                Console.WriteLine("Your number is 30");
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 and 30");
                break;
        }

        /* 
            If break statement is used inside a switch statement, 
            the control will leave the switch statement.

            Avoid to use goto statement.
        */
        switch (number)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", number);
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 and 30");
                break;
        }
    }
}

