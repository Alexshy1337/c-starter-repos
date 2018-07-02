using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    class FilesClass
    {



        /*
         
                 public static void SaveTheInfo(string[] info)
        {
            FileStream fs = new FileStream("save.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < info.Length; i++)           
                sw.WriteLine(info[i]);
            sw.Close();
            fs.Close();
        }
        public static string[] LoadTheInfo()
        {
            FileStream fs = new FileStream("save.txt",FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] info = new string[3];
            int i = 0;
            while(!sr.EndOfStream)
            {
                info[i] = sr.ReadLine();
                i++;
            }
            sr.Close();
            fs.Close();
            return info;
        }
        public static int[] GetCoords(string str)
        {
            string[] coords = str.Split(',');
            int[] coord = new int[2];
            coord[0] = Convert.ToInt32(coords[0]);
            coord[1] = Convert.ToInt32(coords[1]);
            return coord;
        }
        public static int[] GetTheVerticles(string str)
        {
            string[] values = str.Split(',');
            int[] value = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
                value[i] = Convert.ToInt32(values[i]);
            return value;
        }
        public static int[] GetEdges(string str)
        {
            int a = (int)Char.GetNumericValue(str[0]);
            int b = (int)Char.GetNumericValue(str[1]);
            int[] array = { a, b };
            return array;
        }
    
         
         */




    }
}
