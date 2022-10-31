using System;

namespace tekonluq
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 122;
            int rmain;
            int sum=0;
            while (num > 0)
            {
                rmain = num % 10;
                sum=sum+rmain;
                num = num / 10;
                
            }
            

            Console.WriteLine(sum);
        }
    }
}
