using System;

namespace Looping_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;

            do
            {
                Console.WriteLine("_______________________________________________");
                Console.WriteLine(" 1. first Choice");
                Console.WriteLine("2. Second Choice");
                Console.WriteLine("3. EXIT");
                Console.WriteLine("________________________________________________");

                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("You chose first option");
                        break;
                    case 2:
                        Console.WriteLine("you chose second option");
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Incorrect entry - Try Again!!");
                        break;

                }
            } while (selection != 3);

            Console.WriteLine();
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();


        }

    }
}
