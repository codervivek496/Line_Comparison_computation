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
                Console.WriteLine("2. Calculate if two lines are equal or not");
                Console.WriteLine("3. Comparinson of two lines");
                Console.WriteLine("4. Comparison of two lines using 2 methods");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SingleLineLenght singleLineLenght = new SingleLineLenght();
                        singleLineLenght.LineLength();
                        break;
                    case 2:
                        EqualityOfTwoLines equalityOfTwoLines = new EqualityOfTwoLines();
                        equalityOfTwoLines.Equality();
                        break;
                    case 3:
                        TwoLinesComparison twoLinesComparison = new TwoLinesComparison();
                        twoLinesComparison.Comparison();
                        break;
                    case 4:
                        ComparisonUsinAllMethod comparisonUsinAllMethod = new ComparisonUsinAllMethod();
                        comparisonUsinAllMethod.AllComparison();
                        break ;
                }

            } while (choice != 0);
        }
    }

}



