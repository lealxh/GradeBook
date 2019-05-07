using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public string Name;
        private List<double> grades;

        public Book(string name)
        {
            this.Name=name;
            this.grades=new List<double>();
        }
        public void AddGrade(double grade)
        {
            if(grade>0 && grade<100)
                this.grades.Add(grade);
            else
                throw new ArgumentException($"Invalid {nameof(grade)}");

        }
        public Statistics getStatistics()
        {
            Statistics s=new Statistics();
            s.High=double.MinValue;
            s.Low=double.MaxValue;
            double Sum=0;
            foreach (var grade in grades)
            {
                
                s.High= System.Math.Max(grade,s.High);
                s.Low=System.Math.Min(grade,s.Low);
                Sum+=grade;
            } 
            Sum/=grades.Count;
            s.Average=Sum;
            
            switch (s.Average)
            {
                
                case var d when d>=90:
                s.Grade="A";
                break;

                case var d when d>=80:
                s.Grade="B";
                break;

                case var d when d>=70:
                s.Grade="C";
                break;

                case var d when d>=60:
                s.Grade="D";
                break;

                case var d when d>=50:
                s.Grade="E";
                break;

                default:
                s.Grade="F";
                break;

            
            }


            return s;
        }

    }

}