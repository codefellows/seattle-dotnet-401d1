using System;
using System.IO;
//using System.Text;

namespace Class_Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = @"C:\Users\amanda\Desktop\CodeFellows\Demo3\Demo3File.txt";


                if (!File.Exists(filePath))
                {
                    using (FileStream fs = File.Create(filePath))
                    {
                        // Using System.Text directly other than thru a using because....
                        Byte[] myText = new System.Text.UTF8Encoding(true).GetBytes("This is my text");
                        fs.Write(myText, 0, myText.Length);
                    }
                }
                else
                {
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        //string s = "";
                        //while ((s = sr.ReadLine()) != null)
                        //{
                        //    Console.WriteLine(s);
                        //}

                        string[] words = File.ReadAllLines(filePath);

                        int length = words.Length;
                        foreach (string line in words)
                        {
                            Console.WriteLine(line);
                        }

                       // Console.Read();

                    }

                    AddText(filePath);
                    DeleteText(filePath);
                }



            }
            catch (DirectoryNotFoundException)
            {

                Console.WriteLine("The Directory you suggested does not exist");
            }

            // using
        }

        // x is the filepath
        static void AddText(string filePath)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.Write(Environment.NewLine);
                sw.WriteLine("More Text!");
            }

        }

        static void DeleteText(string filePath)
        {
            File.Delete(filePath);
            Console.WriteLine("your file has been deleted");
            Console.Read();
        }
    }
}
