using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            double y = 12.2;

            double[] numbers = new double[3];
            numbers[0] = 5.25;
            numbers[1] = 4.55;
            numbers[2] = 5.85;

            double sum = 0;

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            Console.WriteLine(x + y);
            System.Console.WriteLine(sum);
        }
    }
}
