using System;
using System.Collections.Generic;
using System.Linq;

namespace Class08CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Classroom<Student> dotNet = new Classroom<Student>();

            Student miya = new Student("miya");
            Student princessPa = new Student("Princess Pea");
            Student starLord = new Student("Peter Quill");


            dotNet.Add(miya);
            dotNet.Add(princessPa);
            dotNet.Add(starLord);


            foreach (Student s in dotNet)
            {
                //if(s!= null)
                //{
                Console.WriteLine(s.Name);

                //}
            }

            Console.WriteLine();

            dotNet.Remove(starLord);

            foreach (Student s in dotNet)
            {
                //if(s!= null)
                //{
                Console.WriteLine(s.Name);
                //}
            }

            dotNet.BrandonsRemove(princessPa);

            Console.WriteLine();
            foreach (Student s in dotNet)
            {
                //if(s!= null)
                //{
                Console.WriteLine(s.Name);

                //}
            }


            List<string> myList = new List<string> { "cat", "kitten", "dog", "puppy", "hamster", "squirrel", "turtle", "bird", "chick", "snake" };

            IEnumerable<string> myAnswers = from o in myList
                                            where o.Contains("i")
                                            select o;

            IEnumerable<string> mySecondAnswers = from l in myAnswers
                                                  where l.Length > 4
                                                  select l;


            IEnumerable<string> myLambdaExample = mySecondAnswers.Where(m => m.Contains('k'));

            /* Lambda Expression Outline:
             * s => s.Age > 12 AND s.Age < 20
             * 
             */

            List<Student> myStudents = new List<Student>();

            miya.Age = 22;
            miya.Class = EnrolledIn.ASPNET;
            miya.StudentID = 1234;

            starLord.Age = 21;
            starLord.Class = EnrolledIn.Python;
            starLord.StudentID = 4321;

            princessPa.Age = 68;
            princessPa.Class = EnrolledIn.ASPNET;
            princessPa.StudentID = 8675309;

            myStudents.Add(miya);
            myStudents.Add(starLord);
            myStudents.Add(princessPa);
            
            var filteredStudents = myStudents.Where(x => x.Age > 30 && x.Class == EnrolledIn.ASPNET );


            Console.Clear();
            foreach(string o in myLambdaExample)
            {
                Console.WriteLine(o);
            }

                ///** LINQ statement outline:
                // * from <<element>> in <<Collection>> 
                // * where <<expression>> 
                // * select <<expression>>
                // * * /


            Console.Read();
        }
    }
}
