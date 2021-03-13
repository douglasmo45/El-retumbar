using System;

namespace accumulatorsandcounters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=8; i++) // hace que se pueda repetir cada valor y se pueda crear el triangulo
            {
                for(int j=num; j>i; j--) // da el valor para poder hacer el triangulo 
                {
                    Console.Write(j + " ");
                }
                for(int a=num; a<i; a++) //bucle para los espacios para crear el triangulo
                {
                    Console.WriteLine(); 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}