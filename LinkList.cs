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

        public void Add(int index, T content)
        {
            if (index<0||index>N)
            {
                throw new ArgumentException("非法索引");
            }
            if (index == 0)
            {
                Node node = new Node(content);
                node.Next = head;
                head = node;

                // head = new Node(content, head);高级
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index-1; i++)
                {
                    pre = pre.Next;
                }
                Node now = new Node(content);
                now.Next= pre.Next;
                pre.Next = now;

                //pre.Next=new Node(content,pre.Next);
            }
            N++;
        }

        public void Delete(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("非法索引");
            }
            if (index == 0)
            {
                head = head.Next;
                N--;
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index - 1; i++)
                {
                    pre = pre.Next;
                }
                pre.Next = pre.Next.Next;
                N--;
            }
        }

        public void Delete(T content)
        {
            if (head==null)
            {
                return;
            }
            if (head.Content.Equals(content))
            {
                head = head.Next;
                N--;
            }
            else
            {
                Node cur = head.Next;
                Node pre = head;
                while (cur!=null)
                {
                    if (cur.Content.Equals(content))
                    {
                        break;
                    }
                    pre = cur;
                    cur = cur.Next;
                }
                if (cur != null)
                {
                    pre.Next = pre.Next.Next;
                    N--;
                }

            }
            //第一种思路,直接查cru
            //第二种思路,查cru.next 
}
        



        public T GetContent(int index) 
        {
            Node pre = head;
            for (int i = 0; i < index - 1; i++)
            {
                pre = pre.Next;
            }
            return pre.Content;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node Cur = head;
            while (Cur!=null)
            {
                res.Append(Cur+"-->");
                Cur = Cur.Next;
            }
            res.Append("null");
            return res.ToString();
           // return base.ToString();
        }
    }
}
