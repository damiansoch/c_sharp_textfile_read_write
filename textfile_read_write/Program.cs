using System;
using System.IO;

namespace textfile_read_write
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //writing
            string[] lines1 = { "Line_1", "Line_2", "Line_3", "Line_4", "Line_5", "Line_6", "Line_7", "third Line_8" };

                File.WriteAllLines(@"C:\Users\damia\Desktop\Basic_C#_Programs\FileIOAssignment.txt",lines1);
            
            using(StreamWriter file = new StreamWriter(@"C:\Users\damia\Desktop\Basic_C#_Programs\FileIOAssignment.txt"))
            {
                foreach(string line in lines1)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            //reading
            string text = File.ReadAllText(@"C:\Users\damia\Desktop\Basic_C#_Programs\FileIOAssignment.txt");
            Console.WriteLine(text);

            string[] lines = File.ReadAllLines(@"C:\Users\damia\Desktop\Basic_C#_Programs\FileIOAssignment.txt");
            int counter = 0;
            foreach (string line in lines)
                
            {
                counter++;
                Console.WriteLine($"line{counter} is:\t{line}");
            }

        }
    }
}
