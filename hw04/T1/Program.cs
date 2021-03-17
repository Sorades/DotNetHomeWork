using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            int[] arr = { 1, 2, 3, 6 };
            foreach (int i in arr)
                list.Add(i);
            //遍历打印：
            Console.WriteLine("遍历打印：");
            list.ForEach(m => Console.WriteLine("\t " + m));
            //求最大值：
            int max = list.Head.Data;
            list.ForEach(m => max = max < m ? m : max);
            Console.WriteLine($"最大值:{max}");
            //求最小值：
            int min = list.Head.Data;
            list.ForEach(m => min = min > m ? m : min);
            Console.WriteLine($"最小值:{min}");
            //求和：
            int sum = 0;
            list.ForEach(m => sum += m);
            Console.WriteLine($"求和:{sum}");

        }
    }
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        /// <summary>
        /// 初始化链表
        /// </summary>
        public GenericList()
        {
            head = tail = null;
        }
        public Node<T> Head { get => head; }
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        /// <summary>
        /// 从头遍历链表
        /// </summary>
        /// <param name="action"></param>
        public void ForEach(Action<T> action)
        {
            Node<T> temp = head;
            while (temp != null)
            {
                action(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
