using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        double pi = 3.14159;
        double r = Convert.ToDouble(Console.ReadLine());

        //Calculate
        double area = pi * r * r;

        //Print
        Console.WriteLine("A={0:0.0000}", area);

    }
}