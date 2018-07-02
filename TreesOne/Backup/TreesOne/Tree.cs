using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesOne
{
    public class Tree
    {
        public TNode root;
        public int depth;

        public Tree()
        {
            root = new TNode() { index = 0, level = 0 };
            depth = 0;
        }


        internal static int SizeOfLevel(TNode c, int level)
        {
            if((c.level != level - 1) && (c.Branches != null))
            {
                int count = 0;

                for (int i = 0; i < c.Branches.Length; i++)
                    count += SizeOfLevel(c.Branches[i], level);

                return count;
            }
            return 1;
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




        //бук
        public static void CalcPaths(Tree beech, string path)
        {
            /*            string[] result = new string[SizeOfLevel(beech.root, beech.depth)];
            for (int i = 0; i < SizeOfLevel(beech.root, beech.depth); i++)
                GetPaths(beech.root,  result, i);
            */
            string q = "";
            List<string> s = new List<string>();

            GetPaths(beech.root, q, s);



            File.WriteAllLines(path, s);
        }



    }

    public class TNode
    {
        public int index, level;
        public bool notVisited;
        public TNode Parent;
        public TNode[] Branches;
        public Point tPoint;

        public TNode() { }

        public static void GenerateBranches   
            
            (TNode curRoot,  int maxDepth, int maxBranches, int canvasWidth, int canvasHeight, ref EList E, ref EList V, int ind)

        {
            Random r = new Random();

            if (maxDepth == MainForm.MaxDEPTH)
            {
                curRoot.tPoint = new Point(canvasWidth / 2, 15);
                V.Add(curRoot.tPoint, new Point(0, 0));

                curRoot.Branches = new TNode[r.Next(maxBranches)];


                for (int p = 0; p < curRoot.Branches.Length; p++)
                {
                    curRoot.Branches[p] = new TNode()
                    {
                        index = p + 1,
                        level = MainForm.MaxDEPTH - maxDepth + 1,
                        notVisited = true,
                        Parent = curRoot
                    };

                    //if (ind < V.indicator.Length)
                    //    V.indicator[ind]++;
                    //ind++;


                    GenerateBranches(curRoot.Branches[p], maxDepth - 1, maxBranches, canvasWidth, canvasHeight, ref E, ref V, ind);
                }




            }
            else
            if
                (maxDepth != 0)
            {
                curRoot.Branches = new TNode[r.Next(maxBranches)];



                //запись координат точки текущего узла и запись пары точек для последующего рисования ребра
                int x = (curRoot.index + ind) * canvasWidth / (curRoot.Parent.Branches.Length + 1),

                    y = curRoot.level * canvasHeight / MainForm.MaxDEPTH + 15;

                curRoot.tPoint = new Point(x, y);

                V.Add(new Point(x, y), new Point(0, 0)); E.Add(new Point(x, y), curRoot.Parent.tPoint);


                for (int p = 0; p < curRoot.Branches.Length; p++)
                {
                    curRoot.Branches[p] = new TNode()
                    {
                        index = p + 1,
                        level = MainForm.MaxDEPTH - maxDepth + 1,
                        notVisited = true,
                        Parent = curRoot
                    };

                    //if (ind < V.indicator.Length)
                    //    V.indicator[ind]++;
                    //ind++;


                    GenerateBranches(curRoot.Branches[p], maxDepth - 1, maxBranches, canvasWidth, canvasHeight, ref E, ref V, ind);
                }


            }
            else
            {
                int x = (curRoot.index + ind) * canvasWidth / (curRoot.Parent.Branches.Length + 1),

                        y = curRoot.level * canvasHeight / MainForm.MaxDEPTH + 15;

                curRoot.tPoint = new Point(x, y);

                V.Add(new Point(x, y), new Point(0, 0)); E.Add(new Point(x, y), curRoot.Parent.tPoint);
            }


        }



    }


   


}








//full-manual adding is super-hard to implement and useless
/*

 //to posess the ability to fill the tree with new branches
 //one must give the full path to the new branch(leaf)


         public void AddLvl(int index)
{
    TNode temp = FindNode(LVL, index);
    temp.Branches = new TNode[9];
    LVL++;
    foreach (TNode p in temp.Branches)
    {
        p.index = -1;
        p.level = LVL;
    }
}


internal TNode FindNode(int lvl, int index)
{
    TNode S = root;


    ///////////////////////////////////

    return S;
}


public void AddBranch(int lvl, int index)
{
    TNode A = FindNode(lvl, index);
    int i = 0;
    while (A.Branches[i].index != -1)
        i++;
    A.Branches[i].index = i;
    A.Branches[i].Branches = new TNode[9];

}








 */










//if (curRoot.Parent != null)
//{
//    if (curRoot.Parent.tPoint.X < canvasWidth / 2)
//    {
//        int step = 2 * curRoot.Parent.tPoint.X / curRoot.Parent.Branches.Length;
//        if(curRoot.Parent.Parent != null && curRoot.Parent.index - 2 >= 0 && curRoot.Parent.index - 2 < curRoot.Parent.Parent.Branches.Length && curRoot.Parent.Parent.Branches[curRoot.Parent.index - 2].Branches.Length > curRoot.Parent.Parent.Branches[curRoot.Parent.index - 2].Branches.Length - 1)
//            x = step / 2 * curRoot.index + curRoot.Parent.Parent.Branches[curRoot.Parent.index - 2].Branches [  curRoot.Parent.Parent.Branches[curRoot.Parent.index - 2].Branches.Length - 1].tPoint.X + 10;
//        else
//        x = 2 * curRoot.Parent.tPoint.X - step * (curRoot.index - 1) + 20;

//    }
//    else
//    if (curRoot.Parent.tPoint.X > canvasWidth / 2)
//    {
//        int step = 2 * (canvasWidth - curRoot.Parent.tPoint.X) / curRoot.Parent.Branches.Length;

//        if (curRoot.Parent.Parent != null && curRoot.Parent.index - 2 >= 0 && curRoot.Parent.index - 2 < curRoot.Parent.Parent.Branches.Length && curRoot.Parent.Parent.Branches[curRoot.Parent.index - 2].Branches.Length > curRoot.Parent.Parent.Branches[curRoot.Parent.index - 2].Branches.Length - 1)
//            x = step / 2 * curRoot.index + curRoot.Parent.Parent.Branches[curRoot.Parent.index - 2].Branches[curRoot.Parent.Parent.Branches[curRoot.Parent.index - 2].Branches.Length - 1].tPoint.X + 10;
//        else
//            x = canvasWidth - 2 * (canvasWidth - curRoot.Parent.tPoint.X) + step * (curRoot.index - 1) + 20;

//    }
//    else
//    {
//        int step = canvasWidth / curRoot.Parent.Branches.Length;
//        x = step / 2 * curRoot.index;
//    }
//    curRoot.tPoint = new Point(x, y);
//    V.Add(curRoot.tPoint, new Point(0, 0));
//    E.Add(curRoot.tPoint, curRoot.Parent.tPoint);
//}
//else
//{
//    x = canvasWidth / 2;
//    curRoot.tPoint = new Point(x, y);
//    V.Add(curRoot.tPoint, new Point(0, 0));
//}
//запись координат точки текущего узла и запись пары точек для последующего рисования ребра


//TNode[] curLvlNodes = new TNode[curRoot.Branches.Length * maxBranches];

