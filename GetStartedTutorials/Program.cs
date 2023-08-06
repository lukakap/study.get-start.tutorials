using System;

namespace GetStartedTutorial
{
    public class NumbersQuickStart
    {
        public NumbersQuickStart()
        {

        }

        void WorkWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);


            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }

        void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }

        void IntegerPrecisionAndLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        void WorkingWithDoubleTypes()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        void WorkingWithDecimalTypes()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        public void ComputeAreaOfCircle(double radius)
        {
            double radius_square = radius*radius;
            double area = radius_square * Math.PI;
            Console.WriteLine($" AREA OF THE CIRCLE IS:  {area}");
        }

    }

    public class BranchesAndLoops
    {

        public BranchesAndLoops()
        {}

        public int SumOfIntegers(int from = 1, int to = 20, int divideBy = 3)
        {
            int sum = 0;
            for (int i = from; i < to; i++)
            {
                if (i % divideBy == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }


    }

    public class ListCollections
    {
        public ListCollections()
        { }

        public void FibonacciNumbers(int count=20)
        {
            var fibonacciSequence = new List<int> {1, 1};

            for (int i = 1; i < count; i++)
            {
                int len = fibonacciSequence.Count;
                fibonacciSequence.Add(fibonacciSequence[len - 1] + fibonacciSequence[len - 2]);
                Console.WriteLine($"{i + 1})  {fibonacciSequence[len]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //YourClass instance = new YourClass();

            // Call methods on instance, or do other work...
            // instance.YourMethod();

            Console.WriteLine("Program execution finished. Press any key to exit.");

            //NumbersQuickStart n = new NumbersQuickStart();
            //n.ComputeAreaOfCircle(2.5);

            //BranchesAndLoops b = new BranchesAndLoops();
            //Console.WriteLine($"Sum of Integers {b.SumOfIntegers()} ");

            ListCollections l = new ListCollections();
            l.FibonacciNumbers();

            //Console.ReadKey();
        }
    }

}

