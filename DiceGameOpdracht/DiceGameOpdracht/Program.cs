using System;
using System.Linq;

namespace DiceGameOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            dobbelgame();


            void dobbelgame()
            {

                Random rand = new Random();

                Console.WriteLine("[1] read the rules");
                Console.WriteLine("[2] Start Game");
                Console.WriteLine("[3] Exit Game");

                string ans = Console.ReadLine();
                if (ans != null && ans == "1")
                {
                    Console.WriteLine("rules: just type enter and pray");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    Console.Clear();
                    dobbelgame();

                }
                else if (ans != null && ans == "2")
                {
                    Console.WriteLine("start game");

                    startGame();

                }
                else if (ans != null && ans == "3")
                {
                    

                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("ERROR");
                }

                void startGame()
                {
                    Console.Clear();

                    int Players;
                    do
                    {
                        Console.WriteLine("enter how many players want to play (max 4) ");
                        String stringallplayers = Console.ReadLine();
                        Players = int.Parse(stringallplayers);



                    }
                    while (Players > 4);

                    int[] players1 = new int[Players];

                    int[] playerr = new int[Players];

                    int currentplayer = 0;

                    int currentplayer2 = 0;

                    int currentplayer3 = 0;

                    int i;

                    Console.Clear();

                    for (i = 0; i < Players; i++)
                    {

                        currentplayer2 = currentplayer2 + 1;

                        int dicenumb = rand.Next(1, 12);
                        int dicenumb2 = rand.Next(1, 12);
                        int totalRoll = dicenumb + dicenumb2;
                        Console.WriteLine($"player " + currentplayer2 + " rolled: " + dicenumb + " and " + dicenumb2);

                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }


                        players1[i] = totalRoll;

                    }

                    Console.Clear();

                    for (i = 0; i < Players; i++)
                    {
                        currentplayer = currentplayer + 1;

                        if (players1.Max() == players1[i])
                        {
                            Console.WriteLine("player: " + currentplayer + " won with " + players1.Max() + " points \n");
                        }
                    }


                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                    for (i = 0; i < Players; i++)
                    {
                        currentplayer3 = currentplayer3 + 1;

                        Console.WriteLine("player: " + currentplayer3 + " scored in total: " + players1[i]);
                    }

                    Console.Clear();

                    dobbelgame();


                }
            }





        }
        
    }
}
