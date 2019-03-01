using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Operations
    {
        public static void ReadArray(int[] array)
        {
            Console.WriteLine($"Please enter {array.Length} numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        array[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect input: "+ ex.Message);
                    }
                }
            }

        }

        public static void WriteArray(int[] array)
        {
            Console.WriteLine("Result: ");
            foreach (int value in array)
            {
                Console.Write(value * 10 + " ");
            }
        }

    }
}
