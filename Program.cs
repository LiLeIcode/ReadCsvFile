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
            #region 为封装csv转二维数组

            //string path = AppDomain.CurrentDomain.BaseDirectory;
            //string ioCsv = path.Substring(0, path.LastIndexOf("bin")) + "io.csv";
            ////Console.WriteLine(ioCsv);
            //FileStream stream = new FileStream(ioCsv, FileMode.Open, FileAccess.Read);
            //StreamReader reader = new StreamReader(stream, Encoding.Default);
            //List<string> list = new List<string>();
            //for (int i = 0; reader.Peek() > 0; i++)
            //{
            //    string readLine = reader.ReadLine();
            //    string[] split = readLine?.Split(',');
            //    for (int j = 0; j < split?.Length; j++)
            //    {
            //        list.Add(split[j]);
            //    }
            //}
            //stream.Seek(0, SeekOrigin.Begin);
            //int x = 0;
            //while (reader.ReadLine()?.ToString() != null)
            //{
            //    x++;
            //}
            //int y = 1;
            //if (x != 0)
            //{
            //    y = list.Count / x;
            //}
            //string[,] array = new string[x, y];
            //int index = 0;
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        array[i, j] = list[index];
            //        ++index;
            //    }
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(array[i, j] + ",");
            //    }
            //}
            //reader.Close();
            //stream.Close();

            #endregion

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
