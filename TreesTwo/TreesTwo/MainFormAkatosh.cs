using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TreesTwo
{
    public partial class MainFormAkatosh : Form
    {
        //initialisation
        public MainFormAkatosh()
        {
            InitializeComponent();
            ed[0] = new List<Point>();
            ed[1] = new List<Point>();
        }

        public List<Point> points = new List<Point>();
        public List<Point>[] ed = new List<Point>[2];
        public BinaryTree aT = new BinaryTree(), bT = new BinaryTree(), cT = new BinaryTree(), dT = new BinaryTree(), compLeft = null, compRight = null;
        private static readonly double chance = 0.7;
        public static readonly int MaxDEPTH = 5, RAD = 12;
        public Random rnd = new Random();
        //initialisation


        //осуществление выбора 2-х деревьев, которые предстоит сравнивать через клик по элементу Panel с соответствующим рисунком дерева
        private void Tree1Check(object sender, MouseEventArgs e)
        {
            if (compLeft == null && compRight == null)
            {
                compLeft = aT;
                CompLabelLeft.Text = "1";
            }
            else if (compRight == null)
            {
                compRight = aT;
                CompLabelRight.Text = "1";
            }
            else
            {
                compLeft = aT;
                CompLabelLeft.Text = "1";
                CompLabelRight.Text = "";
                compRight = null;
            }
        }
        private void Tree2Check(object sender, MouseEventArgs e)
        {
            if (compLeft == null && compRight == null)
            {
                compLeft = bT;
                CompLabelLeft.Text = "2";
            }
            else if (compRight == null)
            {
                compRight = bT;
                CompLabelRight.Text = "2";
            }
            else
            {
                compLeft = bT;
                CompLabelLeft.Text = "2";
                CompLabelRight.Text = "";
                compRight = null;
            }
        }
        private void Tree3Check(object sender, MouseEventArgs e)
        {
            if (compLeft == null && compRight == null)
            {
                compLeft = cT;
                CompLabelLeft.Text = "3";
            }
            else if (compRight == null)
            {
                compRight = cT;
                CompLabelRight.Text = "3";
            }
            else
            {
                compLeft = cT;
                CompLabelLeft.Text = "3";
                CompLabelRight.Text = "";
                compRight = null;
            }
        }
        private void Tree4Check(object sender, MouseEventArgs e)
        {
            if (compLeft == null && compRight == null)
            {
                compLeft = dT;
                CompLabelLeft.Text = "4";
            }
            else if (compRight == null)
            {
                compRight = dT;
                CompLabelRight.Text = "4";
            }
            else
            {
                compLeft = dT;
                CompLabelLeft.Text = "4";
                CompLabelRight.Text = "";
                compRight = null;
            }
        }

        //очистка панелей
        private void ClrButton_Click(object sender, EventArgs e)
        {
            Tree1.CreateGraphics().Clear(Color.White);
            Tree2.CreateGraphics().Clear(Color.White);
            Tree3.CreateGraphics().Clear(Color.White);
            Tree4.CreateGraphics().Clear(Color.White);
        }

        //сравнить
        private void CompButton_Click(object sender, EventArgs e)
        {
            bool be = true;
            BinaryTree.CompareTrees(compLeft, compRight, ref be);
            if (be)
            {
                AnsLabel.Text = CompLabelLeft.Text + " and " + CompLabelRight.Text + " are equal";
                CompLabelLeft.Text = "";
                CompLabelRight.Text = "";
                compRight = compLeft = null;
            }
            else
            {
                AnsLabel.Text = CompLabelLeft.Text + " and " + CompLabelRight.Text + " are different";
                CompLabelLeft.Text = "";
                CompLabelRight.Text = "";
                compRight = compLeft = null;
            }
        }

        //сгенерировать 3 дерева, 2 равных дерева нарисовать в двух верхних панелях
        private void GenButton_Click(object sender, EventArgs e)
        {
            aT.GTree(aT.root, chance, MaxDEPTH, rnd);
            aT.GetPoints(aT.root, Tree1.Width, Tree1.Height, points, ed);
            Tree1.CreateGraphics().DrawImage(aT.Draw(Tree1.Width, Tree1.Height, points, ed), new Point(0, 0));
            bT = aT;
            Tree2.CreateGraphics().DrawImage(bT.Draw(Tree2.Width, Tree2.Height, points, ed), new Point(0, 0));
            points = new List<Point>();
            ed[0] = new List<Point>();
            ed[1] = new List<Point>();
            cT.GTree(cT.root, chance, MaxDEPTH, rnd);
            cT.GetPoints(cT.root, Tree1.Width, Tree1.Height, points, ed);
            Tree3.CreateGraphics().DrawImage(cT.Draw(Tree3.Width, Tree3.Height, points, ed), new Point(0, 0));
            points = new List<Point>();
            ed[0] = new List<Point>();
            ed[1] = new List<Point>();
            dT.GTree(dT.root, chance, MaxDEPTH, rnd);
            dT.GetPoints(dT.root, Tree1.Width, Tree1.Height, points, ed);
            Tree4.CreateGraphics().DrawImage(dT.Draw(Tree4.Width, Tree4.Height, points, ed), new Point(0, 0));
            points = new List<Point>();
            ed[0] = new List<Point>();
            ed[1] = new List<Point>();
        }
    }
}
