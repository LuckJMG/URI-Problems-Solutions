using System;

class Program
{
    static void Main(string[] args)
    {

        // Declare Variables
        string[] input = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(input[0]);
        int b = Convert.ToInt32(input[1]);
        int c = Convert.ToInt32(input[2]);
        int d = Convert.ToInt32(input[3]);

        //Apply selection
        if(b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }else{
            Console.WriteLine("Valores nao aceitos");
        }

    }
}
