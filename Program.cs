using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ReadCSV.Util;

namespace ReadCSV
{
    class Program
    {
        //把csv放进二维数组了
        static void Main(string[] args)
        {
           
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string ioCsv = path.Substring(0, path.LastIndexOf("bin")) + "io.csv";
            int x;
            int y;
            string[,] array = CsvUtil.CsvToTwoArray(ioCsv,out x, out y);
            for (int i = 0; i <x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(array[i, j] + ",");
                }
                Console.WriteLine();
            }

        }
    }
}
