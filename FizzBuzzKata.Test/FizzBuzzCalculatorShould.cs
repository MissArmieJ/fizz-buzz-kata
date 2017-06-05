using System;
using NUnit.Framework;

namespace FizzBuzzKata.Test
{
    [TestFixture]
    public class FizzBuzzCalculatorShould
    {
        [Test]
        public void calculate_1_if_input_is_1()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.Calculate(1);

            Assert.That(output, Is.EqualTo("1"));
        }
    }

    public class FizzBuzz
    {
        public string Calculate(int number)
        {
            return "1";
        }
    }
}
