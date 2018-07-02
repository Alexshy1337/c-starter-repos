using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    public class Graph
    {
        public List<Vert> VList;
        
        public Graph()
        {
            VList = new List<Vert>();
        }

        public void AddV(int x, int y)
        {
            VList.Add(new Vert(x, y));
            VList[VList.Count - 1].index = VList.Count;
        }

        public void AddV(Point f)
        {
            VList.Add(new Vert(f));
            VList[VList.Count - 1].index = VList.Count;
        }

        public void AddE(Vert A, Vert B)
        {
            if (A != B && !A.IncVerts.Contains(B))
            {
                A.IncVerts.Add(B);
                B.IncVerts.Add(A);
            }
        }

        public void DelVert(Vert p)
        {
            VList.Remove(p);
            for(int i = 0; i < VList.Count; i++)
                if (VList[i].IncVerts.Contains(p))
                    VList[i].IncVerts.Remove(p);
        }

        public void DelEdge(Vert c, Vert d)
        {
            c.IncVerts.Remove(d);
            d.IncVerts.Remove(c);
        }

        public Vert OnClick(int x, int y)
        {
            for (int i = 0; i < VList.Count; i++)
            {
                int X = VList[i].vpoint.X;
                int Y = VList[i].vpoint.Y;
                if (X + GForm.RAD > x && Y + GForm.RAD > y && X - GForm.RAD < x && Y - GForm.RAD < y)
                    return VList[i];
            }
            return null;
        }

        public Bitmap DrawGraph(int width, int height)
        {
            Bitmap c = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(c);
            g.Clear(Color.White);
            StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            for (int i = 0; i < VList.Count; i++)
                for (int j = 0; j < VList[i].IncVerts.Count; j++)
                    g.DrawLine(Pens.Black, VList[i].IncVerts[j].vpoint, VList[i].vpoint);

            for(int i = 0; i < VList.Count; i++)
            {
                Rectangle r = new Rectangle(VList[i].vpoint.X - GForm.RAD, VList[i].vpoint.Y - GForm.RAD, GForm.RAD * 2, GForm.RAD * 2);
                g.FillEllipse(VList[i].currentcolor, r);
                g.DrawString(VList[i].index.ToString(), SystemFonts.DefaultFont, Brushes.Black, VList[i].vpoint.X, VList[i].vpoint.Y, sf);
            }
            return c;
        }

        public void SetBrushes()
        {
            VList.Sort();
            VList.Reverse();
            int _color = 0;
            bool end = false;

            foreach (Vert item in VList)
            {
                item.color = -1;
                item.visited = false;
            }

            while (!end)
            {
                int i = -1;
                end = true;

                while (i < VList.Count - 1 && end)
                    end = VList[++i].visited;

                if (!end)
                {
                    VList[i].color = _color;
                    VList[i].visited = true;

                    for (int j = 0; j < VList.Count; j++)
                        if (!VList[j].visited)
                        {
                            bool ok = true;

                            foreach (Vert item in VList[j].IncVerts)
                            if (item.color == _color)
                            {
                                ok = false;
                                break;
                            }

                            if (ok)
                            {
                                VList[j].color = _color;
                                VList[j].visited = true;
                            }
                        }
                }
                _color++;
            }


            for (int i = 0; i < VList.Count; i++)
            {
                switch (VList[i].color)
                {
                    case 0:
                        VList[i].currentcolor = Brushes.Red;
                        break;
                    case 1:
                        VList[i].currentcolor = Brushes.Orange;
                        break;
                    case 2:
                        VList[i].currentcolor = Brushes.Yellow;
                        break;
                    case 3:
                        VList[i].currentcolor = Brushes.Green;
                        break;
                    case 4:
                        VList[i].currentcolor = Brushes.LightBlue;
                        break;
                    case 5:
                        VList[i].currentcolor = Brushes.Blue;
                        break;
                    case 6:
                        VList[i].currentcolor = Brushes.Purple;
                        break;
                    case 7:
                        VList[i].currentcolor = Brushes.Turquoise;
                        break;
                    default:
                        VList[i].currentcolor = Brushes.Gray;
                        break;
                }
            }

        }

        public void GetColors()
        {
            for (int i = 0; i < VList.Count; i++)
            {
                switch (VList[i].color)
                {
                    case 0:
                        VList[i].currentcolor = Brushes.Red;
                        break;
                    case 1:
                        VList[i].currentcolor = Brushes.Orange;
                        break;
                    case 2:
                        VList[i].currentcolor = Brushes.Yellow;
                        break;
                    case 3:
                        VList[i].currentcolor = Brushes.Green;
                        break;
                    case 4:
                        VList[i].currentcolor = Brushes.LightBlue;
                        break;
                    case 5:
                        VList[i].currentcolor = Brushes.Blue;
                        break;
                    case 6:
                        VList[i].currentcolor = Brushes.Purple;
                        break;
                    case 7:
                        VList[i].currentcolor = Brushes.Turquoise;
                        break;
                    default:
                        VList[i].currentcolor = Brushes.Gray;
                        break;
                }
            }
        }

        public static string[] GraphToFile(Graph g)
        {
            string[] s = new string[g.VList.Count * 2];

            for (int i = 0; i < s.Length / 2; i++)
            {
                s[i] += g.VList[i].vpoint.X.ToString() + " ";
                s[i] += g.VList[i].vpoint.Y.ToString() + " ";
                s[i] += g.VList[i].color.ToString() + " ";
                s[i] += g.VList[i].index.ToString() + " ";
                s[i] += g.VList[i].IncVerts.Count.ToString() + " ";

                
            }

            for (int i = s.Length / 2; i < s.Length; i++)
            {
                for (int j = 0; j < g.VList[i - s.Length / 2].IncVerts.Count; j++)
                {
                    s[i] += g.VList[i - s.Length / 2].IncVerts[j].vpoint.X.ToString() + " ";
                    s[i] += g.VList[i - s.Length / 2].IncVerts[j].vpoint.Y.ToString() + " ";
                }
                
            }
            return s;
        }

        public static Graph FileToGraph(string[] s)
        {
            Graph g = new Graph();

            for(int i = 0; i < s.Length / 2; i++)
            {
                string[] t = s[i].Split(' ');
                Vert temp = new Vert(int.Parse(t[0]), int.Parse(t[1])) { color = int.Parse(t[2]), index = int.Parse(t[3]) , degree = int.Parse(t[4]) };
                g.VList.Add(temp);
            }

            for (int i = s.Length / 2; i < s.Length; i++)
            {
                string[] t = s[i].Split(' ');
                for (int j = 0; j < g.VList[i - s.Length / 2].degree; j++)
                {
                    int x = int.Parse(t[j * 2]), y = int.Parse(t[j * 2 + 1]);
                    g.AddE(g.OnClick(x, y), g.VList[i - s.Length / 2]);
                }
            }
            return g;
        }
    }

    public class Vert: IComparable
    {
        public int index, color, degree;
        public Brush currentcolor;
        public Point vpoint;
        public bool visited; 
        public List<Vert> IncVerts;

        public Vert(int x, int y)
        {
            vpoint = new Point(x, y);
            currentcolor = Brushes.Red;
            color = 0;
            visited = false;
            IncVerts = new List<Vert>();
        }

        public Vert(Point p)
        {
            vpoint = p;
            color = 0;
            visited = false;
            currentcolor = Brushes.Red;
            IncVerts = new List<Vert>();
        }

        public Vert() { }

        public int CompareTo(object o)
        {
            return IncVerts.Count.CompareTo(((Vert)o).IncVerts.Count);
        }

    }
}
