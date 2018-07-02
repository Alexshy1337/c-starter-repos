using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Sorting1
{
    public partial class SortThisForm : Form
    {
        private static int[] arr;

        public SortThisForm()
        {
            InitializeComponent();
        }

        private void SortThisForm_Load(object sender, System.EventArgs e)
        {
            InputDGV1.RowCount = 1;
            InputDGV1.ColumnCount = 1;
        }

        private void UpDownForDGV_ValueChanged(object sender, System.EventArgs e)
        {
            if (NumForDGV1.Value != 0)
                InputDGV1.RowCount = (int)(NumForDGV1.Value);
            else InputDGV1.Rows.Clear();
        }

        private void FillButton_Click(object sender, System.EventArgs e)
        {

            if (NumForDGV1.Value != 0)
            {
                if (FromSourceCheck.Checked)
                {
                    arr = Utils.DGVHelper.InputFromDGV(InputDGV1);
                }
                else
                {
                    arr = Utils.ArrHelper.GenArr((int)NumForDGV1.Value);
                    Utils.DGVHelper.FillDGV(InputDGV1, arr);
                }
            }
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            NumForDGV1.Value = 0;
        }

        private void MixButton_Click(object sender, System.EventArgs e)
        {
            Utils.ArrHelper.ShuffleArr(arr);
            Utils.DGVHelper.FillDGV(InputDGV1, arr);
        }

        private void Exit_MenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Open_MenuItem_Click(object sender, System.EventArgs e)
        {
            if (OpenFileDlg.ShowDialog() != DialogResult.OK)
                return;
            arr = Utils.ArrHelper.StringToArr(File.ReadAllText(OpenFileDlg.FileName));
            Utils.DGVHelper.FillDGV(InputDGV1, arr);
            NumForDGV1.Value = arr.Length;
        }

        private void DemoButton_Click(object sender, System.EventArgs e)
        {
            if (NumForDGV1.Value != 0)
            {
                Bitmap map = Sorting1.Show.DrawArrayToBitmap
                    
                    (Tab_Demo.Width, Tab_Demo.Height, arr, new HashSet<int>(), Sorting1.Show.HighlightType.Comparing);


                Tab_Demo.CreateGraphics().DrawImage(map, 0, 0);
            }
        }

        private void SortButton_Click(object sender, System.EventArgs e)
        {

        }

        private void NumForDGV2_ValueChanged(object sender, System.EventArgs e)
        {
            if (NumForDGV2.Value != 0)
                InputDGV2.RowCount = (int)(NumForDGV2.Value);
            else InputDGV2.Rows.Clear();
        }
    }
}


//15. Путем слияния из возрастающего A(M) и невозрастающего B(N)
// массивов получить возрастающий массив C (с удалением совпадающих элементов)(задание 12)


// следующая задача мод альфа - №5 сортировкой шелла  
