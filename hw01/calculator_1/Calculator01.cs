using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_1
{
    class Calculator01
    {
        static void Main(string[] args)
        {
            int first, second, sum;
            char op;
            Console.WriteLine("本程序实现简单两数运算...");
            /*            Console.Write("运算数1：");
                        first = int.Parse(Console.ReadLine());
                        Console.Write("运算符：");
                        op = char.Parse(Console.ReadLine());
                        Console.Write("运算数2：");
                        second = int.Parse(Console.ReadLine());*/ 
            Console.WriteLine("请按格式（数字 运算符 数字，以空格隔开）输入算式：");
            try
            {
                string temp = Console.ReadLine();//将算式存于字符串中
                string[] str = temp.Split(' ');//根据空格将字符串分为三个字串
                if (str.Length != 3)
                {
                    Console.WriteLine("输入格式有误！");
                    return;
                }//若字串数目不对则退出
                first = int.Parse(str[0]);
                op = char.Parse(str[1]);
                second = int.Parse(str[2]);
            }
            catch (FormatException)
            {
                Console.WriteLine("输入的数字有误！");
                return;
            }
            switch (op)
            {
                case '+':
                    sum = first + second;
                    break;
                case '-':
                    sum = first - second;
                    break;
                case '*':
                    sum = first * second;
                    break;
                case '/':
                    sum = first / second;
                    break;
                default:
                    Console.WriteLine("输入运算符有误！");
                    return;
            }
            Console.WriteLine("结果为：" + sum);
        }
    }
}
