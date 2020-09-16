using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows, cols;
            int row_max, row_min, col_max, col_min;
            Console.WriteLine("Rows: ");
            rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cols: ");
            cols = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); ;
            for(int i = 0; i < rows; i++)
            {
                row_max = matrix[i,0];
                row_min = matrix[i,0];
                for(int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > row_max) row_max = matrix[i, j];
                    if (matrix[i, j] < row_min) row_min = matrix[i, j];

                }
                Console.WriteLine($"{i} row max value: {row_max}");
                Console.WriteLine($"{i} row min value: {row_min}");
            }
            for (int j = 0; j < cols; j++)
            {
                col_max = matrix[0, j];
                col_min = matrix[0, j];
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > col_max) col_max = matrix[i, j];
                    if (matrix[i, j] < col_min) col_min = matrix[i, j];

                }
                Console.WriteLine($"{j} col max value: {col_max}");
                Console.WriteLine($"{j} col min value: {col_min}");
            }
            Console.ReadLine();
        }
    }
}
