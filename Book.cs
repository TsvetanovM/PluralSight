using System.Collections.Generic;
using System.Linq;

namespace GradeBook 
{
    class Book 
    {
        private List<double> grades;
        private string name;

        public Book(string name) 
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade) {
            if (grade >= 2 && grade <= 6 ) 
            {
                grades.Add(grade);
            }
        }

        public string GetName() {
            return this.name;
        }

        public double GetHighestGrade() {
           double highestGrade = double.MinValue;
           if (grades.Count == 0) {
               return 0;
           }
           foreach(double grade in grades) {
               if (grade > highestGrade) {
                   highestGrade = grade;
               }
           }
            return highestGrade;
        }

        public double GetLowestGrade() {
            double lowestGrade = double.MaxValue;
           if (grades.Count == 0) {
               return 0;
           }
           foreach(double grade in grades) {
               if (grade < lowestGrade) {
                   lowestGrade = grade;
               }
           }
            return lowestGrade;
        }

        public double GetAverageGrade() {
            return grades.Average();
        }
    }
}