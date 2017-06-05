namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Calculate(int number)
        {
            var output = string.Empty;

            if (IsMultiplesOfThree(number))
            {
                output += "Fizz";
            }

            if (IsMultiplesOfFive(number))
            {
                output += "Buzz";
            }

            if (string.IsNullOrEmpty(output))
            {
                output = number.ToString();
            }

            return output;
        }

        private static bool IsMultiplesOfFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsMultiplesOfThree(int number)
        {
            return (number % 3 == 0);
        }
    }
}