using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesOne
{
    public class EList
    {
        public ENode head, tail;
        public int[] indicator;

        public EList()
        {
            head = tail = null;
        }
        public void Add(Point P1, Point P2)
        {
            if(head == null)
            {
                head = tail = new ENode(P1, P2);
            }
            else
            {
                tail.next = new ENode(P1, P2);
                tail = tail.next;
            }
        }
    }

    public class ENode
    {
        public Point p1, p2;
        public ENode next;

        public ENode(Point P1, Point P2)
        {
            p1 = P1;
            p2 = P2;
        }
    }
}
