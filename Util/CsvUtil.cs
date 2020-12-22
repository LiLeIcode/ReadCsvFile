using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadCSV.Util
{
    public class CsvUtil
    {
        /// <summary>
        /// csv转二维数组
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="x">二位数组的X轴</param>
        /// <param name="y">二维数组的Y轴</param>
        /// <returns></returns>
        public static string[,] CsvToTwoArray(string path, out int x, out int y)
        {
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            //Encoding.Default为ansi编码格式，csv默认为ansi编码格式
            StreamReader reader = new StreamReader(stream, Encoding.Default);
            List<string> list = new List<string>();
            //将csv数组存到List
            for (int i = 0; reader.Peek() > 0; i++)
            {
                string readLine = reader.ReadLine();
                string[] split = readLine?.Split(',');
                for (int j = 0; j < split?.Length; j++)
                {
                    list.Add(split[j]);
                }
            }
            //将文件流重新定位到0位置,下面的ReadLine()才能从最开始读取
            stream.Seek(0, SeekOrigin.Begin);
            x = 0;//二维数据的x轴
            while (reader.ReadLine()?.ToString() != null)
            {
                x++;
            }
            y = 1;//二维数据的Y轴
            //如果csv中没有数据，x则为0，list.count也为0，返回的数组什么也没有
            string[,] array = new string[0, 0];
            if (x != 0 && list.Count > 0)
            {
                y = list.Count / x;
                array = new string[x, y];
                int index = 0;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        array[i, j] = list[index];
                        ++index;
                    }
                }
            }
            reader.Close();
            stream.Close();
            return array;
        }
    }
}
