using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    class Node
    {
        public Bitmap value;
        public Node next, prev;
        public Node(Bitmap Value, Node Prev = null, Node Next = null)
        {
            value = Value;
            next = Next;
            prev = Prev;
        }
    }

    public class DLList
    {
        Node head, tail;
        int Size;

        public int size
        {
            get { return Size; }
        }

        public DLList()
        {
            Size = 0;
            head = tail = null;
        }

        public void Add(Bitmap Value)
        {
            if(head == null)
            {
                head = tail = new Node(Value);
            }
            else
            {
                tail = new Node(Value, tail, null);
                tail.prev.next = tail;
            }
        }






    }
}
