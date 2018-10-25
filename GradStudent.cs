using System;


namespace OOP
{

    public class GradStudent : Student
    {   
      public string PreviousDegree {get; set;}
     
      public string PreviousUniversity {get; set;}
      public string UndergradMajor {get; set;}
      public double UndergradGPA {get; set;}

      public override string ToString()
      {
          string output = $"\nStudent ID:\t\t{this.StudID}\nStudent Name:\t\t{this.StudName}\nBirth Date:\t\t{this.DateofBirth}\nMajor:\t\t\t{this.Major}\nGPA:\t\t\t{this.GPA}\nPrevious Degree:\t{this.PreviousDegree}\nPrevious University:\t{this.PreviousUniversity}\nUndergradMajor:\t\t{this.UndergradMajor}\nUndergrad GPA:\t\t{this.UndergradGPA}\n";
            return output;
      }

        public void UpdateGrad() // method 
        { 
            Console.WriteLine("STUDENT ID:\t ");
            StudID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("NAME:\t ");
            StudName = Console.ReadLine();

            Console.WriteLine("DATE OF BIRTH:\t ");
            DateofBirth = Console.ReadLine();

            Console.WriteLine("MAJOR:\t ");
            Major = Console.ReadLine();

            Console.WriteLine("GPA:\t ");
            GPA = Convert.ToInt64(Console.ReadLine()); 

            Console.WriteLine("Previous Degree:\t ");
            PreviousDegree = Console.ReadLine();

            Console.WriteLine("Previous University:\t ");
            PreviousUniversity = Console.ReadLine();

            Console.WriteLine("Undergrad Major:\t ");
            UndergradMajor = Console.ReadLine();
            
            Console.WriteLine("Undergrad GPA:\t ");
            UndergradGPA = Convert.ToInt64(Console.ReadLine());

        }
      
    }
}