using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 先求素数再求因数
 */
namespace T1ver2
{
    class PrimeFactorFind
    {
        static int numInput;
        static void Main(string[] args)
        {
            NumInput();
            FactorFind();
        }
        static void NumInput()
        {
            Console.WriteLine("本程序输出将您输入的数据的所有素数因子...");
            Console.Write("请输入：");
            numInput = int.Parse(Console.ReadLine());
        }
        static bool PrimeCheck(int numToJudge)
        {
            for (int i = 2; i < numToJudge / 2; i++)
                if (numToJudge % i == 0) return false;
            return true;
        }
        static void FactorFind()
        {
            int dividend = numInput;
            Console.WriteLine("其中素数因子如下：");
            for (int i = 2; i <= dividend; i++)
            {
                if (dividend % i != 0) continue;
                if (PrimeCheck(i))
                    Console.Write(i+" ");
                while (dividend % i == 0)
                    dividend /= i;
                i = 1;
            }
            Console.WriteLine();
        }
    }
}
