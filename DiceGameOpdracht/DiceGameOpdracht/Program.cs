using System;

namespace DiceGameOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] read the rules");
            Console.WriteLine("[2] Start Game");
            Console.WriteLine("[3] Exit Game");

            string ans = Console.ReadLine();
            if (ans != null && ans == "1")
            {
                Console.WriteLine("rules: ");
               
            }
            else if (ans != null && ans == "2")
            {
                Console.WriteLine("start game");
                
            }
            else if (ans != null && ans == "3")
            {
                Console.Write("quit game");
            }
            else
            {
                Console.Write("ERROR");
            }

            
        }
    }
}
