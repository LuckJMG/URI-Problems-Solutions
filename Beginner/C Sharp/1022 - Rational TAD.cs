using System;

namespace _1022___Rational_TAD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            int N = Convert.ToInt32(Console.ReadLine());
            string[] list = new string[100000];

            //Function Simplify Fractions
            string simplify(int numerator, int denominator)
            {
                //Declare Variables
                int res;
                int a = Math.Max(numerator, denominator);
                int b = Math.Min(numerator, denominator);

                //M.C.D
                do
                {
                    res = b;
                    b = a % b;
                    a = res;
                } while (b != 0);

                //Check if the fraction is negative
                if (numerator < 0)
                {
                    numerator = - numerator;
                }

                string simplifiedResult = (numerator / res) + "/" + Math.Abs(denominator / res);

                return simplifiedResult;
            }

            //Calculate
            for(int i = 0; i < N; i++)
            {
                //Declare Variables
                string problem = Console.ReadLine(); string[] problemS = problem.Split(' ');
                string sign = problemS[3];
                int N1 = Convert.ToInt32(problemS[0]);
                int D1 = Convert.ToInt32(problemS[2]);
                int N2 = Convert.ToInt32(problemS[4]);
                int D2 = Convert.ToInt32(problemS[6]);
                int numerator, denominator; string result, simplifiedResult;

                //Select a case
                switch (sign)
                {
                    case "+":
                        numerator = N1 * D2 + N2 * D1;
                        denominator = D1 * D2;
                        result = numerator + "/" + denominator;
                        simplifiedResult = simplify(numerator, denominator);
                        break;
                    case "-":
                        numerator = N1 * D2 - N2 * D1;
                        denominator = D1 * D2;
                        result = numerator + "/" + denominator;
                        simplifiedResult = simplify(numerator, denominator);
                        break;
                    case "*":
                        numerator = N1 * N2;
                        denominator = D1 * D2;
                        result = numerator + "/" + denominator;
                        simplifiedResult = simplify(numerator, denominator);
                        break;
                    case "/":
                        numerator = N1 * D2;
                        denominator = N2 * D1;
                        result = numerator + "/" + denominator;
                        simplifiedResult = simplify(numerator, denominator);
                        break;
                    default:
                        result = "";
                        simplifiedResult = "";
                        break;
                }

                //Save the result in a array
                list[i] = result + " = " + simplifiedResult;
            }

            //Print
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
