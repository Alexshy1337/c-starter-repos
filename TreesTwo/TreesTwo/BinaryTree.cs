using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesTwo
{
    public class BinaryTree
    {
        public BTNode root;
        private Random rnd = new Random();

        public BinaryTree() { root = new BTNode(); }


        //
        public Bitmap Draw(int w, int h, List<Point> a, List<Point>[] b)
        {
            Bitmap c = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(c);
            Size s = new Size(Akatosh.RAD * 2, Akatosh.RAD * 2);

            for (int i = 0; i < b[0].Count; i++)
                g.DrawLine(Pens.Black, b[0][i], b[1][i]);

            for(int i = 0; i < a.Count; i++)
            {
                Rectangle r = new Rectangle(a[i], s);
                g.FillEllipse(Brushes.Orange, r);
            }
            return c;
        }

        //
        public void GTree(BTNode r, double c, int level)
        {
            if(rnd.NextDouble() < c)
            {
                r.left = new BTNode();
                GTree(r.left, c);
            }
            if(rnd.NextDouble() < c)
            {
                r.right = new BTNode();
                GTree(r.right, c);
            }
        }

        //
        public static bool CompareTrees(BinaryTree a, BinaryTree b)
        {





            return false;
        }

        
        internal static void GetPrev(BTNode start, BTNode search, ref BTNode t1, ref bool f)
        {
            if (f) return;
            if (start.level < search.level)
            {
                if (start.left != null && start.right != null)
                {
                    GetPrev(start.left, search, ref t1, ref f);
                    if (!f)
                        GetPrev(start.right, search, ref t1, ref f);
                }
                else if (start.left != null)
                    GetPrev(start.left, search, ref t1, ref f);
                else
                    GetPrev(start.right, search, ref t1, ref f);
            }
            else if (start != search)
                t1 = start;

            if (start == search)
                f = true;
        }
        
        public void GetPoints(BTNode t, int canvasWidth, int canvasHeight, List<Point> n, List<Point>[] e)
        {
            if (t.level > 0)
            {
                int step = canvasWidth / (SizeOfLevel(root, t.level) + 1);
                BTNode prev = null;
                bool f1 = false;
                GetPrev(root, t, ref prev, ref f1);
                Point current;
                if (prev == null)
                    current = new Point(step, t.level * canvasHeight / Akatosh.MaxDEPTH - 15);
                else
                    current = new Point(prev.tpoint.X + step, t.level * canvasHeight / Akatosh.MaxDEPTH - 15);

                t.tpoint = current;
                n.Add(current); e[0].Add(t.parent.tpoint); e[1].Add(current);

                if (t.left != null && t.right != null)
                {
                    GetPoints(t.left, canvasWidth, canvasHeight, n, e);
                    GetPoints(t.right, canvasWidth, canvasHeight, n, e);
                }
                else if(t.right != null)
                    GetPoints(t.right, canvasWidth, canvasHeight, n, e);
                else if(t.left != null)
                    GetPoints(t.left, canvasWidth, canvasHeight, n, e);
            }
            else
            {
                n.Add(t.tpoint);
                if (t.left != null && t.right != null)
                {
                    GetPoints(t.left, canvasWidth, canvasHeight, n, e);
                    GetPoints(t.right, canvasWidth, canvasHeight, n, e);
                }
                else if (t.right != null)
                    GetPoints(t.right, canvasWidth, canvasHeight, n, e);
                else if (t.left != null)
                    GetPoints(t.left, canvasWidth, canvasHeight, n, e);
            }
        }

        internal static int SizeOfLevel(BTNode c, int level)
        {
            if (c.level != level)
            {
                int count = 0;
                if (c.left != null && c.right != null)
                {
                    count += SizeOfLevel(c.left, level);
                    count += SizeOfLevel(c.right, level);
                    return count;
                }
                else if (c.right != null)
                {
                    count += SizeOfLevel(c.right, level);
                    return count;
                }
                else
                {
                    count += SizeOfLevel(c.left, level);
                    return count;
                }
            }
            return 1;
        }


    }


    public class BTNode
    {
        //public int value;
        public int level;
        public BTNode left, right;
        public Point tpoint;
        public BTNode parent;

        public BTNode() { }
    }
}
