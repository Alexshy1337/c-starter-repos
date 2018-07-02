using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace TreesOne
{
    public class Tree
    {
        public TNode root;
        public Tree()
        {
            root = new TNode() { index = 0, level = 0 };
        }


        //количество узлов на заданном уровне
        internal static int SizeOfLevel(TNode c, int level)
        {
            if((c.level != level) && (c.Branches != null))
            {
                int count = 0;
                for (int i = 0; i < c.Branches.Length; i++)
                    count += SizeOfLevel(c.Branches[i], level);
                return count;
            }
            return 1;
        }



        //найти предыдущий узел с этого же уровня (возможно другой ветви дерева)
        internal static void GetPrev(TNode start, TNode search, ref TNode t1, ref bool f)
        {
            if (f) return;
            
            if(start.Branches != null && start.Branches.Length != 0 && start.level < search.level)
            {
                for (int i = 0; i < start.Branches.Length; i++)
                    GetPrev(start.Branches[i], search, ref t1, ref f);
            }
            else if(start.level == search.level && start != search)
                t1 = start;

            if (start == search)
                f = true;
        }


        //вычислить координаты для каждого узла и записать в 2 разных списка либо точку самого узла (V), либо пару точек, задающую ребро (E)
        public void GetPoints(TNode t, int canvasWidth, int canvasHeight, EList E, EList V)
        {
            if (t.level > 0)
            {
                int step = canvasWidth / (SizeOfLevel(root, t.level) + 1);
                TNode prev = null;
                bool f1 = false;
                GetPrev(root, t, ref prev, ref f1);
                Point current;
                if (prev == null)
                    current = new Point(step, t.level * canvasHeight / MainForm.MaxDEPTH - 15);
                else
                    current = new Point(prev.tPoint.X + step, t.level * canvasHeight / MainForm.MaxDEPTH - 15);

                t.tPoint = current;
                V.Add(current, t.index); E.Add(current, t.Parent.tPoint);

                if (t.Branches != null && t.Branches.Length != 0)
                    for (int i = 0; i < t.Branches.Length; i++)
                        GetPoints(t.Branches[i], canvasWidth, canvasHeight, E, V);
            }
            else
            {
                V.Add(t.tPoint, t.index);
                if (t.Branches != null && t.Branches.Length != 0)
                    for (int i = 0; i < t.Branches.Length; i++)
                        GetPoints(t.Branches[i], canvasWidth, canvasHeight, E, V);
            }
        }



        //бук
        //выполние задачи
        public static void CalcPaths(Tree beech, string path)
        {
            string q = "";
            List<string> s = new List<string>();
            GetPaths(beech.root, q, s);
            File.WriteAllLines(path, s);
        }



        internal static void GetPaths(TNode l, string q, List<string> s)
        {
            q += l.index.ToString() + " ";

            if (l.Branches != null)
            {
                for (int i = 0; i < l.Branches.Length; i++)
                    if (l.index != l.Branches[i].index)
                    {
                        GetPaths(l.Branches[i], q, s);
                    }
            }
            else
            {
                s.Add(q);
            }
        }


    }

    public class TNode
    {
        public int index, level;
        public TNode Parent;
        public TNode[] Branches;
        public Point tPoint;

        public TNode() { }

        private static Random rnd = new Random();

        //генерация дерева
        public static void GenerateBranches (TNode curRoot, int maxDepth, int branches)
        {
            if (maxDepth != 0)
            {
                curRoot.Branches = new TNode[branches];
                for (int p = 0; p < curRoot.Branches.Length; p++)
                {
                    curRoot.Branches[p] = new TNode()
                    {
                        index = p + 1,
                        level = MainForm.MaxDEPTH - maxDepth + 1,
                        Parent = curRoot
                    };
                    GenerateBranches(curRoot.Branches[p], maxDepth - 1, branches);
                }
            }
        }
    }
}
