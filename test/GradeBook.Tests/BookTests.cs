using System;
using Xunit;
using GradeBook;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void CalculateStatistics()
        {
            GradeBook.Book b= new GradeBook.Book("");
            
            b.AddGrade(11.0);
            b.AddGrade(12.0);
            b.AddGrade(13.0);

            Statistics s=b.getStatistics();
            Assert.Equal(12,s.Average);
            Assert.Equal(13,s.High );
            Assert.Equal(11,s.Low);

        }
    }
}
