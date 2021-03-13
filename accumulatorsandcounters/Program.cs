using System;

namespace accumulatorsandcounters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=num; i>=0; i--)
            {
                for(int j=0; j<i; j++)
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
