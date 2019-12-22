using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        public static int[] arrayConvert()
        {
            int[] array1 = new int[20], array2 = new int[20];
            Random rand = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(0, 50);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rand.Next(0, 50);
            }

            Array.Sort(array1);
            Array.Reverse(array1);
            Array.Sort(array2);
            Array.Reverse(array2);

            int[] newArray = new int[array1.Length + array2.Length];
            Array.Copy(array1, newArray, array1.Length);
            Array.Copy(array2, 0, newArray, array1.Length, array2.Length);

            newArray = newArray.Distinct().ToArray();
            Array.Sort(newArray);

            return newArray;
        }

        public static int[] getMatrix()
        {
            int size = 12;
            Random rand = new Random();
            Single[,] matrix = new Single[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++) { 
                    matrix[i, j] = rand.Next(0, 50);
                }
            }

            int maxI = 0;
            int maxJ = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i >= j && matrix[i, j] > matrix[maxI, maxJ]) {
                        maxI = i;
                        maxJ = i;
                    }
                }
            }

            int[] result = { maxI, maxJ };
            return result;
        }

        static void Main(string[] args)
        {
            int[] arrayEx1 = arrayConvert();

            for (int i = 0; i < arrayEx1.Length; i++)
            {
                Console.Write(arrayEx1[i] + " ");
            }
            Console.WriteLine("----------------");

            int[] matrix = getMatrix();
            Console.WriteLine(matrix[0] + " " + matrix[1]);
        }
    }
}
