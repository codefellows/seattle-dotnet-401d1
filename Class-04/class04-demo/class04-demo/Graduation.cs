using System;
using System.Collections.Generic;
using System.Text;

namespace class04demo
{
   class Graduation : Party
    {
        public string Diploma
        {
            get;
            set;
        }
        public string Tassles { get; set; }
        public int JobApplications { get; set; }
        public string Robes { get; set; }

        public Graduation(string tassleColor, int jobApplications, string robeColor )
        {
            Tassles = tassleColor;
            JobApplications = jobApplications;
            Robes = robeColor;
        }

        public void Speech()
        {
            Console.WriteLine("Congratulations Speech!");
        }

        public bool GetDiploma()
        {
            Console.WriteLine("Walk across the stage!!!!");
            return true;
        }

        public override void Theme()
        {
           // throw new NotImplementedException();
        }
    }
}
