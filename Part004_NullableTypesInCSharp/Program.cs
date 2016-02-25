using System;

/*
    In C#, there are 2 category types:
    Value types -- int, float, double, structs, enum etc
    Reference types -- Interface, Class, delegates, arrays etc

    By default, value types are all non nullable.

*/
class Program
{
    static void Main(string[] args)
    {
        int i = 0; // i is non nullable, which means i cannot be set to null
        int? j = null; // using ? to make nullable use

        // Why?
        // Nullable types bridge the difference between C# types and Database types.

        int AvailableSeat = 0;
        int? SeatOnReserve = null;

        // using null coalescing operator
        AvailableSeat = SeatOnReserve ?? 0;
        Console.WriteLine("Available seat is {0}", AvailableSeat);

    }
}

