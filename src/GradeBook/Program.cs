using System;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender,EventArgs args);

    class Program
    {
        
        static void Main(string[] args)
        {
            Book b=new Book("GOT");
            b.GradeAdded+=GradeAddedLogger;
            System.Console.WriteLine("Input a Grade: ");
            
            string input=Console.ReadLine();
            while(input.ToUpper()!="Q")
            {
                Double d;
                if(Double.TryParse(input, out d))
                 {
                     try
                     {
                        b.AddGrade(d);
                     }
                     catch (System.ArgumentException ex)
                     {
                         System.Console.WriteLine(ex.Message); 
                     }
           
                 }   

                System.Console.WriteLine("Input a Grade: ");
                input=System.Console.ReadLine();
            }
  
           Statistics result= b.getStatistics();
           System.Console.WriteLine($"Max: {result.High}");
           System.Console.WriteLine($"Min: {result.Low}");
           System.Console.WriteLine($"Avg: {result.Average}");
           System.Console.WriteLine($"Grade: {result.Grade}");

           Console.ReadLine();
        }
    
        public static void GradeAddedLogger(object sender,EventArgs args)
        {
            System.Console.WriteLine("Grade Added!"); 
        }
    }
}
