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
            System.Console.WriteLine(book.GetName());
        }
    }

}
