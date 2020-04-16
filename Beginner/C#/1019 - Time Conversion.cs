using System;

class Program
{
    static void Main(string[] args)
    {

        //Variables
        int time = Convert.ToInt32(Console.ReadLine());

        //Calculate
        int hours = time / 3600; time %= 3600;
        int minutes = time / 60; time %= 60;
        int seconds = time;

        //Print
        Console.WriteLine("{0}:{1}:{2}", hours, minutes,seconds);

    }
}
