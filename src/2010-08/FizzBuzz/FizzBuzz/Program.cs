using System;
using FizzBuzz.Core;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzGame = new FizzBuzzGame();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + ": " + fizzBuzzGame.Evaluate(i));
            }

            Console.ReadLine();
        }
    }
}
