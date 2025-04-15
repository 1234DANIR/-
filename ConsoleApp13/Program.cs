using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        
        int myInt1 = 15614;
        int myInt2 = 15435;

       
        float myFloat = 123.456789f;

       
        myFloat = Math.Round(myFloat, 4);

        
        Console.WriteLine($"{"myInt1:",-10}{myInt1}");
        Console.WriteLine($"{"myInt2:",-10}{myInt2}");
        Console.WriteLine($"{"myFloat:",-10}{myFloat:F4}");
    }
}