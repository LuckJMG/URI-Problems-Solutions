using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        string firstName = Console.ReadLine();
        double salary = Convert.ToDouble(Console.ReadLine());
        double totalValue = Convert.ToDouble(Console.ReadLine());
        double salaryBonus;

        //Calculate
        salaryBonus = salary + totalValue * 0.15;

        //Print
        Console.WriteLine("total = R$ {0:0.00}", salaryBonus);

    }
}
