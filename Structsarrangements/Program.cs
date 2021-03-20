using System;

namespace Structsarrangements
{
    class Program
    {
        static void Main(string[] args)
        {
            Books [] array = new Book[4];

            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Libro numero: "+i)
                //titulo autor año color
                array[i].title = Console.ReadLine();

                array[i].author = Console.ReadLine();

                array[i].year = Int32.Parse(Console.ReadLine());
                
                array[i].color = Console.ReadLine();

            }
        }
    }
}
