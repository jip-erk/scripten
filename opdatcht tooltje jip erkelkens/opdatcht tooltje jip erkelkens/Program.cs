using System;

namespace opdatcht_tooltje_jip_erkelkens
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yn = false;

            string[] shows = new string[3];
            shows[0] = "the office ";
            shows[1] = "luciver";
            shows[2] = "park and rec";


            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadKey();
            Console.WriteLine("show: {0}", shows);
            Console.WriteLine("do you like this show? [y/n]");
            while (true)
            {
                string ans = Console.ReadLine();
                if (ans != null && ans == "y")
                {
                    Console.WriteLine("y");
                    break;
                }
                else if (ans != null && ans == "n")
                {
                    Console.WriteLine("n");
                    break;
                }
                else
                {
                    Console.Write("Only y or n Allowed");
                }
            }
            

        }

     }
}
