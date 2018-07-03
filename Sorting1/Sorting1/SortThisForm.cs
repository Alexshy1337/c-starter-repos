using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Sorting1
{
    public partial class SortThisForm : Form
    {
        private static int[] arr, arr1, arr2;

        public SortThisForm()
        {
            InitializeComponent();
        }

        private void SortThisForm_Load(object sender, EventArgs e)
        {
            InputDGV1.Rows.Clear();
            InputDGV2.Rows.Clear();
            InputDGV1.ColumnHeadersVisible = false;
            InputDGV1.RowHeadersVisible = false;
            InputDGV2.ColumnHeadersVisible = false;
            InputDGV2.RowHeadersVisible = false;


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
            int size = 0;
            int.TryParse(SizeTextBox.Text, out size);
            int BCC = 0, BSC = 0, FCC = 0, FSC = 0;
            MainChart.Series[0].Points.Clear();
            MainChart.Series[1].Points.Clear();
            if(CompCountRadio.Checked)
            {
                for (int i = 0; i < size; i++)
                {
                    int[] ar = new int[i + 1];
                    arr = Utils.ArrHelper.GenArr(i + 1);
                    arr = Sorts.FusionSortComparable(arr, ar, 0, ar.Length - 1, ref FCC, ref FSC);
                    arr = Utils.ArrHelper.GenArr(i + 1);
                    arr = Sorts.BubbleSortComparable(arr, 0, arr.Length - 1, ref BCC, ref BSC);
                    MainChart.Series[0].Points.AddXY(i, BCC);
                    MainChart.Series[1].Points.AddXY(i, FCC);
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    int[] ar = new int[i + 1];
                    arr = Utils.ArrHelper.GenArr(i + 1);
                    arr = Sorts.FusionSortComparable(arr, ar, 0, ar.Length - 1, ref FCC, ref FSC);
                    arr = Utils.ArrHelper.GenArr(i + 1);
                    arr = Sorts.BubbleSortComparable(arr, 0, arr.Length - 1, ref BCC, ref BSC);
                    MainChart.Series[0].Points.AddXY(i, BSC);
                    MainChart.Series[1].Points.AddXY(i, FSC);
                }
            }
        }
    

        private void SortButton_Click_1(object sender, EventArgs e)
        {
            if (FusionRadio.Checked)
            {
                if(NumForDGV2.Value != 0)
                {
                    //FusionSortForTask
                    int[] ar = new int[(int)NumForDGV1.Value];
                    arr1 = Sorts.FusionSortForTask(arr1, arr2, ar);
                    Utils.DGVHelper.FillDGV(InputDGV1, arr1);
                }
                else
                {
                    int[] ar = new int[(int)NumForDGV1.Value];
                    arr1 = Sorts.FusionSort(arr1, ar, 0, arr1.Length - 1);
                    Utils.DGVHelper.FillDGV(InputDGV1, arr1);
                }
            }
            else if (BubbleRadio.Checked)
            {
                arr1 = Sorts.BubbleSort(arr1, 0, arr.Length - 1);
                Utils.DGVHelper.FillDGV(InputDGV1, arr1);
            }
        }
    }
}


//15. Путем слияния из возрастающего A(M) и невозрастающего B(N)
// массивов получить возрастающий массив C (с удалением совпадающих элементов)(задание 12)


// следующая задача мод альфа - №5 сортировкой шелла  
