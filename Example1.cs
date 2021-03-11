using sistem;

Namespace Example1
{


    internal class Program
    {
       Public static void Main(string[] args)
       {
           int a = 0, b = 0;

           Console.writeLine("Enter a valie for a: ");
           a = int32.parse(console.readline());

            Console.writeLine("Enter a valie for b: ");
           b = int32.parse(console.readline());

           console.writeline($"adding {a} + {b} equals {addNumber(a,b)} ");
       }

       public static int addNumbers(int a, int b)
       {
           return a+b
       }
    }
}