using System;

namespace _1005___Average_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare Variables
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());

            //Calculate
            double MEDIA = (A * 3.5 + B * 7.5) / 11;

            //Print
            Console.WriteLine("MEDIA = {0:0.00000}", MEDIA);

        }
    }
}
