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

            // Actual
            var result = book.GetStatitics();
            

            // assert
            Assert.Equal(50.5, result.Low);
            Assert.Equal(85.5, result.High);
            Assert.Equal(71.16666666666667, result.Average);
        }
    }
}
