using System;

namespace makingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = true;
            bool atBeach = true;


            if (isSunny)
            {
                Console.WriteLine("Wear sunglasses!");

                if (atBeach)
                    Console.WriteLine("Wear sunblock!");
                else
                    Console.WriteLine("Don't need sunblock!");

            }
            else
            {
                Console.WriteLine("Don't need to wear sunglasses.");
                if (atBeach)
                    Console.WriteLine("Come back tomorrow");
                else
                    Console.WriteLine("Don't go to the beach");
            }


        }
    }
}
