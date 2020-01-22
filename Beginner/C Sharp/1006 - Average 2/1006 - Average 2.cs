using System;

namespace _1006___Average_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare Variables
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            //Calculate
            double MEDIA = (A * 2 + B * 3 + C * 5) / 10;

            //Print
            Console.WriteLine("MEDIA = {0:0.0}", MEDIA);

        }
    }
}
