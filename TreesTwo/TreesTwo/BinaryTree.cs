using System;
using System.Collections.Generic;
using System.Drawing;

namespace TreesTwo
{
    public class BinaryTree
    {
        public BTNode root;

        public BinaryTree() { root = new BTNode(); }

        public Bitmap Draw(int w, int h, List<Point> a, List<Point>[] b)
        {
            Bitmap c = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(c);
            Size s = new Size(MainFormAkatosh.RAD * 2, MainFormAkatosh.RAD * 2);

            for (int i = 0; i < b[0].Count; i++)
                g.DrawLine(Pens.Black, b[0][i], b[1][i]);

            for(int i = 0; i < a.Count; i++)
            {
                Point d = new Point(a[i].X - MainFormAkatosh.RAD, a[i].Y - MainFormAkatosh.RAD);
                Rectangle r = new Rectangle(d, s);
                g.FillEllipse(Brushes.Orange, r);
            }
            return c;
        }

        public void GTree(BTNode t, double c, int lvl, Random rnd)
        {
            if(lvl != 0)
            {
                if (rnd.NextDouble() < c)
                {
                    t.left = new BTNode() { level = MainFormAkatosh.MaxDEPTH + 2 - lvl, parent = t, value = rnd.Next() };
                    GTree(t.left, c, lvl - 1, rnd);
                } 
                if (rnd.NextDouble() < c)
                {
                    t.right = new BTNode() { level = MainFormAkatosh.MaxDEPTH + 2 - lvl, parent = t, value = rnd.Next() };
                    GTree(t.right, c, lvl - 1, rnd);
                }
            }
        }

        public static void CompareTrees(BinaryTree a, BinaryTree b, ref bool e) => CTFR(a.root, b.root, ref e);

        internal static void CTFR(BTNode a, BTNode b, ref bool e)
        {
            if(e)
            {
                if (a.value == b.value)
                {
                    if (a.left != null && b.left != null && a.right != null && b.right != null)
                    {
                        CTFR(a.left, b.left, ref e);
                        CTFR(a.right, b.right, ref e);
                    }
                    else if (a.left != null && b.left != null && a.right == null && b.right == null)
                        CTFR(a.left, b.left, ref e);
                    else if (a.right != null && b.right != null && a.left == null && b.left == null)
                        CTFR(a.right, b.right, ref e);
                    else if (a.left == null && b.left == null && a.right == null && b.right == null)
                        e = true;
                    else e = false;
                }
                else e = false;
            }
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
                else if (start.right != null)
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
                    current = new Point(step, t.level * canvasHeight / (MainFormAkatosh.MaxDEPTH + 1) - 15);
                else
                    current = new Point(prev.tpoint.X + step, t.level * canvasHeight / (MainFormAkatosh.MaxDEPTH + 1) - 15);

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
                t.tpoint = new Point(canvasWidth / 2, 12);
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
                else if (c.left != null)
                {
                    count += SizeOfLevel(c.left, level);
                    return count;
                }
                else return 0;
            }
            return 1;
        }
    }

    public class BTNode
    {
        public int level, value;
        public BTNode left, right;
        public BTNode parent;
        public Point tpoint;
        public BTNode() { }
    }
}
