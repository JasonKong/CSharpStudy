using System;

/// <summary>
/// 1 While loop
/// 2 Do while loop
/// 3 For loop
/// </summary>
class Program
{
    static void Main(string[] args)
    {


        int targetNumber = int.Parse(Console.ReadLine());
        int currentNumber = 1;

        /*
            While loop check the condition first.
            If the condition is true, statement within the loop are excuted.
            This process is repeated as long as the condition is true.
        */
        while (currentNumber < targetNumber)
        {
            Console.WriteLine("Cuurent number is {0}", currentNumber);

            // Make sure there is a way for updating the variable participating in the condition
            currentNumber += 2;
        }

        /*
            Do while loop
            The condition for do while loop is at the end of the loop,
            which means the do loop is excuted at least one time.

            Do loop can be used to present a menu to user.
        */
        string userChoice = "";
        do
        {
            Console.WriteLine("Do you want to continue (yes or no)");
            userChoice = Console.ReadLine().ToUpper();
        } while (userChoice == "YES");

        /*
            For loop -- Similar to while loop.
            In a while loop we do the initialization at one place,
            condition check at another place and modifying the variable at another place,
            where as for loop has all of these at one place.
        */
        int[] numbers = new int[5];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        for (int i=0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        /*
            foreach loop
            It is used to iterate through the items in a collection.

        */
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}

