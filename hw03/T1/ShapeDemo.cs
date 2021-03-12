using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class ShapeDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle rec = new Rectangle(2, 3);
                Console.WriteLine($"长方形的面积：{rec.Area.ToString("0.000")}");
                Console.WriteLine($"长方形的周长：{rec.Primeter.ToString("0.000")}\n");

                Square sq = new Square(6);
                Console.WriteLine($"正方形的面积：{sq.Area.ToString("0.000")}");
                Console.WriteLine($"正方形的周长：{sq.Primeter.ToString("0.000")}\n");

                Triangle tr = new Triangle(5, 4, 3);
                Console.WriteLine($"三角形的面积：{tr.Area.ToString("0.000")}");
                Console.WriteLine($"三角形的周长：{tr.Primeter.ToString("0.000")}\n");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public interface Shape
    {
        /// <summary>
        /// 图形面积
        /// </summary>
        double Area { get; }
        /// <summary>
        /// 图形周长
        /// </summary>
        double Primeter { get; }
        /// <returns>图形数据是否合法</returns>
        bool IsLegal();
        /// <summary>
        /// 输出图形信息
        /// </summary>
        string ShapeInfo();
    }

    public class Rectangle : Shape
    {
        double width;
        double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area
        {
            get
            {
                if (!IsLegal())
                    throw new ArgumentException($"{this.GetType().Name}图形数据不合法！");
                return width * height;
            }
        }

        public double Primeter
        {
            get
            {
                if (!IsLegal())
                    throw new ArgumentException($"{this.GetType().Name}图形数据不合法！");
                return 2 * (width + height);
            }
        }

        public bool IsLegal()
        {
            return width > 0 && height > 0 ? true : false;
        }

        string Shape.ShapeInfo()
        {
            return $"高：{this.height.ToString("0.000")}，宽：{this.width.ToString("0.000")}";
        }
    }

    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
    }

    public class Triangle : Shape
    {
        double sideA;
        double sideB;
        double sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double Area
        {
            get
            {
                if (!IsLegal())
                    throw new ArgumentException($"{this.GetType().Name}图形数据不合法！");
                double p = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
        }

        public double Primeter
        {
            get
            {
                if (!IsLegal())
                    throw new ArgumentException($"{this.GetType().Name}图形数据不合法！");
                return sideA + sideB + sideC;
            }
        }

        public bool IsLegal()
        {
            if (sideA + sideB <= sideC)
                return false;
            if (sideA + sideC <= sideB)
                return false;
            if (sideB + sideC <= sideA)
                return false;
            return true;
        }


        string Shape.ShapeInfo()
        {
            return $"三边分别为：{sideA.ToString("0.000")}, {sideB.ToString("0.000")}, {sideC.ToString("0.000")}";
        }
    }
}
