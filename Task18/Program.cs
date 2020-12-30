using System;
using System.Collections.Generic;

namespace Task18
{
    class Program
    {
        static void EndOfCase()
        {
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            string input;
            bool checkInput;
            double value;
            double result;
            List<double> nums = new List<double>();

            Console.WriteLine("enter number or 'n' to complete the input: ");

            while (true)
            {
                input = Console.ReadLine();
                checkInput = double.TryParse(input, out value);

                if (!checkInput && input != "n")
                {
                    Console.WriteLine("wrong input format!");
                    break;
                }
                else if (!checkInput)
                {
                    break;
                }
                else
                {
                    nums.Add(value);
                }
            }

            if (nums.Count < 2)
            {
                Console.WriteLine("\noperations can't be perfomed, too few arguments");
            }
            else
            {
                double[] numsArr = nums.ToArray();
                Console.WriteLine("\n");

                start:

                Console.Clear();

                Console.WriteLine("entered numbers");
                foreach (var n in nums)
                    Console.Write(n + " ");
                Console.WriteLine("\n");

                Console.WriteLine("1.Add");
                Console.WriteLine("2.Calculate average");
                Console.WriteLine("3.Calculate dispercion");
                Console.WriteLine("4.Calculate standard deviation");
                Console.WriteLine("5.Calculate coefficient of variation");
                Console.WriteLine("\n6.exit\n");

                int opNum = 0;
                checkInput = false;

                while (!checkInput)
                {
                    Console.WriteLine("enter number of operation: ");
                    checkInput = int.TryParse(Console.ReadLine(), out opNum);
                }

                switch (opNum)
                {
                    case 1:
                        Console.Clear();

                        result = MathStatistics.CalcSum(numsArr);
                        result = MathStatistics.RoundTo(result, 2);
                        Console.WriteLine("sum = " + result);

                        EndOfCase();

                        goto start;
                    case 2:
                        Console.Clear();

                        result = MathStatistics.CalcAverage(numsArr);
                        result = MathStatistics.RoundTo(result, 2);
                        Console.WriteLine("average = " + result);

                        EndOfCase();

                        goto start;
                    case 3:
                        Console.Clear();

                        result = MathStatistics.CalcDispercion(numsArr);
                        result = MathStatistics.RoundTo(result, 2);
                        Console.WriteLine("dispercion = " + result);

                        EndOfCase();

                        goto start;
                    case 4:
                        Console.Clear();

                        result = MathStatistics.CalcStandardDeviation(numsArr);
                        result = MathStatistics.RoundTo(result, 2);
                        Console.WriteLine("standard deviation = " + result);

                        EndOfCase();

                        goto start;
                    case 5:
                        Console.Clear();

                        result = MathStatistics.CalcCoefficientOfVariation(numsArr);
                        result = MathStatistics.RoundTo(result, 2);
                        Console.WriteLine("coefficient of variation = " + result);

                        EndOfCase();

                        goto start;
                    case 6:
                        Console.Clear();

                        EndOfCase();

                        break;
                    default:
                        Console.WriteLine("wrong number!");

                        EndOfCase();

                        goto start;
                }

            }
        }
    }
}
