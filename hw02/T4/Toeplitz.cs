using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Toeplitz
    {
        const int M = 4;
        const int N = 3;
        static int[,] matrix =
         {
            {1,2,3,4 },
            {5,1,2,3 },
            {9,5,1,2 }
        };
        static void Main(string[] args)
        {
            if (Judge())
                Console.WriteLine("是托普利兹矩阵");
            else Console.WriteLine("不是托普利兹矩阵");
        }
        static bool Judge()
        {
            const int max = N - 1;
            const int min = M * (-1) + 1;
            int x, y, fisrtValue = 0;
            bool firstAssign;
            for (int i = min; i < max; i++)
            {
                firstAssign = true;//用于找到该直线上第一个值
                for (y = 0; y < M; y++)
                {
                    x = y + i;
                    if (x < 0) continue;//计算出负数不在矩阵区间内，跳转下次循环
                    if (x >= N) break;//越界则跳出当前循环
                    if (firstAssign)//找到对角线的第一个值
                    {
                        fisrtValue = matrix[x, y];
                        firstAssign = false;
                    }
                    else
                    {
                        if (fisrtValue != matrix[x, y])//同一条符合条件的对角线上有元素不相同
                            return false;//出现不匹配直接返回false
                    }
                }
            }

            return true;
        }
    }
}
