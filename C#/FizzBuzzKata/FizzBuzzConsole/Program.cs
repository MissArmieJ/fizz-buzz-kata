using System;
using FizzBuzzKata;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(fizzBuzz.Calculate(i));                
            }
            Console.ReadLine();
        }
    }
}
