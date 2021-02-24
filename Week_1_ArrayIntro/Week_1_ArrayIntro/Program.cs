using System;

namespace Week_1_ArrayIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            /* int[] numberArray;
            numberArray = new int[3];

            numberArray[2] = 40;
            numberArray[0] = 10;
            numberArray[1] = 20;

            Console.WriteLine(numberArray[1]);
            Console.WriteLine();

            string[] names = { "tinky winkie", "dipsy", "laa-laa", "po" };
            Console.WriteLine(names[2]);
            Console.WriteLine();

            string[] PlayerNames = new string[4];

            Console.WriteLine("player name");
            Console.WriteLine("player 1 : ");
            PlayerNames[0] = Console.ReadLine();

            Console.WriteLine("player 2 :");
            PlayerNames[1] = Console.ReadLine();


            Console.WriteLine("player 3 :");
            PlayerNames[2] = Console.ReadLine();


            Console.WriteLine("player 4 :");
            PlayerNames[3] = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("playernam for player 1 : " + PlayerNames[0]);
            Console.WriteLine("playernam for player 2 : " + PlayerNames[1]);
            Console.WriteLine($"playernam for player 3 : " + PlayerNames[2]);
            Console.WriteLine($"playernam for player 4 : " + PlayerNames[3]);

            */

            int[] numArray = { 6, 4, 118, 24 };

            Console.Write(numArray[0] + ", ");
            Console.Write(numArray[1] + ", ");
            Console.Write(numArray[2] + ", ");
            Console.Write(numArray[3]);
            Console.WriteLine();

            Array.Sort(numArray);

            Console.Write(numArray[0] + ", ");
            Console.Write(numArray[1] + ", ");
            Console.Write(numArray[2] + ", ");
            Console.Write(numArray[3]);
            Console.WriteLine();

            Array.Reverse(numArray);

            Console.Write(numArray[0] + ", ");
            Console.Write(numArray[1] + ", ");
            Console.Write(numArray[2] + ", ");
            Console.Write(numArray[3]);
            Console.WriteLine();





        }
    }
}
