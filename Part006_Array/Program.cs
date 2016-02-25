using System;

/*
    An array is a collection of similar data types.
        Advantages: arrays are strong typed.
        Disadvantages: 
         1 The size of array cannot be increased once initialized.
         2 Have to rely on integral indices to store or retrieve items from the array.
*/
class Program
{
    static void Main(string[] args)
    {
        int[] ages = new int[3];

        ages[0] = 32; // index start from 0
        ages[1] = 28;
        ages[2] = 3;
        //ages[2] = "age"; // Compile error because of different type
        //ages[3] = 10; // Runtime error: IndexOutOfRange exception

        Console.WriteLine(ages[1]);
    }
}

