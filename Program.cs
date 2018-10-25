using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("1- Add Grad student:\n2- Add undergrad student\n3- List All grad students:\n4- List All undergrad students:\n5- E X I T: ");
            int a = Convert.ToInt32(Console.ReadLine());

                    while(a != 5)
                    {
                        if(a == 1)
                        {
                            
                            Console.WriteLine("Adding to Graduate List. Enter S to Start:  ");
                            string d = Console.ReadLine(); 
                            while(d != "N")
                            {
                                var instance = new GradStudent();
                                instance.UpdateGrad();
                                Console.WriteLine("ADD MORE? [Y/N] ");
                                d = Console.ReadLine();
                            }
                            Console.WriteLine("List Updated"); 
                            
                            break;    
                        }
                        if(a == 2)
                        {
                            Console.WriteLine("Adding to Undergrad List. Enter S to Start:  ");
                            string d = Console.ReadLine(); 
                            while(d != "N")
                            {
                                var instance = new UndergradStudent();
                                instance.UpdateUnderGrad();
                                Console.WriteLine("ADD MORE? [Y/N] ");
                                d = Console.ReadLine();
                            }
                            Console.WriteLine("List Updated");
                            break; 
                        }
                        if(a == 3)
                        {
                            List<GradStudent> gradList = new List<GradStudent>()
                            {
                                new GradStudent() //object
                                {
                                    StudID = 12234,
                                    StudName = "John",
                                    DateofBirth = "01/01/81",
                                    Major = "CIS",
                                    GPA = 3.45,
                                    PreviousDegree = "BSc", 
                                    PreviousUniversity = "WTAMU",
                                    UndergradMajor = "CS",
                                    UndergradGPA = 3.33
                                },
                                new GradStudent
                                {   StudID = 12448,
                                    StudName = "Doe",
                                    DateofBirth = "05/22/71",
                                    Major = "CIDM",
                                    GPA = 3.25,
                                    PreviousDegree = "BIT", 
                                    PreviousUniversity = "CSU",
                                    UndergradMajor = "CIS",
                                    UndergradGPA = 3.50

                                },
                                new GradStudent 
                                {  
                                    StudID = 32558,
                                    StudName = "Alice",
                                    DateofBirth = "10/15/91",
                                    Major = "BA",
                                    GPA = 3.80,
                                    PreviousDegree = "BAcc", 
                                    PreviousUniversity = "UCSD",
                                    UndergradMajor = "ACC",
                                    UndergradGPA = 4.00
                                } 
                            };

                               
                               foreach(GradStudent g in gradList)
                               {
                                   Console.WriteLine(g);
                               }
                               break;
                        }
                        if(a == 4)
                        {
                            List<Student> UndergradList = new List<Student>()
                            {
                                new UndergradStudent()
                                {
                                    StudID = 547857,
                                    StudName = "Bob",
                                    DateofBirth = "03/01/99",
                                    Major = "CIDM",
                                    GPA = .00,
                                    previousHSchool = "PHS",
                                    stdClass = "Sophomore"

                                },
                                new UndergradStudent 
                                {   StudID = 65888,
                                    StudName = "Charlie",
                                    DateofBirth = "07/02/01",
                                    Major = "CIDM",
                                    GPA = 3.50,
                                    previousHSchool = "LHS",
                                    stdClass = "Freshman" 

                                },
                                new UndergradStudent 
                                {   StudID = 87785,
                                    StudName = "Eve",
                                    DateofBirth = "12/01/95",
                                    Major = "CIDM",
                                    GPA = 3.70,
                                    previousHSchool = "AHS",
                                    stdClass = "Junior"
                                }  
                            };
                             foreach(UndergradStudent s in UndergradList)
                               {
                                   Console.WriteLine(s);
                               }
                               break;
                        }
                    } 
                    Console.WriteLine("Exiting Program");    
        }
    }
}
