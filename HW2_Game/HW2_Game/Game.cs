using System;

namespace HW2_Game
{
    class Game
    {
        public static int Number; 
        public static void CheckInput(int randomNumber)
        {
            while (true)
            {
                while (true)
                {
                    try
                    {
                        int.TryParse(Console.ReadLine(), out Number); 
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect input: " + ex.Message);
                    }
                }
                if (Number < randomNumber)
                {
                    Console.WriteLine("My number is more :( ");
                }
                else if (Number > randomNumber)
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