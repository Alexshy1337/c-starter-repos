using System;
using System.Drawing;
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


        static EList Edges = new EList();
        static EList Vert = new EList();
        Tree bakaut = new Tree();
        public static readonly int MaxDEPTH = 3, BRANCHES = 3, RAD = 8;


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //очистка панели рисования
            DrawingPanel.CreateGraphics().Clear(Color.White);

            //очистка списков (узлы/рёбра), если до этого момента кнопка "сгенерировать" уже была нажата
            Edges = new EList();
            Vert = new EList();

            //генерация дерева
            TNode.GenerateBranches(bakaut.root, MaxDEPTH, BRANCHES);

            //инициализация точки корня для правильной работы алгоритма по нахождению остальных точек
            bakaut.root.tPoint = new Point(DrawingPanel.Width / 2, 15); 

            //получение списков точек узлов/рёбер
            bakaut.GetPoints(bakaut.root, DrawingPanel.Width, DrawingPanel.Height, Edges, Vert);

            //рисование элементов
            DrawingPanel.CreateGraphics().DrawImage(DrawTree(DrawingPanel.Width, DrawingPanel.Height), new Point(0,0));

        }

        //очистка
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DrawingPanel.CreateGraphics().Clear(Color.White);
            Edges = new EList();
            Vert = new EList();
        }

        //ешение задачи
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK)
                Tree.CalcPaths(bakaut, SFD.FileName);
        }


        //рисование
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

            //рисование вершин и индексов
            t = Vert.head;
            while (t != null)
            {
                Rectangle r = new Rectangle(t.p1.X - RAD, t.p1.Y - RAD, 2 * RAD, 2 * RAD);
                g.FillEllipse(Brushes.DarkGreen, r);
                g.DrawString(t.index.ToString(), SystemFonts.DefaultFont, Brushes.White, r, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center } );
                t = t.next;
            }
            return canvas;
        }
    }
}




