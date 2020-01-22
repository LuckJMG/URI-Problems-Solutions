using System;

namespace _1017___Spent_Fuel
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare Variables
            int time = Convert.ToInt32(Console.ReadLine());
            int speed = Convert.ToInt32(Console.ReadLine());

            //Calculate
            double consumption = (speed * time) / 12.0;

            //Print
            Console.WriteLine("{0:0.000}", consumption);

        }
    }
}
