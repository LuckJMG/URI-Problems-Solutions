using System;

namespace _1020___Age_on_Days
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int time = Convert.ToInt32(Console.ReadLine());

            //Calculate
            int years = time / 365; time %= 365;
            int months = time / 30; time %= 30;
            int days = time;

            //Print
            Console.WriteLine("{0} ano(s)", years);
            Console.WriteLine("{0} mes(es)", months);
            Console.WriteLine("{0} dia(s)", days);

        }
    }
}
