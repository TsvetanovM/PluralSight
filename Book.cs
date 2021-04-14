using System.Collections.Generic;

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
            if (grade >= 2 || grade <= 6 ) 
            {
                grades.Add(grade);
            }
        }

        public string GetName() {
            return this.name;
        }
    }
}