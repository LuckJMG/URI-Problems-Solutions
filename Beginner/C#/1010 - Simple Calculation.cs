using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
            //Product 1 
            string product1 = Console.ReadLine();
            string[] valuesProduct1 = product1.Split(' ');
            int codeProduct1 = Convert.ToInt32(valuesProduct1[0]);
            int unitsProduct1 = Convert.ToInt32(valuesProduct1[1]);
            double priceProduct1 = Convert.ToDouble(valuesProduct1[2]);

            //Product2
            string product2 = Console.ReadLine();
            string[] valuesProduct2 = product2.Split(' ');
            int codeProduct2 = Convert.ToInt32(valuesProduct2[0]);
            int unitsProduct2 = Convert.ToInt32(valuesProduct2[1]);
            double priceProduct2 = Convert.ToDouble(valuesProduct2[2]);

        //Calculate
        double totalPrice = priceProduct1 * unitsProduct1 + priceProduct2 * unitsProduct2;

        //Print
        Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", totalPrice);

    }
}
