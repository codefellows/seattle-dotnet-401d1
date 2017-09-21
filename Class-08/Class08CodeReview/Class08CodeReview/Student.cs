using System;
using System.Collections.Generic;
using System.Text;

namespace Class08CodeReview
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name {get;set;}
        public int Age { get; set; }
        public string MiddleInitial { get; set; }
        public EnrolledIn Class { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public bool GotSleep()
        {
            if(Class == EnrolledIn.ASPNET || Class == EnrolledIn.Python)
            {
                return false;
            }
            return true;
        }

        public string EatLunch(string food)
        {
            if (Class == EnrolledIn.Java || Class == EnrolledIn.Swift)
            {
                return $"This student had {food} for lunch after 12";
            }
            return $"This student had {food} for lunch before 12";
        }
    }

    enum EnrolledIn : int
    {
        Javascript = 1,
        Python,
        ASPNET,
        Java,
        Swift
    }
}
