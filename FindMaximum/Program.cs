using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Maximum maximum = new Maximum();
            int maxInt=maximum.maximumInteger(5, 7, 9);
            Console.WriteLine("Maximum of three Integers:"+maxInt);
            double maxDouble = maximum.MaximumDouble(8.8, 9.9, 10.0);
            Console.WriteLine("Maximum of three doubles:" + maxDouble);*/
            int[] arr = { 114, 153, 144, 110 };
            Geneiric<int> geneiric = new Geneiric<int>(arr);
            geneiric.Print();
            Console.ReadLine();
        }
    }
}
