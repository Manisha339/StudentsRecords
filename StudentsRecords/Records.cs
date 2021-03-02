using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentsRecords
{
    class Record
    {
        public static void Do()
        {
            ReadLine();
        }

        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\RecordsOfStudent.txt";
            Console.WriteLine(filename);
            if (!File.Exists(filename))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("File exists");
                string[] contents = File.ReadAllLines(filename);
                foreach (var content in contents)
                {
                    string[] data = content.Split(", ");
                    Console.WriteLine("\n Name:" + data[0] + ", Age:" + data[1] + ", Dept:" + data[2]);


                }
            }
        }
    }
}