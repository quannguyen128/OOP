using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {   
            using(var db = new AppDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                
                        List<Student> gradList = new List<Student>()
                        {
                            new Student()
                            {
                                StudName = "John",
                                StudID = 12234,
                                DateofBirth = "01/01/81",
                                Major = "CIS",
                                GPA = 3.00,
                                PreviousDegree = "BSc", 
                                PreviousUniversity = "WTAMU",
                                UndergradMajor = "CS",
                                UndergradGPA = 3.33
                            },
                            new Student 
                            {
                                StudName = "Doe",
                                StudID = 12448,
                                DateofBirth = "05/22/71",
                                Major = "CIDM",
                                GPA = 3.25,
                                PreviousDegree = "BIT", 
                                PreviousUniversity = "CSU",
                                UndergradMajor = "CIS",
                                UndergradGPA = 3.50

                            },
                            new Student 
                            {
                                StudName = "Alice",
                                StudID = 32558,
                                DateofBirth = "10/15/91",
                                Major = "BA",
                                GPA = 3.80,
                                PreviousDegree = "BAcc", 
                                PreviousUniversity = "UCSD",
                                UndergradMajor = "ACC",
                                UndergradGPA = 4.00

                            }
                        };
                        List<Student> UndergradList = new List<Student>()
                        {
                            new UndergradStudent()
                            {
                                StudName = "John",
                                StudID = 12234,
                                DateofBirth = "01/01/81",
                                Major = "CIS",
                                GPA = 3.00,
                                previousHSchool = "PHS",
                            },
                            new UndergradStudent 
                            {
                                StudName = "Doe",
                                StudID = 12448,
                                DateofBirth = "05/22/71",
                                Major = "CIDM",
                                GPA = 3.25,
                                previousHSchool = "LHS",
                                Classification = 

                            },
                            new Student 
                            {
                                StudName = "Alice",
                                StudID = 32558,
                                DateofBirth = "10/15/91",
                                Major = "BA",
                                GPA = 3.80,
                                PreviousDegree = "BAcc", 
                                PreviousUniversity = "UCSD",
                                UndergradMajor = "ACC",
                                UndergradGPA = 4.00

                            }
                        };

                    
            }
            
            
            
        }
    }
}
