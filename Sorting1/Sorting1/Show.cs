using System.Drawing;
using System.Collections.Generic;


namespace Sorting1
{
    public class Show
    {
        private readonly static int _in_radius_ = 19, _space_radius_ = 7, _border_radius_ = 22;
        private readonly static StringFormat elementStringFormat = new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };


        public enum HighlightType
        {
            Swapping, Comparing, Default
        }

        private static Dictionary<HighlightType, Brush> HighlightsDict = new Dictionary<HighlightType, Brush>()
        {
            { HighlightType.Swapping, Brushes.ForestGreen },
            { HighlightType.Comparing, Brushes.Crimson },
            { HighlightType.Default, Brushes.Aquamarine }
        };


        public static Bitmap DrawArrayToBitmap
            
            (int canvas_width, int canvas_height,
                
                int[] arr, HashSet<int> highlighted, 
                
                    HighlightType HType = HighlightType.Default )

        {
            Bitmap canvas = new Bitmap(canvas_width, canvas_height);
            Graphics canvasGr = Graphics.FromImage(canvas);
            canvasGr.Clear(Color.White);


            for (int i = 0; i < arr.Length; i++)
            {

                HighlightType currentElementHightlight = 
                    
                        (highlighted != null && highlighted.Contains(i))? HType : HighlightType.Default;


                Brush BorderBrush = HighlightsDict[currentElementHightlight];


                Point pos = GetElemPos(canvas_width, canvas_height, i);


                Rectangle rectangle = new Rectangle

                    (pos.X - _in_radius_, pos.Y - _in_radius_, _in_radius_ * 2, _in_radius_ * 2),
                    
                    borderRectangle = new Rectangle
                    
                    (pos.X - _border_radius_, pos.Y - _border_radius_, _border_radius_ * 2, _border_radius_ * 2);


                canvasGr.FillEllipse(BorderBrush, borderRectangle);
                canvasGr.FillEllipse(Brushes.Aquamarine, rectangle);

                canvasGr.DrawString
                    
                    (arr[i].ToString(), SystemFonts.DefaultFont, Brushes.Black, rectangle, elementStringFormat);


            }

            return canvas;
        }

        public static Point GetElemPos(int canvas_width, int canvas_height, int i/*, bool IsFirst*/)
        {
            int el_size = _space_radius_ + _in_radius_,
                Elem_InRow = canvas_width / (el_size * 2),

                x = (2 * (i % Elem_InRow) + 1) * el_size,
                y = (2 * (i / Elem_InRow) + 1) * el_size;


            return new Point(x, y);
        }
    }
}
















/*        public int[] SolutionMergeSort(int[] Sorted, int[] NonIncreasing)
{
    int[] result = new int[Sorted.Length + NonIncreasing.Length];//Sorted - строго возрастающий массив, NonIncreasing - нестрого убывающий массив.

    int i = 0, j = NonIncreasing.Length - 1, k = 0; 

    long buf = Sorted[Sorted.Length-1] + NonIncreasing[0] + 1000;//buf должно иметь начальное значение, которое не встречается ни в одном из массивов

    while (i < Sorted.Length - 1 || j > 0)//пока хоть в одном массиве есть непросмотренные элементы
    {
        if (i < Sorted.Length - 1 && j > 0)//если в обоих массивах есть непросмотренные элементы
        {

            //записываем в результат меньший из 2-х элементов такой, которого еще не было

            if (Sorted[i] < NonIncreasing[j] && buf != Sorted[i])
            {
                buf = Sorted[i];
                result[k] = Sorted[i];
                i++;
            }
            else
            if (Sorted[i] > NonIncreasing[j] && buf != NonIncreasing[j])
            {
                buf = NonIncreasing[j];
                result[k] = NonIncreasing[j];
                j--;
            }
            else
            {
                if (buf != Sorted[i])//уже знаем, что элементы массивов при данных индексах равны
                {
                    buf = Sorted[i];
                    result[k] = Sorted[i];
                }
                i++;
                j--;
            }
            k++;
        }
        else//если непросмотренные элементы остались только в одном массиве
        {
            if(Sorted.Length - 1 > i)
            {
                result[k] = Sorted[i];
                i++;
                k++;
            } else
            if (j > 0 && buf != NonIncreasing[j])
            {
                buf = NonIncreasing[j];
                result[k] = NonIncreasing[j];
                j--;
                k++;
            }
            else j--;
        }
    }
    return result;
}




List<Bitmap> animation = new List<Bitmap>();
int currentFrame = 0;
void DrawCurrentFrame()
{
if(currentFrame == 0 || currentFrame >= animation.Count)
{...return;}
CreateGraphics().DrawImage(animation[currentFrame], 0, 0)
}

void CreateAnimation_Click()
{
animation = animate(900,600,15);
}

void DrawNextFrame_click(...)
{
DrawCurrentFrame();
current++;
}


void TimerTick(...)//требуется добавить таймер на формочку
{
DrawNextFrame();
currentFrame++;
if (currentFrame > animation.Count)
currentFrame = 0;
}

void StartStop_Click(...)
{
timer.Enabled =!

.........
.........

}

List<Bitmap> SortAnim(/?/)
{
result....

for(..)
for(..)
{
result.Add(DrawCompare(a,i,j))
if(a[i]<a[j])
{
a[i] <-> a[j];
result.Add(DrawChange(a,i,j));
}
result.Add(DrawArray(a));
}
result.Add(DrawArray(a));

DrawArray(a) Bitmap b = new Bitmap();
for (0 -> a.Length)
{
Pen c = Pen black;
b.DrawEllipse(params(?))





}



*/