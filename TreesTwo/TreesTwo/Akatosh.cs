using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreesTwo
{
    public partial class Akatosh : Form
    {
        public Akatosh()
        {
            InitializeComponent();
        }

        public List<Point> points = new List<Point>();
        public List<Point>[] ed = new List<Point>[2];
        public BinaryTree aT = new BinaryTree(), bT = new BinaryTree(), cT = new BinaryTree(), dT = new BinaryTree(), compLeft = null, compRight = null;
        private static readonly double chance = 0.7;
        public static readonly int MaxDEPTH = 5, RAD = 12;

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
                compRight = null;
            }
        }

        private void ClrButton_Click(object sender, EventArgs e)
        {
            Tree1.CreateGraphics().Clear(Color.White);
            Tree2.CreateGraphics().Clear(Color.White);
            Tree3.CreateGraphics().Clear(Color.White);
            Tree4.CreateGraphics().Clear(Color.White);
            points = new List<Point>();
            
        }

        private void CompButton_Click(object sender, EventArgs e)
        {
            if(BinaryTree.CompareTrees(compLeft, compRight))
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

        private void GenButton_Click(object sender, EventArgs e)
        {
            //aT.root = new BTNode();
            //cT.root = new BTNode();
            //dT.root = new BTNode();
            aT.GTree(aT.root, chance);
            ;
            aT.GetPoints(aT.root, Tree1.Width, Tree1.Height, points, ed);
            ;
            Tree1.CreateGraphics().DrawImage(aT.Draw(Tree1.Width, Tree1.Height, points, ed), new Point(0, 0));
            //bT.GTree(bT.root, chance);
            //bT.GetPoints();
            bT = aT;
            Tree2.CreateGraphics().DrawImage(bT.Draw(Tree2.Width, Tree2.Height, points, ed), new Point(0, 0));
            cT.GTree(cT.root, chance);
            cT.GetPoints(cT.root, Tree1.Width, Tree1.Height, points, ed);
            Tree3.CreateGraphics().DrawImage(cT.Draw(Tree3.Width, Tree3.Height, points, ed), new Point(0, 0));
            dT.GTree(dT.root, chance);
            dT.GetPoints(dT.root, Tree1.Width, Tree1.Height, points, ed);
            Tree4.CreateGraphics().DrawImage(dT.Draw(Tree4.Width, Tree4.Height, points, ed), new Point(0, 0));
        }
    }
}
