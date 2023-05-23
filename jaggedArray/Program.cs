using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] jagArray = new string[3][];

            jagArray[0] = new string[] { "a", "b", "c", "d"  };
            jagArray[1] = new string[] { "m", "x", "y", "z", "p", "t" };
            jagArray[2] = new string[] { "K", "H" };



            for (int row = 0; row < jagArray.Length; row++)
            {
                for (int col = 0; col < jagArray[row].Length; col++)
                {
                    Console.Write(jagArray[row][col] + "  ");


                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
