﻿using System;
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
            string filename = dir + "\\RecordsOfStudent1.txt";
            Console.WriteLine(filename);
            if (!(File.Exists(filename)))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("File exists");
                String file1 = "Manisha, 21, IT";
                String file2 = "Manisha, 21, IT";
                File.WriteAllText(filename, file1);
                File.WriteAllText(filename, file2);
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