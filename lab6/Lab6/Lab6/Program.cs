using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab6
{
    class Program
    {
        public static void arrayConvert()
        {
            StreamReader file = new StreamReader("C:/university/op_labs/lab6/Lab6/Lab6/arrays.txt");
            string str = "";
            while (!file.EndOfStream)
            {
                str += file.ReadLine();
            }
            string[] strings = str.Split(' ');

            int[] arr1 = new int[20];
            int[] arr2 = new int[20];
            for (int i = 0; i <= strings.Length; i++)
            {
                if (i == 0)
                {
                    arr1 = strings[i].Split(',').Select(Int32.Parse).ToArray();
                    continue;
                }
                if (i == 1)
                {
                    arr2 = strings[i].Split(',').Select(Int32.Parse).ToArray();
                    continue;
                }
            }

            Array.Sort(arr1);
            Array.Reverse(arr1);
            Array.Sort(arr2);
            Array.Reverse(arr2);

            int[] newArray = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, newArray, arr1.Length);
            Array.Copy(arr2, 0, newArray, arr1.Length, arr2.Length);

            newArray = newArray.Distinct().ToArray();
            Array.Sort(newArray);
          
            StreamWriter sw = new StreamWriter("C:/university/op_labs/lab6/Lab6/Lab6/result.txt");
            foreach (int i in newArray)
            {
                sw.WriteLine(i + ",");
            }
            sw.Close();

        }

        public static void getMatrix()
        {
            int size = 12;
            Random rand = new Random();
            Single[,] matrix = new Single[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(0, 50);
                }
            }

            int maxI = 0;
            int maxJ = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i >= j && matrix[i, j] > matrix[maxI, maxJ])
                    {
                        maxI = i;
                        maxJ = i;
                    }
                }
            }

            int[] result = { maxI, maxJ };

            StreamWriter sw = new StreamWriter("C:/university/op_labs/lab6/Lab6/Lab6/matrix.txt");
            sw.WriteLine(result[0] + " " + result[1]);
            sw.Close();

        }

        static void Main(string[] args)
        {
            arrayConvert();

            getMatrix();
        }
    }
}
