using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers:");
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        array[i] = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect input data");
                    }
                }
            }
            Console.WriteLine("Result: ");
            foreach (int value in array)
            {
                Console.Write(value * 10 + " ");
            }
            Console.ReadKey();
        }

    }
}

