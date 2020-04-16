using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        string values = Console.ReadLine();
        string[] values2 = values.Split(' ');
        int A = Convert.ToInt32(values2[0]);
        int B = Convert.ToInt32(values2[1]);
        int C = Convert.ToInt32(values2[2]);

        //Calculate
        int majorAB = (A + B + Math.Abs(A - B)) / 2;
        int majorABC = (majorAB + C + Math.Abs(majorAB - C)) / 2;

        //Print
        Console.WriteLine("{0} eh o maior", majorABC);

    }
}
