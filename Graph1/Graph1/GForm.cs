using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


//Раскрасить граф минимальным количеством цветов.

//Каждая вершина должна быть «окрашена» в цвет, отличный от цвета смежных вершин.



namespace Graph1
{
    public partial class GForm : Form
    {
        public GForm()
        {
            InitializeComponent();
        }

        public static readonly int RAD = 15;
        public static Graph TheGraph = new Graph();

        private static Vert A = null, B = null;
        
        private void MagicClick(object sender, MouseEventArgs mouse)
        {
            
            if (AddVertRadio.Checked)
            {
                TheGraph.AddV(mouse.X, mouse.Y);
                DPanel.CreateGraphics().DrawImage(TheGraph.DrawGraph(DPanel.Width, DPanel.Height), new Point(0,0));
            }
            else

            if (AddEdgeRadio.Checked)
            {
                if (A == null)
                {
                    A = TheGraph.OnClick(mouse.X, mouse.Y);
                    if(A != null)
                       InfoLabel.Text = "Choose 2'nd vert";
                    else
                        InfoLabel.Text = "...";

                }
                else if (B == null)
                {
                    B = TheGraph.OnClick(mouse.X, mouse.Y);
                    if (B != null)
                    {
                        TheGraph.AddE(A, B);
                        DPanel.CreateGraphics().DrawImage(TheGraph.DrawGraph(DPanel.Width, DPanel.Height), new Point(0, 0));
                        InfoLabel.Text = "Operation complete";
                    }
                    else
                        InfoLabel.Text = "...";
                    A = B = null;
                }
            } else

            if (DelEdgeRadio.Checked)
            {

                if (A == null)
                {
                    A = TheGraph.OnClick(mouse.X, mouse.Y);
                    if(A != null)
                        InfoLabel.Text = "Choose 2'nd vert";
                    else
                        InfoLabel.Text = "...";

                }
                else
                if (B == null)
                {
                    B = TheGraph.OnClick(mouse.X, mouse.Y);
                    if (B != null)
                    {
                        TheGraph.DelEdge(A, B);
                        DPanel.CreateGraphics().DrawImage(TheGraph.DrawGraph(DPanel.Width, DPanel.Height), new Point(0, 0));
                        InfoLabel.Text = "Operation complete";
                    }
                    else
                        InfoLabel.Text = "...";
                    A = B = null;
                }
            } else

            if(DelVertRadio.Checked)
            {
                A = TheGraph.OnClick(mouse.X, mouse.Y);
                if (A != null)
                {
                    TheGraph.DelVert(A);
                    DPanel.CreateGraphics().DrawImage(TheGraph.DrawGraph(DPanel.Width, DPanel.Height), new Point(0, 0));
                    A = null;
                    InfoLabel.Text = "Operation complete";
                }
                else
                    InfoLabel.Text = "Wrong input"; 
            } else

            if (MoveModeRadio.Checked)
            {
                if (A == null)
                {
                    A = TheGraph.OnClick(mouse.X, mouse.Y);
                    if (A != null)
                        InfoLabel.Text = "Point new location";
                    else
                        InfoLabel.Text = "Wrong input";
                }
                else if (A != null)
                {
                    A.vpoint.X = mouse.X; A.vpoint.Y = mouse.Y;
                    DPanel.CreateGraphics().DrawImage(TheGraph.DrawGraph(DPanel.Width, DPanel.Height), new Point(0, 0));
                    A = null;
                    InfoLabel.Text = "Operation complete";
                }
            }           

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TheGraph.VList = new List<Vert>();
            DPanel.CreateGraphics().Clear(Color.White);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFD.ShowDialog() == DialogResult.OK)
            {
                TheGraph = Graph.FileToGraph(File.ReadAllLines(OpenFD.FileName));
                TheGraph.GetColors();
                DPanel.CreateGraphics().DrawImage(TheGraph.DrawGraph(DPanel.Width, DPanel.Height), new Point(0, 0));
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFD.ShowDialog() == DialogResult.OK)
            {
                string[] info = Graph.GraphToFile(TheGraph);
                File.WriteAllLines(SaveFD.FileName, info);
            }
        }

        private void SolutionButton_Click(object sender, EventArgs e)
        {
            TheGraph.SetBrushes();
            DPanel.CreateGraphics().DrawImage(TheGraph.DrawGraph(DPanel.Width, DPanel.Height), new Point(0, 0));
        }
    }
}
