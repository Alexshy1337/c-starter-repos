using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Sorting1
{
    public partial class SortThisForm : Form
    {
        private static int[] arr1, arr2;

        public SortThisForm()
        {
            InitializeComponent();
        }

        private void SortThisForm_Load(object sender, EventArgs e)
        {
            InputDGV1.RowCount = 1;
            InputDGV1.ColumnCount = 1;
            InputDGV2.RowCount = 1;
            InputDGV2.ColumnCount = 1;
        }

        private void NumForDGV1_ValueChanged(object sender, EventArgs e)
        {
            if (NumForDGV1.Value != 0)
                InputDGV1.RowCount = (int)(NumForDGV1.Value);
            else InputDGV1.Rows.Clear();
        }

        private void NumForDGV2_ValueChanged(object sender, EventArgs e)
        {
            if (NumForDGV2.Value != 0)
                InputDGV2.RowCount = (int)(NumForDGV2.Value);
            else InputDGV2.Rows.Clear();
        }

        private void FillButton_Click_1(object sender, EventArgs e)
        {

            if (NumForDGV1.Value != 0)
            {
                if (FromSourceCheck.Checked)
                {
                    arr1 = Utils.DGVHelper.InputFromDGV(InputDGV1);
                    arr2 = Utils.DGVHelper.InputFromDGV(InputDGV2);
                }
                else
                {
                    arr1 = Utils.ArrHelper.GenArr((int)NumForDGV1.Value);
                    arr2 = Utils.ArrHelper.GenArr((int)NumForDGV2.Value);
                    Utils.DGVHelper.FillDGV(InputDGV1, arr1);
                    arr2 = Sorts.ReverseBubbleSort(arr2, 0, arr2.Length - 1);
                    Utils.DGVHelper.FillDGV(InputDGV2, arr2);
                }
            }
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            NumForDGV1.Value = 0;
            NumForDGV2.Value = 0;
        }

        private void MixButton_Click_1(object sender, EventArgs e)
        {
            Utils.ArrHelper.ShuffleArr(arr1);
            Utils.DGVHelper.FillDGV(InputDGV1, arr1);
            Utils.ArrHelper.ShuffleArr(arr2);
            Utils.DGVHelper.FillDGV(InputDGV2, arr2);
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            int size = (int)NUDC.Value;
            List<Point> l = new List<Point>();
            int FCC = 0, FSC = 0;
            int[] ar = new int[(int)NumForDGV1.Value];
            arr1 = Sorts.FusionSort(arr1, ar, 0, ar.Length - 1, ref FCC, ref FSC);
            //NUDC

            FCC = 0; FSC = 0;
            Utils.DGVHelper.FillDGV(InputDGV1, arr1);
            //MainChart.ChartAreas[0].
            MainChart.Series[0].Points.Add(new Point());
        }
    

        private void SortButton_Click_1(object sender, EventArgs e)
        {
            int BCC = 0, BSC = 0, FCC = 0, FSC = 0;
            if (FusionRadio.Checked)
            {
                int[] ar = new int[(int)NumForDGV1.Value];
                arr1 = Sorts.FusionSort(arr1, ar, 0, ar.Length - 1, ref FCC, ref FSC);
                Utils.DGVHelper.FillDGV(InputDGV1, arr1);
            }
            else if (BubbleRadio.Checked)
            {
                //
            }
        }
    }
}


//15. Путем слияния из возрастающего A(M) и невозрастающего B(N)
// массивов получить возрастающий массив C (с удалением совпадающих элементов)(задание 12)


// следующая задача мод альфа - №5 сортировкой шелла  
