using MVCMiniProjects.Models;

namespace MVCMiniProjects.Services
{
    public class FizzBuzzService
    {
        public static FizzBuzz Calculate(FizzBuzz fizzBuzz)
        {
            fizzBuzz.FizzBuzzValues = new string[fizzBuzz.EndValue];

            for (var i = fizzBuzz.StartValue; i <= fizzBuzz.EndValue; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzz.FizzBuzzValues[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    fizzBuzz.FizzBuzzValues[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    fizzBuzz.FizzBuzzValues[i - 1] = "Buzz";
                }
                else
                {
                    fizzBuzz.FizzBuzzValues[i - 1] = i.ToString();
                }
            }

            return fizzBuzz;

        }
    }
}
