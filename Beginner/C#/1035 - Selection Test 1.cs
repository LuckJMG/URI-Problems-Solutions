using System;

class Program
{
    static void Main(string[] args)
    {

        // Declare Variables
        string[] input = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(input[0]);
        int B = Convert.ToInt32(input[1]);
        int C = Convert.ToInt32(input[2]);
        int D = Convert.ToInt32(input[3]);

        //Apply selection
        if(B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }else{
            Console.WriteLine("Valores nao aceitos");
        }
    }
}
