using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Array
    {
        static int[] numArr;
        static void Main(string[] args)
        {
            NumInput();
            Console.WriteLine("最大值："+GetMaxNum());
            Console.WriteLine("最小值："+GetMinNum());
            Console.WriteLine("平均值："+GetAverNum());
            Console.WriteLine("求和："+GetSum());
        }
        static void NumInput()
        {
            Console.WriteLine("本程序将依次输出您输入整数数据的最大值，最小值，平均值以及和...");
            Console.WriteLine("请按请按\"4,5,9...\"形式输入，用半角逗号隔开每个整数数字");
            Console.Write("请输入：");
            string tempStr = Console.ReadLine();
            string[] numStr = tempStr.Split(',');
            numArr = new int[numStr.Length];
            for (int i = 0; i < numStr.Length; i++)
                try
                {
                    numArr[i] = int.Parse(numStr[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入数字有误！");
                    Environment.Exit(0);//直接退出
                }

        }
        static int GetMaxNum()
        {
            int max = numArr[0];
            foreach (int i in numArr)
                if (max < i) max = i;
            return max;
        }
        static int GetMinNum()
        {
            int min = numArr[0];
            foreach (int i in numArr)
                if (min > i) min = i;
            return min;
        }
        static double GetAverNum()
        {
            return GetSum() / (double)numArr.Length;
        }
        static int GetSum()
        {
            int sum = 0;
            foreach (int i in numArr)
                sum += i;
            return sum;
        }
    }
}
