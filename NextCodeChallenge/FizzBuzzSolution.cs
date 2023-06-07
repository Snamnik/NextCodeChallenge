using System.Text;

namespace NextCodeChallnge
{
    public class FizzBuzzSolution
    {
        public string PrintFizzBuzz(int input)
        {
            if (input < 0) return input.ToString();

            bool isMultipledByThree = input % 3 == 0;
            bool isMultipledByFive = input % 5 == 0;

            if (isMultipledByThree && isMultipledByFive) return "FizzBuzz";
            else if (isMultipledByThree) return "Fizz";
            else if (isMultipledByFive) return "Buzz";
            else return input.ToString();
        }

        public string PrintFizzBuzz_SecondWay(int input)
        {
            if (input < 0) return input.ToString();

            bool isMultipledByThree = input % 3 == 0;
            bool isMultipledByFive = input % 5 == 0;
            StringBuilder result = new StringBuilder();

            if (isMultipledByThree) result.Append("Fizz");
            if (isMultipledByFive) result.Append("Buzz");
            if (result.Length == 0) result.Append(input.ToString());

            return result.ToString();
        }
    }
}
