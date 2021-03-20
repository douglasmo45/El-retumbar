using System;

namespace accumulatorsandcounters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=num; i>=1; i--)
            {
                for(int j=1; j<i; j++)
                {
                    Console.Write(j + " ");
                }
                for(int a=num; a<i; a++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
