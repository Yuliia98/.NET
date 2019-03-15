using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Game
{
    class Game
    {
        public static int number;
        public static void CheckInput(int randomNumber)
        {

            while (true)
            {
                while (true)
                {
                    try
                    {
                        number = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect input: " + ex.Message);
                    }
                }
                if (number < randomNumber)
                {
                    Console.WriteLine("My number is more :( ");
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("My number is less :( ");
                }
                else
                {
                    Console.WriteLine("You win :) Congratulations!");
                    break;
                }
            }

        }
    }
}
