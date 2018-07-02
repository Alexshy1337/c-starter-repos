using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sorting1
{
    public class Utils
    {


        public class MessageHelper
        {
            public static void MSG(string text)
            {
                MessageBox.Show(text);
            }
            public static void ErrorMSG(string text)
            {
                MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public class DGVHelper
        {
            public static void FillDGV(DataGridView dgv, int[] a)
            {
                dgv.Rows.Clear();
                dgv.RowCount = a.Length;
                dgv.ColumnCount = 1;
                for(int i = 0; i < dgv.RowCount; i++)
                    dgv[0, i].Value = a[i]; 
            }

            public static int[] InputFromDGV(DataGridView dgv)
            {
                int[] a = new int[dgv.RowCount];
                for (int i = 0; i < dgv.RowCount; i++)
                    a[i] = Convert.ToInt32(dgv[0, i].Value);
                return a;
            }

        }

        public class ArrHelper
        {
            static Random p = new Random();

            public static int[] GenArr(int size, int min = -100, int max = 100)
            {
                int[] a = new int[size];
                for (int i = 0; i < size; i++)
                    a[i] = p.Next(min, max);
                return a;
            }

            public static void ShuffleArr(int[] a)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    int RandomIndex = p.Next(i, a.Length - 1), l = 0;
                    l = a[i];
                    a[i] = a[RandomIndex];
                    a[RandomIndex] = l;
                }
            }

            public static int[] StringToArr (string s)
            {
                string[] o = s.Split(' ');
                int[] a = new int[o.Length];
                for (int i = 0; i < o.Length; i++)
                    a[i] = int.Parse(o[i]);
                return a;
            }
        }

        /*
        public class FilesHelper
        {
            public static string FileToStr(string path)
            {
                return File.ReadAllText(path);
            }

            public static string[] 
            
        }
        */


    }
}
