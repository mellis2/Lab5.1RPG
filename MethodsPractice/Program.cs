using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c = 5;
            int d = 2;

            Console.WriteLine(CalculateArea(a, b));
            
            printMessage();
            book harryPotter = new book("Harry Potter", "Some Lady", 400, 5, 2);
            Console.WriteLine(harryPotter.CalculateArea2(c, d));
        }
        static void printMessage()
        {
            Console.WriteLine("The dog went to China");
        }
        static int CalculateArea(int x, int y) 
        {
            return x * y;
        }
    }
}
