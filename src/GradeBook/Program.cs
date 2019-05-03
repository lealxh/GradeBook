using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           Book b=new Book("GOT");
           b.AddGrade(5.1);
           b.AddGrade(9.9);
           b.AddGrade(7.2);
           b.getStatistics();
        }
    }
}
