using System.Collections.Generic;

namespace Sorting1
{
    class Sorts
    {
        //CC - comparisonsCount, SC - swapsCount
        public static void BubbleSort(int[] arr, int left, int right, ref int CC, ref int SC)
        {
            for (int i = left; i < right; i++)
            {
                for (int j = right; j > i; j--)
                {
                    CC++;
                    if (arr[j - 1] > arr[j])
                    {
                        SC++;
                        int t = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = t;
                    }
                }
            }
        }

        public static int[] ReverseBubbleSort(int[] arr, int left, int right)
        {
            for (int i = left; i < right; i++)
            {
                for (int j = right; j > i; j--)
                {
                    if (arr[j - 1] < arr[j])
                    {
                        int t = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = t;
                    }
                }
            }
            return arr;
        }



        /**
          * Сортирует массив, используя рекурсивную сортировку слиянием
          * up - указатель на массив, который нужно сортировать
          * down - указатель на массив с, как минимум, таким же размером как у 'up', используется как буфер
          * left - левая граница массива, передайте 0, чтобы сортировать массив с начала
          * right - правая граница массива, передайте длину массива - 1, чтобы сортировать массив до последнего элемента
          * возвращает: указатель на отсортированный массив. Из-за особенностей работы данной реализации
          * отсортированная версия массива может оказаться либо в 'up', либо в 'down'
          **/

        //CC - comparisonsCount, SC - swapsCount
        public static int[] FusionSort(int[] up, int[] down, int left, int right, ref int CC, ref int SC)
        {


            if (left == right)
            {
                down[left] = up[left];
                return down;
            }

            int middle = (left + right) / 2;

            // разделяй и властвуй
            int[] l_buff = FusionSort(up, down, left, middle, ref CC, ref SC);
            int[] r_buff = FusionSort(up, down, middle + 1, right, ref CC, ref SC);

            // слияние двух отсортированных половин
            int[] target = l_buff == up ? down : up;

            int l_cur = left, r_cur = middle + 1;
            for (int i = left; i <= right; i++)
            {
                if (l_cur <= middle && r_cur <= right)
                {
                    CC++;
                    if (l_buff[l_cur] < r_buff[r_cur])
                    {
                        SC++;
                        target[i] = l_buff[l_cur];
                        l_cur++;
                    }
                    else
                    {
                        SC++;
                        target[i] = r_buff[r_cur];
                        r_cur++;
                    }
                }
                else if (l_cur <= middle)//не является сравнением, т.к. элементы массива не сравниваются
                {
                    SC++;
                    target[i] = l_buff[l_cur];
                    l_cur++;
                }
                else
                {
                    SC++;
                    target[i] = r_buff[r_cur];
                    r_cur++;
                }
            }
            return target;
        }











        //public int[] MergeSort(int[] array)
        //{
        //    if (array.Length < 2)
        //        return array;

        //    int[] result = new int[array.Length], l = new int[array.Length / 2], r = new int[array.Length / 2 + array.Length % 2];

        //    for (int p = 0; p < array.Length / 2; p++)
        //    {
        //        l[p] = array[p];
        //        r[p] = array[2 * p];

        //    }
        //    if (array.Length % 2 != 0)
        //        r[r.Length - 1] = array[array.Length - 1];



        //    int[] f1 = MergeSort(l), f2 = MergeSort(r);



        //    int i = 0, j = 0, k = 0;
        //    long buf = l[l.Length - 1] + r[r.Length - 1] + 1000;


        //    while (i < l.Length || j < r.Length)
        //    {
        //        if (i < l.Length && j < r.Length)
        //        {
        //            //записываем в результат меньший из 2-х элементов такой, которого еще не было

        //            if (l[i] < r[j] && buf != l[i])
        //            {
        //                buf = l[i];
        //                result[k] = l[i];
        //                i++;
        //            }
        //            else
        //            if (l[i] > r[j] && buf != r[j])
        //            {
        //                buf = r[j];
        //                result[k] = r[j];
        //                j++;
        //            }
        //            else
        //            {
        //                if (buf != l[i])//уже знаем, что элементы массивов при данных индексах равны
        //                {
        //                    buf = l[i];
        //                    result[k] = l[i];
        //                }
        //                i++;
        //                j++;
        //            }
        //            k++;
        //        }
        //        else//если непросмотренные элементы остались только в одном массиве
        //        {
        //            if (l.Length - 1 > i)
        //            {
        //                result[k] = l[i];
        //                i++;
        //                k++;
        //            }
        //            else
        //            if (r.Length > j && buf != r[j])
        //            {
        //                buf = r[j];
        //                result[k] = r[j];
        //                j++;
        //                k++;
        //            }
        //            else j++;
        //        }
        //    }
        //    return result;
        //}










    }
    //mark:
    //goto mark;
}


