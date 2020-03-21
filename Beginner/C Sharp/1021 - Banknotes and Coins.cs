using System;

namespace _1021___Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            double ticketAmount = Convert.ToDouble(Console.ReadLine()) * 100;
            int[] divisor = { 10000, 5000, 2000, 1000, 500, 200 };
            int[] divisor2 = { 100, 50, 25, 10, 5, 1 };

            //Calculate & Print
            Console.WriteLine("NOTAS:");
            for (int i = 0; i < 6; i++)
            {
                int amount = Convert.ToInt32(ticketAmount) / divisor[i];
                Console.WriteLine("{0} nota(s) de R$ {1}.00", amount, divisor[i] / 100);
                ticketAmount %= divisor[i];
            }

            Console.WriteLine("MOEDAS:");
            for (int i = 0; i < 6; i++)
            {
                int amount = Convert.ToInt32(ticketAmount) / divisor2[i];
                double pDivisor = divisor2[i] / 100.0;
                Console.WriteLine($"{amount} moeda(s) de R$ {pDivisor:0.00}".Replace(',', '.'));
                ticketAmount %= divisor2[i];
            }

        }
    }
}
