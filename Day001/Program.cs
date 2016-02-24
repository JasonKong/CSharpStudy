using System;

class Program
{
    static void Main(string[] args)
    {
        // writing to console
        Console.WriteLine("Please enter your first name:");
        // reading from console
        string FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name:");
        string LastName = Console.ReadLine();

        // 2 ways to write to console
        // Concactenation
        // Console.WriteLine("Hello " + FirstName + " " + LastName);
        // Place holder syntax -- Most preferred
        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
    }
}
