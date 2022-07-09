using System;

namespace DataStructAndAgrLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数据结构与算法实战学习--------------------(附LeetCode)");
            Console.WriteLine("---------------数据部分--------------------");
            Array array = new Array();
            var NewArray = array.ReplaceArray(0, 100);
            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.Write($"{NewArray[i]}////");
            }
            array.AddArray(1, 2);
            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.WriteLine($"{NewArray[i]}////");
            }

            Console.WriteLine("---------------打印--------------------");
            LinkList<string> linkList = new LinkList<string>();
            for (int i = 0; i < 5; i++)
            {
                linkList.Add(0,$"第{i}个");
                Console.WriteLine(linkList);
            }
            Console.WriteLine("---------------删除--------------------");
            linkList.Delete("第10个");
            Console.WriteLine(linkList);


        }
    }
}
