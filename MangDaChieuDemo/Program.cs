using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangDaChieuDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] strArray = new string[3, 4] { { "a", "b", "c", "d" }, { "x", "y", "z", "alpha" }, { "k", "l", "m", "n" } };



            for (int col = 0; col < strArray.GetLength(1); col++)
            {
                for (int row = 0; row < strArray.GetLength(0); row++)
                {
                    Console.Write(strArray[row, col] + "   ");
                }
                Console.WriteLine();
            }
            


            Console.ReadLine();



        }
    }
}
