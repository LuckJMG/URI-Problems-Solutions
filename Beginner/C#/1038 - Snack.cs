// With 5% error

using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        string[] input = Console.ReadLine().Split(' ');
        int X = Convert.ToInt32(input[0]);
        int Y = Convert.ToInt32(input[1]);
        double total;

        //Calculate
        switch (X)
        {
            case 1:
                total = Y * 4.00;
                Console.WriteLine($"Total: R$ {total:.00}");
                break;
            case 2:
                total = Y * 4.50;
                Console.WriteLine($"Total: R$ {total:.00}");
                break;
            case 3:
                total = Y * 5.00;
                Console.WriteLine($"Total: R$ {total:.00}");
                break;
            case 4:
                total = Y * 2.00;
                Console.WriteLine($"Total: R$ {total:.00}");
                break;
            case 5:
                total = Y * 1.00;
                Console.WriteLine($"Total: R$ {total:.00}");
                break;
            default:
                break;
        }

    }
}