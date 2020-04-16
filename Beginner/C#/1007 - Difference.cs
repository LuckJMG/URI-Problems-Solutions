using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        int C = Convert.ToInt32(Console.ReadLine());
        int D = Convert.ToInt32(Console.ReadLine());

        //Calculate
        double DIFERENCA = A * B - C * D;

        //Print
        Console.WriteLine("DIFERENCA = {0}", DIFERENCA);

    }
}
