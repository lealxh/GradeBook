using System;
using Xunit;
using GradeBook;


namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void ValueTypesTest()
        {
            var x = GetInt();
            SetInt(x);
            Assert.Equal(3,x);
        }


        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string var="Scott";
            string varUpper = MakeUpperCase(var);
            Assert.Equal("SCOTT",varUpper);
            Assert.Equal("Scott",var);
        }

        private string MakeUpperCase(string var)
        {
           return var.ToUpper();

        }

        private void SetInt(int x)
        {
            x=4;
        }

        private int GetInt()
        {
            return 3;
        }

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
        public void CanSetNameByReference()
        {
            var b1 = GetBook("Book 1");
            SetName(b1,"New Name");
            Assert.Equal("New Name",b1.Name);
        }

        [Fact]
        public void CSharpPassByReference()
        {
            var b1 = GetBook("Book 1");
            SetNameByNew2(ref b1,"New Name");
            Assert.Equal("New Name",b1.Name);
        }    

        [Fact]
        public void CSharpPassByValue()
        {
            var b1 = GetBook("Book 1");
            SetNameByNew(b1,"New Name");
            Assert.Equal("Book 1",b1.Name);
        }    


        private Book GetBook(string name)
        {
            return new Book(name);
        }

        private void SetNameByNew(Book b1, string name)
        {
            b1=new Book(name);
        }
    
         private void SetNameByNew2(ref Book b1, string name)
        {
            b1=new Book(name);
        }
    

        private void SetName(Book b1, string name)
        {
            b1.Name=name;
        }
    
    }
}
