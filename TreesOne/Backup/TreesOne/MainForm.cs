using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





//Дано упорядоченное дерево глубины N(> 0), 
//каждая внутренняя вершина которого имеет 
//К(< 9) непосредственных потомков, которые
//нумеруются от 1 до К. Корень дерева имеет 
//номер 0. Записать в текстовый файл все пути,
//ведущие от корня к листьям и удовлетворяющие 
//следующему условию: никакие соседние элементы 
//пути не нумеруются одной и той же цифрой.
//Каждый путь записывается в отдельной строке
//файла. Порядок перебора путей — тот же, что в задании 1.







namespace TreesOne
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static EList Edges = new EList();
        public static EList Vert = new EList();
        //public int indicator = 0;
        Tree bakaut = new Tree();
        public static readonly int MaxDEPTH = 6, MaxBRANCHES = 4, RAD = 10;


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Vert.indicator = new int[MaxDEPTH];
            for(int i = 0; i < MaxDEPTH; i++)
                Vert.indicator[i] = 0;

            TNode.GenerateBranches(bakaut.root, MaxDEPTH, MaxBRANCHES, DrawingPanel.Width, DrawingPanel.Height, ref Edges, ref Vert, 0);
            bakaut.depth = MaxDEPTH;
            DrawingPanel.CreateGraphics().DrawImage(DrawTree(DrawingPanel.Width, DrawingPanel.Height), new Point(0,0));

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DrawingPanel.CreateGraphics().Clear(Color.White);
            Edges = new EList();
            Vert = new EList();
            //string a = "1\n2\n3\n4\n5";
            //if (SFD.ShowDialog() == DialogResult.OK)
            //    File.WriteAllText(SFD.FileName, a);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK)
                Tree.CalcPaths(bakaut, SFD.FileName);
        }


        public static Bitmap DrawTree(int canvasWidth, int canvasHeight)
        {
            Bitmap canvas = new Bitmap(canvasWidth, canvasHeight);

            Graphics g = Graphics.FromImage(canvas);
            g.Clear(Color.White);

            //рисование рёбер
            ENode t = Edges.head;
            while(t != null)
            {
                g.DrawLine(Pens.Black, t.p1, t.p2);
                t = t.next;
            }
            // && t.next != null


            //рисование вершин
            t = Vert.head;
            while (t != null)
            {
                Rectangle r = new Rectangle(t.p1.X - RAD, t.p1.Y - RAD, 2 * RAD, 2 * RAD);
                g.FillEllipse(Brushes.Blue, r);
                t = t.next;
            }
            // && t.next != null


            return canvas;
        }






        //public static Point CalcPos(int canvasWidth, int canvasHeight, TNode n)
        //{
        //    int x = 0, y = n.level * canvasHeight / MaxDEPTH + 5;

        //    if (n.Parent != null)
        //    {
        //        if (n.Parent.tPoint.X < canvasWidth / 2)
        //        {
        //            int step = 2 * n.Parent.tPoint.X / n.Parent.Branches.Length;
        //            x = step * (n.index - 1) + 1;
        //        }
        //        else
        //        if (n.Parent.tPoint.X > canvasWidth / 2)
        //        {
        //            int step = 2 * (canvasWidth - n.Parent.tPoint.X) / n.Parent.Branches.Length;
        //            x = canvasWidth - 2 * (canvasWidth - n.Parent.tPoint.X) + step * (n.index - 1) + 1;
        //        }
        //        else
        //        if (n.Parent.tPoint.X == canvasWidth / 2)
        //        {
        //            int step = canvasWidth / n.Parent.Branches.Length;
        //            x = step * (n.index - 1) + 1;
        //        }
        //    }
        //    else x = canvasWidth / 2;


        //    return new Point(x, y);
        //}
















    }
}




