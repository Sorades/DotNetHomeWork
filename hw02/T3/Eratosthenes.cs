using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class Eratosthenes
    {
        public static int[] primeArr;//1表示是素数，0则相反
        static void Main(string[] args)
        {
            int length = 100;
            Seive(length);
            PrimeOutput(length);
        }
        //埃式筛法求素数，存于数组
        public static void Seive(int length)
        {
            primeArr = new int[length];
            for (int i = 2; i < primeArr.Length; i++)
                primeArr[i] = 1;//初始化为1
            for (int i = 2; i < primeArr.Length; i++)
            {
                if (i * i > primeArr.Length)
                    break;
                if (primeArr[i] == 1)
                    for (int j = i * i; j < primeArr.Length; j += i)
                        primeArr[j] = 0;
            }
        }
        //输出所求素数
        static void PrimeOutput(int length)
        {
            int count = 0;
            Console.WriteLine($"2~{length}内的素数：");
            for (int i = 0; i < primeArr.Length; i++)
            {
                if (primeArr[i] == 1)
                {
                    Console.Write(i + "\t");
                    count++;
                    if (count % 10 == 0)
                        Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
