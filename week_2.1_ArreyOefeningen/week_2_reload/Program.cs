using System;

namespace week_2_reload
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] nerfcylinder = new bool[6];
            bool isfullyLoaded = false;


            for (int i = 0; i < nerfcylinder.Length; i++)
            {
                nerfcylinder[i] = false;
            }

            checkCylinder();

            Console.WriteLine();

            Reload();

            Console.WriteLine();

            checkCylinder();

            continueAndClear();

            Console.WriteLine("I shot some darts.... lets check which chambers are empty...");
            nerfcylinder[2] = false;
            nerfcylinder[4] = false;

            checkCylinder();

            continueAndClear();

            void checkCylinder()
            {
                for (int i = 0; i < nerfcylinder.Length; i++)
                {
                    if(nerfcylinder[i] == false)
                    {
                        Console.WriteLine($"chamber {i + 1} is empty. ");
                    }
                    else
                    {
                        Console.WriteLine($"Chamber {i + 1} contains a dart. ");
                    }
                }

                if (isfullyLoaded == true)
                {
                    Console.WriteLine("the cylinder is fully loaded with darts");
                }
                else
                {
                    Console.WriteLine("your missing some darts mabey reload?");
                }
            };

            void Reload()
            {
               for (int i = 0; i < nerfcylinder.Length; i++)
                {
                    if (nerfcylinder[i] == false)
                    {
                        nerfcylinder[i] = true;
                        Console.WriteLine($"you put a dart in the chamber {i + 1}. ");
                    }
                }

                isfullyLoaded = true;
            }

            void continueAndClear()
            {
                Console.WriteLine();
                Console.WriteLine("press enter to continue....");
                Console.ReadLine();
                Console.Clear();
            }


        }
    }
}
