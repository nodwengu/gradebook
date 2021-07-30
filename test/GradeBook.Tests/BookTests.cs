using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1() {
            // Arrange
            Book book = new Book("ReactJS");
            book.AddGrade(85.5);
            book.AddGrade(77.5);
            book.AddGrade(50.5);

            // Act
            

            // assert
            Assert.Equal("expected", "expected");
        }
    }
}
