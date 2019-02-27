using System;
using System.Collections.Generic;

namespace HW1
{
    static class Utilities 
    { 
        public static void ReadArray(IList<int> array)  
        { 
            Console.WriteLine($"Please enter {array.Count} numbers:");
            
            for (int i = 0; i < array.Count; i++)
            {
                while (true)
                {
                    try
                    {
                        array[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()); 
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Incorrect input: {ex.Message}");
                    }
                }
            }
        }

        public static void WriteArray(IEnumerable<int> array)  
        {
            Console.WriteLine("Result: ");
            foreach (int value in array)
            { 
                Console.Write(value * 10 + " ");
            }
        }
    }
}