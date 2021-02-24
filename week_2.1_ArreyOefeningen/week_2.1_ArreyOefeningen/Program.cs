using System;

namespace week_2._1_ArreyOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArrey;
            numberArrey = new int[5];

            numberArrey[0] = 10;
            numberArrey[1] = 20;
            numberArrey[2] = 30;
            numberArrey[3] = 40;
            numberArrey[4] = 50;

            Console.WriteLine("Second areey value : " + numberArrey[1]);

            Console.WriteLine();

            //opdracht 2

            int[] numbersArrey2 = { 7, 3, 88, 42, 69, 34, 8 };

            Console.WriteLine("fifth areey value : " + numbersArrey2[4]);

            Console.WriteLine();

            //opdracht 3 

            string[] input = new string[3];

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("give some input please : ");
                input[i] = Console.ReadLine();
            }

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

            //opdracht 4 

            Random rnd = new Random();
            int[] randomNumbers = new int[10];

            for (int i = 0; i < randomNumbers.Length; i ++)
            {
                randomNumbers[i] = rnd.Next(0, 3466);
            }
            foreach (int number in randomNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
