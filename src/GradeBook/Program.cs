using System;
using System.Collections.Generic;

namespace GradeBook
{
   class Program
   {
      static void Main(string[] args) {
         Book book = new Book("C# Concepts");
         book.AddGrade(55.5);
         book.AddGrade(40.5);
         book.AddGrade(20.5);
         var stats = book.GetStatitics();   

         //double average = stats.Average / grades.Count;
         //Console.WriteLine($"Book name is {book.name}");
         Console.WriteLine($"lowestGrade = {stats.Low}");
         Console.WriteLine($"highGrade = {stats.High}");
         Console.WriteLine($"Average = {stats.Average:N2}");
      }
    }

}
