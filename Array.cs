using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAgrLearning
{
    public class Array
    {

        public int[] ArrayOne { get; set; }
        public int[] ArrayTwo { get; set; }
        public Array()
        {
            ArrayOne = new int[] {7,8,9,10,2,3,4 };
        }

        public int[] ReplaceArray(int position,int target)
        {
            Console.WriteLine("--------------------往数组替换数组某个元素-------------------");
            ArrayOne[position] = target;
            return ArrayOne;
        }
        //position从0起算
        public int[] AddArray(int position, int target) 
        {
            Console.WriteLine("--------------------向数组某个位置添加一个数-------------------");
            for (int i = ArrayOne.Length-1; i >position; i--)//最后一个数字为0
            {
                ArrayOne[i] = ArrayOne[i-1];
            }
            ArrayOne[position] = target;
            return ArrayOne;
        }




    }
}
