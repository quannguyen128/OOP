using System;


namespace OOP
{

    public class UndergradStudent : Classifications 
    {   
      public string previousHSchool {get;set;}
      public String stdClass {get; set;}

      public override string ToString()
      {
        string output = $"\nStudent ID:\t\t{this.StudID}\nStudent Name:\t\t{this.StudName}\nBirth Date:\t\t{this.DateofBirth}\nMajor:\t\t\t{this.Major}\nGPA:\t\t\t{this.GPA}\nPrevious High School:\t{this.previousHSchool}\nStudent CLassification: {this.stdClass}\n";
        return output;
      }
      
       public void UpdateUnderGrad() 
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
            Console.WriteLine("Previous High School:\t ");
            previousHSchool = Console.ReadLine(); 
            Console.WriteLine("Student CLassification:\t ");
            stdClass = Console.ReadLine();


        }

    }  
    
}