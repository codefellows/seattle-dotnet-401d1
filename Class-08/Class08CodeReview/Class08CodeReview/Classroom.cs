using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Class08CodeReview
{
    class Classroom<R> : IEnumerable<R>
    {
        R[] students = new R[12];
        public int count = 0;

        public IEnumerator<R> GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                //Console.WriteLine(students[i]);
                yield return students[i];
            }
        }

        public void Add(R student)
        {
            if (count == students.Length)
            {
                int index = count * 2;
                R[] extension = new R[index];
                Array.Copy(students, extension, index);
                students = extension;
            }

            students[count] = student;
            count++;
        
        }

        public void Remove(R student)
        {
            int removeAt = Array.IndexOf(students, student);
            bool remove = false;
            R[] newArray = new R[students.Length];

            for(int i = 0; i < count; i++)
            {
                if(remove)
                {
                    newArray[i - 1] = students[i];
                }

                if(i != removeAt && !remove)
                {
                    newArray[i] = students[i];
                }
                else
                {
                    remove = true;
                }
            }
            students = newArray;
            //students[count] = student;
            count--;
        }

        public void BrandonsRemove(R student)
        {
            R[] temporary = new R[count - 1];
            int tempCount = 0;

            foreach(R s in students)
            {
                if(s != null)
                {
                    if(!s.Equals(student))
                    {
                        temporary[tempCount] = s;
                        tempCount++;
                    }
                }
            }

            students = temporary;
            count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
