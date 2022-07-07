using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAgrLearning
{
    public class LinkList<T>
    {
        private class Node 
        {
            public T Content { get; set; }
            public Node Next { get; set; }
            public Node(T content, Node next)
            {
                Content = content;
                Next = next;
            }
            public Node(T content)
            {
                Content = content;
                Next = null;
            }
            public override string ToString()
            {
                return Content.ToString();
            }
        }
        private Node head;
        private int N;//记录有几个节点
        public LinkList()
        {
            head = null;
            N = 0;
        }
        public int Count() 
        {
            return N;
        }
        public bool IsEmpty() 
        {
            return N == 0;
        }


    }
}
