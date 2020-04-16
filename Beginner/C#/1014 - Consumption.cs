using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        int distance = Convert.ToInt32(Console.ReadLine());
        double spentFuel = Convert.ToDouble(Console.ReadLine());

        //Calculate
        double consumption = distance / spentFuel;

        //Print
        Console.WriteLine("{0:0.000} km/l", consumption);

    }
}
