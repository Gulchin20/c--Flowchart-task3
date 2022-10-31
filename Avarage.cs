using System;

namespace hgydf
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;
            int sayac = -1;
            double arrage;
            for (i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    sayac++;

                }

            }
            Console.WriteLine(arrage = (sum / sayac));

        
        }
    }
}
