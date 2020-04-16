using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        int ticketAmount = Convert.ToInt32(Console.ReadLine());
        int[] divisor = { 100, 50, 20, 10, 5, 2, 1 };

        //Calculate & Print
        Console.WriteLine(ticketAmount);
        for(int i=0; i<7; i++)
        {
            int amount = ticketAmount / divisor[i];
            Console.WriteLine("{0} nota(s) de R$ {1},00", amount, divisor[i]);
            ticketAmount %= divisor[i];
        }

    }
}
