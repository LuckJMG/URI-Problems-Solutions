using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
            //Coordinates 1
            string coordinates1 = Console.ReadLine();
            string[] xy1 = coordinates1.Split(' ');
            double x1 = Convert.ToDouble(xy1[0]);
            double y1 = Convert.ToDouble(xy1[1]);

            //Coordinates 2
            string coordinates2 = Console.ReadLine();
            string[] xy2 = coordinates2.Split(' ');
            double x2 = Convert.ToDouble(xy2[0]);
            double y2 = Convert.ToDouble(xy2[1]);

        //Calculate
        double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4);

        //Print
        Console.WriteLine(distance);

    }
}
