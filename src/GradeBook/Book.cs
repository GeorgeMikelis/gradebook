using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            var sum = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(var grade in grades)
            {
                sum += grade;
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High); 
            }
            result.Average = sum/grades.Count;
            return result;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        private List<double> grades;
        public string Name;
    }
}