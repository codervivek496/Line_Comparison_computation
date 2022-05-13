using System;

namespace LineComparisonComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice; ;
            do
            {
                Console.WriteLine("\nWelcome to Line Comparison Computation Program");
                Console.WriteLine("\n1. Calculate single line length");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SingleLineLenght singleLineLenght = new SingleLineLenght();
                        singleLineLenght.LineLength();
                        break;
                }

            } while (choice != 0);
        }
    }

}



