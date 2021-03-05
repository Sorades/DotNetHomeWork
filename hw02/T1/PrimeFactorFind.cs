using System;
using T3;
//先求素数再求因数
//直接调用第三题的素数数组，先找到范围内的素数，再判断是否为因数
namespace T1
{
    class PrimeFactorFind
    {
        static int numInput;

        static void Main(string[] args)
        {
            NumInput();
            AnswerOutput();
        }
        /* 进行数据的输入
         */
        static void NumInput()
        {
            Console.WriteLine("本程序输出将您输入的数据的所有素数因子...");
            Console.Write("请输入：");
            numInput = int.Parse(Console.ReadLine());
        }
        /* 将得到的数组中的数据检验素数因子后输出
         */
        static void AnswerOutput()
        {
            Eratosthenes.Seive(numInput);
            Console.WriteLine("其中素数因子如下：");
            int numNow = 0;
            foreach (int i in Eratosthenes.primeArr)
            {
                if (i == 1 && numInput % numNow == 0)
                    Console.Write(numNow + " ");
                numNow++;
            }
            Console.WriteLine();
        }
    }
}
