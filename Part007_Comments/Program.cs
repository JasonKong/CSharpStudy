using System;

/// <summary>
/// Three ways of comment in C#
/// Single line comments   //
/// Multi line comments    /*   */   
/// XML Document comments (just like this block of code using ///)
/// Keyboard shortcut: 
///     comment: Ctrl + K, Ctrl + C
///     uncomment: Ctrl + K, Ctrl + U
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // Captial of China        Single line comments
        string capital = "Beijing";
        string country = "";

        /*
            if capital is Beijing, 
            country will be assigned as China   Multi line comments
        */
        if (capital == "Beijing")
        {
            country = "China";
        }
    }
}


