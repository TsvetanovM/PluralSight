using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() {5.25, 3.4, 4.92, 5.67};
            double totalGrades = 0;

            foreach(double grade in grades) {
                totalGrades += grade;
            }

            System.Console.WriteLine($"The average grade is {totalGrades / grades.Count:N2}");
        }
    }
}
