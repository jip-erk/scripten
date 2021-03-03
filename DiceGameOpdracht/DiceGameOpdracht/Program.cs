using System;

namespace DiceGameOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rand = new Random();

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

                startGame();
                
            }
            else if (ans != null && ans == "3")
            {
                Console.Write("quit game");
            }
            else
            {
                Console.Write("ERROR");
            }

            void startGame()
            {

                int Players;
                do
                {
                    Console.WriteLine("enter how many players want to play (max 4) ");
                    String stringallplayers = Console.ReadLine();
                    Players = int.Parse(stringallplayers);
                   

                   
                }
                while (Players > 4 );

                int[] players1 = new int[Players] ;

                

               for (int i = 0; i < Players; i++)
               {
                    int[] playerrolled = new int[i];

                    playerrolled[0] = [1];

                    int dicenumb = rand.Next(1, 12);
                    int dicenumb2 = rand.Next(1, 12);
                    int totalRoll = dicenumb + dicenumb2;
                    Console.WriteLine($"player" + "dice 1:" + dicenumb + "   dice 2:" + dicenumb2);

                }

               

              
            }

            
        }

        
    }
}
