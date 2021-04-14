using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Marto");
            book.AddGrade(4.75);
            book.AddGrade(3.15);
            book.AddGrade(6);
            book.AddGrade(7.25);
            book.AddGrade(1.2);
            book.AddGrade(5.25);
            System.Console.WriteLine(book.GetName());
            System.Console.WriteLine(book.GetHighestGrade());
        }
    }

}
