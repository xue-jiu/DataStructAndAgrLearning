using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAgrLearning
{
    public class LinkListStack<T> : IStack<T>
    {
        private LinkedList<T> ListStack;
        public LinkListStack()
        {

        }

        public int Count { get => ListStack.Count; }

        public bool IsEmpty { get => Count == 0; }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T t)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
