using System;

namespace _1011___Sphere
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare Variables
            double pi = 3.14159;
            int radio = Convert.ToInt32(Console.ReadLine());

            //Calculate
            double volume = 4 / 3.0 * pi * Math.Pow(radio, 3);

            //Print
            Console.WriteLine("VOLUME = {0:0.000}", volume);

        }
    }
}
