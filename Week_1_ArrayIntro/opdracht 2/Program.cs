using System;

namespace opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "volvo", "BMW", "Fort", "lambo", "" };
            cars[4] = "tesla";

            for (int i = 0; i < cars.Length; i++)
            {

                Console.WriteLine(cars[i]);
            }

        }
    }
}
