using System.Collections.Generic;

namespace Sorting1
{
    class Sorts
    {
        public static int[] FusionSort(int[] arr, out SortReport report, int[] ar = null)
        {
            return MergeSortImplementation(false, 0, 0, arr, ar, 0, arr.Length + ar.Length - 1, out report);
        }



        public static int[] FusionSortRender(int[] arr, int canvasWidth, int canvasHeight, 
            
            out SortReport report, int[] ar = null)
        {
            return MergeSortImplementation(true, canvasWidth, canvasHeight,

                arr, ar, 0, arr.Length + ar.Length - 1, out report);
        }



        public static void BubbleSort(int[] arr, out SortReport report)
        {
            BubbleSortImplementation(false, 0, 0, arr, 0, arr.Length - 1, out report);
        }

        public static void BubbleSortRender(int canvasWidth, int canvasHeight, int[] arr, out SortReport report)
        {
            BubbleSortImplementation(true, canvasWidth, canvasHeight, arr, 0, arr.Length - 1, out report);
        }

        private static void BubbleSortImplementation

            (bool render, int canvasWidth, int canvasHeight, int[] arr, int left, int right, out SortReport report)

        {
            report = (render) ? new SortReport(canvasWidth, canvasHeight) : new SortReport();

            for (int i = left; i < right; i++)
                for (int j = right; j > i; j--)
                {
                    if (Compare(arr, j, j - 1, report) == -1)
                        Swap(arr, j, j - 1, report);
                }
        }

        private static int Compare(int[] arr, int index1, int index2, SortReport report)
        {
            report.ComparisonsCount++;

            if (report.Render)
                RenderComparison(arr, index1, index2, report);

            return (arr[index1] == arr[index2]) ? 0
                : (arr[index1] > arr[index2]) ? 1 : -1;
        }


        private static void Swap(int[] arr, int index1, int index2, SortReport report)
        {
            report.SwapsCount++;

            if (report.Render)
                RenderSwap(arr, index1, index2, report);

            int t = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = t;

            if (report.Render)
                RenderComparison(arr, index1, index2, report);
        }

        private static void RenderComparison(int[] arr, int index1, int index2, SortReport report)
        {
            report.Frames.Add(Show.DrawArrayToBitmap(report.CanvasWidth, report.CanvasHeight, arr,
                new HashSet<int>() { index1, index2 }, Show.HighlightType.Comparing));
        }

        private static void RenderSwap(int[] arr, int index1, int index2, SortReport report)
        {
            report.Frames.Add(Show.DrawArrayToBitmap(report.CanvasWidth, report.CanvasHeight, arr,
                new HashSet<int>() { index1, index2 }, Show.HighlightType.Swapping));
        }



        private static int CompareF(int one, int two, SortReport report)
        {
            report.ComparisonsCount++;

            if (report.Render)
                RenderComparisonF(one, two, report);

            return (one == two) ? 0
                : (one > two) ? 1 : -1;

        }



        private static void RenderComparisonF(int one, int two, SortReport report)
        {


    //        report.Frames.Add(Show.DrawArrayToBitmap(report.CanvasWidth, report.CanvasHeight, arr,
    //new HashSet<int>() { one, two }, Show.HighlightType.Comparing));

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

        private static int[] MergeSortImplementation
            
            (bool render, int canvasWidth, int canvasHeight,
                
                int[] up, int[] down, int left, int right, out SortReport report)

        {

            report = (render) ? new SortReport(canvasWidth, canvasHeight) : new SortReport();


            if (left == right)
            {
                down[left] = up[left];
                return down;
            }

            int middle = (left + right) / 2;

            // разделяй и властвуй
            int[] l_buff = MergeSortImplementation(render, 0, 0, up, down, left, middle, out report);
            int[] r_buff = MergeSortImplementation(render, 0, 0, up, down, middle + 1, right, out report);

            // слияние двух отсортированных половин
            int[] target = l_buff == up ? down : up;

            int l_cur = left, r_cur = middle + 1;
            for (int i = left; i <= right; i++)
            {
                if (l_cur <= middle && r_cur <= right)//Compare(arr, j, j - 1, report) == -1
                {
                    if (l_buff[l_cur] < r_buff[r_cur])
                    {
                        target[i] = l_buff[l_cur];
                        l_cur++;
                    }
                    else
                    {
                        target[i] = r_buff[r_cur];
                        r_cur++;
                    }
                }
                else if (l_cur <= middle)
                {
                    target[i] = l_buff[l_cur];
                    l_cur++;
                }
                else
                {
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



    public class SortReport
    {
        public int ComparisonsCount;
        public int SwapsCount;

        public bool Render;

        public int CanvasWidth;
        public int CanvasHeight;

        public DLList Frames;

        public SortReport()
        {
            Render = false;
            CanvasWidth = CanvasHeight = 0;
            Frames = null;
        }

        public SortReport(int canvasWidth, int canvasHeight)
        {
            Render = true;
            CanvasWidth = canvasWidth;
            CanvasHeight = canvasHeight;

            Frames = new DLList();
        }
    }


    //mark:
    //goto mark;
}


