using System;

namespace HW2_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNumber = random.Next(0, 10);
            Console.WriteLine("I made a number, try to guess it. Enter number from 0 o 10");
            Game.CheckInput(randomNumber);
            Console.ReadKey();
        }
    }
}