using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//  Create a functionality that will count the amount of times the calculator was used.

// Start the counter at 0
// if the user presses continue, add 1 to the counter
// if the user presses exit, reset the counter
class Counter
{
    private static int _counter = 0;

    public static int Count 
    {
        get { return _counter; }
    }
    
    // Increments the counter and shows how many times a user has used the calculator
    public static void increment() 
    {
        _counter++;
    }


    // Resets the counter if the user presses to reset.
    public static void reset () 
    {
        _counter = 0;
    }
}