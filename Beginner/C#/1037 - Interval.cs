using System;

class Program
{
    static void Main(string[] args)
    {

        // Variables
        double input = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        // Calculate & print
        if (0 <= input && input <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (20 < input && input <= 50)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (50 < input && input <= 75)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (75 < input && input <= 100)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else Console.WriteLine("Fora de intervalo");

    }
}