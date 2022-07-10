using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAgrLearning
{
    public interface IStack<T>
    {
        public int Count { get;}
        public bool IsEmpty { get;}
        public T Peek();
        public T Pop();
        public void Push(T t);



    }
}
