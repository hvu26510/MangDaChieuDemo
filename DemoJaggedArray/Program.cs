using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] nganh = new string[3][];

            nganh[0] = new string[] { "CNTT", "C#1", "CSDL", "Web", "Java" };
            nganh[1] = new string[] { "Kinh Te", "Kinh te vi mo", "marketing" };
            nganh[2] = new string[] { "QTKD", "Quan Ly", "QT nhan luc", "Bao ve" };

            Console.WriteLine(nganh[2][3]);

            //for (int row = 0; row < nganh.Length; row++)
            //{
            //    for(int col = 0; col < nganh[row].Length; col++)
            //    {
            //        if(col == 0)
            //        {
            //            Console.WriteLine(nganh[row][col]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("- "+ nganh[row][col]);
            //        }
                    
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}
