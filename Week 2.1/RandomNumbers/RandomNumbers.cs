using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            GenerateRandomMatrix(3, 3);
        }

        static void GenerateRandomMatrix(int rows, int columns)
        {
            //string path = @"C:\Users\IVAN\Desktop\HackBulgaria 101 C#\Week 2.1\RandomNumbers\bin\Debug\Output.txt";
            float[,] matrix = new float[rows, columns];
            Random rnd = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (float)rnd.NextDouble();
                }
            }

            //File.WriteAllText(path, rows + "x" + columns);
            Console.WriteLine("{0}x{1}", rows, columns);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    //File.WriteAllText(path ,matrix[row,col].ToString("0.00", CultureInfo.InvariantCulture).PadLeft(15));
                    Console.Write(matrix[row, col].ToString("0.00", CultureInfo.InvariantCulture).PadLeft(15));
                }
                Console.WriteLine();
            }
        }
    }
}
