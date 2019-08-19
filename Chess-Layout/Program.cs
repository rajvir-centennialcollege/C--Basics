using System;
using System.Diagnostics;
namespace Chess_Layout
{ class Program
    {
        static void Main(string[] args)
        {
            Stopwatch loop1 = Stopwatch.StartNew();
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (row % 2 == 0)
                    {
                        Console.Write("B W ");
                    }
                    else
                    {
                        Console.Write("W B ");
                    }
                }
                Console.WriteLine();
                
            }
            loop1.Stop();
            Console.WriteLine("Loop 1: {0} ms", loop1.Elapsed.TotalMilliseconds);

            Console.WriteLine("__________faster and efficient______________");

            Stopwatch loop2 = Stopwatch.StartNew();
            string pattern;
            for (int row = 0; row < 5; row++)
            {
                if (row % 2 == 0)
                {
                    pattern = "W B ";
                }
                else
                {
                    pattern = "B W ";
                }
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(pattern);

                }
                Console.WriteLine();      
            }
                loop2.Stop();
                Console.WriteLine("Loop 2: {0} ms", loop2.Elapsed.TotalMilliseconds);
        }
    }
}
