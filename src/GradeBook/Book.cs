
using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public List<double> getGrades()
        {
            return this.grades;
        }

        public string getName()
        {
            return name;
        }

        public Statistics GetStatitics()
        {
            Statistics result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades) {
                if (grade > result.High) {
                    result.High = grade;
                }

                if (grade < result.Low) {
                    result.Low = grade;
                }

                result.Average += grade;

                return result;
            }
        }

    }


}