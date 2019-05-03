using System;
using Xunit;
using GradeBook;


namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            GradeBook.Book b= new GradeBook.Book("");
            b.AddGrade(11.0);
            b.AddGrade(12.0);
            b.AddGrade(13.0);
            

            Statistics s=b.getStatistics();
            Assert.Equal(12,s.Average);
            Assert.Equal(13,s.High );
            Assert.Equal(13,s.Low);
            
            
       

        }
    }
}
