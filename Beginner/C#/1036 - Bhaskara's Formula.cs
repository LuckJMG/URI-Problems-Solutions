using System;

class Program
{
    static void Main(string[] args)
    {

        // Variables
        string[] input = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(input[0], System.Globalization.CultureInfo.InvariantCulture);
        double B = Convert.ToDouble(input[1], System.Globalization.CultureInfo.InvariantCulture);
        double C = Convert.ToDouble(input[2], System.Globalization.CultureInfo.InvariantCulture);

        // Calculate
        double R1 = Math.Round((-B + Math.Sqrt(Math.Pow(B, 2) - 4*A*C)) / (2*A), 5);
        double R2 = Math.Round((-B - Math.Sqrt(Math.Pow(B, 2) - 4*A*C)) / (2*A), 5);

        // Print
        if(A == 0 || (Math.Pow(B, 2) - 4*A*C) < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }else
        {
            Console.WriteLine(String.Format("R1 = {0}\nR2 = {1}", Convert.ToString(R1), Convert.ToString(R2)));
        }

    }
}