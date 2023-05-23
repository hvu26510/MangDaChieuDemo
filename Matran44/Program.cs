using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matran44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4,4];

            for(int row = 0;  row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine($"Nhap vao o {row +1}X{col+1}:");
                    matrix[row, col] = int.Parse(Console.ReadLine());   
                }
            }

            //in ra

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]+"   ");
                }
                Console.WriteLine();
            }

            // tinh tong tung hang
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                int tong = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    tong = tong + matrix[row, col];
                }
                Console.WriteLine($"Tong hang {row+1} : {tong}");
                Console.WriteLine();
            }

            int tongDuongCheo1 = 0;
            int tongDuongCheo2 = 0;

            //tong Duong cheo 1
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int row = i;
                int col = i;
                tongDuongCheo1 = tongDuongCheo1 + matrix[row, col];
            }

            //tong Duong cheo 2
            for (int i = 0;i< matrix.GetLength(0); i++)
            {
                int row = i;
                int col = 4-i-1;
                tongDuongCheo2 = tongDuongCheo2 + matrix[row, col];
            }

            Console.WriteLine($"Tong duong cheo 1: {tongDuongCheo1}");
            Console.WriteLine($"Tong duong cheo 2: {tongDuongCheo2}");

            Console.ReadLine();

        }
    }
}
