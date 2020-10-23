using System;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] magazyn = new string[5, 2];

            Console.WriteLine("Wprowadź dane: ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    magazyn[i, j] = Console.ReadLine();

                }
                Console.WriteLine();
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,6}", magazyn[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
