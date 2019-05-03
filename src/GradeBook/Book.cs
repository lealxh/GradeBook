using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private string Name;
        private List<double> grades;

        public Book(string name)
        {
            this.Name=name;
            this.grades=new List<double>();
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);

        }
        public Statistics getStatistics()
        {
            Statistics s=new Statistics();
            s.High=double.MinValue;
            s.Low=double.MaxValue;
            double Sum=0;
            foreach (var grade in grades)
            {
                if(grade>s.High)
                s.High=grade;

                if(grade<s.Low)
                s.Low=grade;

                Sum+=grade;
            } 
            Sum/=grades.Count;
            s.Average=Sum;


            return s;
        }

    }

}