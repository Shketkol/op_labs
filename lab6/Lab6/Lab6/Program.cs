using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:/Users/User/source/repos/study/lab6/Lab6/Lab6/arrays.txt");
            string str = "";
            while (!file.EndOfStream) {
                str += file.ReadLine();
            }

            Console.WriteLine(str);
        }
    }
}
