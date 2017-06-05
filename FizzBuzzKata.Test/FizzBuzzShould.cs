﻿using NUnit.Framework;

namespace FizzBuzzKata.Test
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void calculate_ouput_based_on_input_number(int number, string expectedOutput)
        {
            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.Calculate(number);

            Assert.That(output, Is.EqualTo(expectedOutput));
        }
    }
}
