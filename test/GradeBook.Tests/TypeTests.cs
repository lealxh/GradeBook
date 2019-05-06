using System;
using Xunit;
using GradeBook;


namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var b1 = GetBook("Book 1");
            var b2 = GetBook("Book 2");
            Assert.Equal("Book 1",b1.Name);
            Assert.Equal("Book 2",b2.Name);
            Assert.NotSame(b1,b2);
        }

        [Fact]
         public void ReferencesAreTheSame()
        {
            var b1 = GetBook("Book 1");
            var b2 = b1;
            Assert.Equal("Book 1",b1.Name);
            Assert.Equal("Book 1",b2.Name);
            Assert.Same(b1,b2);
        }

          [Fact]
        public void CanSetNameChangeName()
        {
            var b1 = GetBook("Book 1");
            SetName(b1,"New Name");
            Assert.Equal("New Name",b1.Name);
        }

        [Fact]
        public void CanGetBookSetNameChangeName()
        {
            var b1 = GetBook("Book 1");
            GetBookSetName(b1,"New Name");
            Assert.Equal("Book 1",b1.Name);
        }    


        private Book GetBook(string name)
        {
            return new Book(name);
        }

        private void GetBookSetName(Book b1, string name)
        {
            b1=new Book(name);
        }
    

        private void SetName(Book b1, string name)
        {
            b1.Name=name;
        }
    
    }
}
