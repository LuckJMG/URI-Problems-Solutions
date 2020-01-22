using System;

namespace _1012___Area
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare Variables
            double pi = 3.14159;
            string values = Console.ReadLine();
            string[] values2 = values.Split(' ');
            double A = Convert.ToDouble(values2[0]);
            double B = Convert.ToDouble(values2[1]);
            double C = Convert.ToDouble(values2[2]);

            //Calculate
            double triangule = (A * C) / 2.0;
            double circle = Math.Pow(C, 2) * pi;
            double trapezio = (C * (A + B)) / 2;
            double square = Math.Pow(B, 2);
            double rectangle = A * B;

            //Print
            Console.WriteLine("TRIANGULO: {0:0.000}", triangule);
            Console.WriteLine("CIRCULO: {0:0.000}", circle);
            Console.WriteLine("TRAPEZIO: {0:0.000}", trapezio);
            Console.WriteLine("QUADRADO: {0:0.000}", square);
            Console.WriteLine("RETANGULO: {0:0.000}", rectangle);

        }
    }
}
