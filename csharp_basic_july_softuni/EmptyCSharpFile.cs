using System;

namespace csharp_basic_july_softuni
{
    class Program
    {
        static void Main(string[] args)
        {
            //read numbers from the console.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //specify the result is a-b.
            int result = a - b;
            //calculate the result from the entered in the console numbers.
            Console.WriteLine(result);

        }
    }
}
