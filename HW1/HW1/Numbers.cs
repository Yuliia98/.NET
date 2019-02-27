using System;

namespace HW1
{
    class Numbers
    {
        static void Main()
        { 
            var array = new int[5];
             
            Utilities.ReadArray(array);
            Utilities.WriteArray(array); 

            Console.ReadKey();
        }
    }
}