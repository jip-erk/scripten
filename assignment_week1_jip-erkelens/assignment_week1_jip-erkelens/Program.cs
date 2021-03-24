using System;
using System.Collections.Generic;

namespace week_1_Assignment_jip_erkelens
{
    class Program
    {



        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 7);

            #region list

            var items1 = new List<string>() { "item1", "item2", "item3", "item4", "item5" };

            var items2 = new List<string>() { "item1", "item2", "item3" };

            items1.AddRange(items2);

            items1.ForEach(Console.WriteLine);

            #endregion



            Console.WriteLine("enter item: ");
            listchecker();

            void listchecker()
            {

                if (items1.Contains(Console.ReadLine()))
                {
                    Console.WriteLine("This item is in the list!");
                }
                else
                {

                    Console.WriteLine("this item is not in the list");
                    listchecker();
                }

                items1.RemoveAt(random);
                items1.Sort();
                items1.ForEach(Console.WriteLine);

                Console.WriteLine("~-------------------------------------~");

                items1.RemoveRange(4, items1.Count - 4);
                items1.Reverse();
                items1.ForEach(Console.WriteLine);

            }






        }
    }
}
