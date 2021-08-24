using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. original coode
            //2. inferred typing version
            //3. string interpolation version
            //4. ternary operator version

            //1. original code 
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + "is less than 9";
            }
            else
            {
                response = answer + "greater than or equal to 9";
            }

            //2. inferred typing 
            var response2 = ""; //inferred using var
            var answer2 = 4; //inferred using var
            
            if (answer2 < 9)
            {
                response2 = answer2 + " is less than 9";
            }
            else
            {
                response2 = answer2 + "greater than or equal to 9";
            }
            Console.WriteLine(response2);

            //2. string interpolation

            int answer3 = 4;
            if (answer3 < 9)
            {
                Console.WriteLine($" {answer3} is less than 9");
            }
            else
            {
                Console.WriteLine($"{answer3} is greater than or equal to 9");
            }

            //3. ternary operator

            int answer4 = 4;
            var greaterThan = (answer4 < 9) ? $"{answer4} is less than 9 " : $"{answer4} is greater than or equal to 9";
            Console.WriteLine(greaterThan);




        }

    }
}
