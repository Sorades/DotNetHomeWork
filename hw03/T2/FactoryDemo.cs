using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using T1;

namespace T2
{
    class FactoryDemo
    {
        static void Main(string[] args)
        {
            string[] shapeName = { "Rectangle", "Square", "Triagnle" };
            Random ra = new Random();
            ShapeFactory shapeFactory = new ShapeFactory();
            double areaSum = 0;
            for (int i = 0; i < 10; i++)
            {
                Shape shape = shapeFactory.GetShapeRandomly(shapeName[ra.Next(0, 3)]);
                Console.WriteLine($"创建{shape.GetType().Name},\t{shape.ShapeInfo()}");
                areaSum += shape.Area();
                Thread.Sleep(100);
            }
            Console.WriteLine($"\n这些图形的总面积为：{areaSum.ToString("0.000")}");
        }
    }
    class ShapeFactory
    {
        /// <summary>
        /// 简单工厂模式实现
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public Shape GetShapeRandomly(string shapeType)
        {
            Random ra = new Random();
            if (shapeType == null)
                return null;
            else if (shapeType == "Rectangle")
                return new Rectangle(ra.NextDouble() * 10, ra.NextDouble() * 10);
            else if (shapeType == "Square")
                return new Square(ra.NextDouble() * 10);
            else if (shapeType == "Triagnle")
            {
                double sideTemp = ra.NextDouble();
                return new Triangle(sideTemp * 3, sideTemp * 4, sideTemp * 5);
            }
            return null;
        }
    }

}


