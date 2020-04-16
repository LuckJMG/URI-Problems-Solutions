using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        int number = Convert.ToInt32(Console.ReadLine());
        int hoursWorked = Convert.ToInt32(Console.ReadLine());
        double hourlyPay = Convert.ToDouble(Console.ReadLine());
        double salary;

        //Calculate
        salary = hoursWorked * hourlyPay;

        //Print
        Console.WriteLine("NUMBER = {0}", number);
        Console.WriteLine("SALARY = U$ {0:0.00}", salary);

    }
}
