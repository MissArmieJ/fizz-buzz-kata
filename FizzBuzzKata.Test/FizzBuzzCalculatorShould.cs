using System;
using NUnit.Framework;

namespace FizzBuzzKata.Test
{
    [TestFixture]
    public class FizzBuzzCalculatorShould
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        public void calculate_ouput_based_on_input_number(int number, string expectedOutput)
        {
            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.Calculate(number);

            Assert.That(output, Is.EqualTo(expectedOutput));
        }
    }

    public class FizzBuzz
    {
        public string Calculate(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}
