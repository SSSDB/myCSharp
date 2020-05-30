using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03
{
    abstract class Shape
    {
        abstract public double Area();
        abstract public bool IsLegal();
    }
    class Rectangle : Shape
    {
        public int height, width;
        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public override double Area()
        {
            return height * width;
        }
        public override bool IsLegal()
        {
            if (height <= 0 || width <= 0)
                return false;
            else
                return true;
        }
    }
    class Square : Shape
    {
        public int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side * side;
        }
        public override bool IsLegal()
        {
            if (side <= 0)
                return false;
            else
                return true;
        }
    }
    class Triangle : Shape
    {
        public int bottom, height;
        public Triangle(int bottom, int height)
        {
            this.bottom = bottom;
            this.height = height;
        }
        public override double Area()
        {
            return bottom * height / 2;
        }

        public override bool IsLegal()
        {
            if (height <= 0 || bottom <= 0)
                return false;
            else
                return true;
        }
    }
    class InputNotLegalException : Exception
    {
        public InputNotLegalException(string message) : base(message)
        {
        }
    }
    class StaticFactory
    {
        public static void ChooseShape(string type, int m, int n)
        {
            Shape sa = null;
            switch (type)
            {
                case "rectangle": sa = new Rectangle(m, n); break;
                case "square": sa = new Square(m); break;
                case "triangle": sa = new Triangle(m, n); break;
                default:
                    try
                    {
                        throw new InputNotLegalException("图形不存在");
                    }
                    catch (InputNotLegalException e)
                    {
                        Console.WriteLine("图形不存在");
                    }
                    break;
            }
            if (sa != null)
            {
                if (sa.IsLegal())
                    Console.WriteLine(type + "的面积为：" + sa.Area());
                else
                    Console.WriteLine("图形数据不合法");
            }
        }
    }
    class RandomObject
    {
        public double RandomGenerate()
        {
            Random rdm = new Random();
            double sumArea = 0;
            for (int i = 0; i < 10; i++)
            {
                int n = rdm.Next(1, 3);
                int m1 = new Random(Guid.NewGuid().GetHashCode()).Next(1, 100);
                int m2 = new Random(Guid.NewGuid().GetHashCode()).Next(1, 100);
                switch (n)
                {
                    case 1:
                        Rectangle rec = new Rectangle(m1, m2);
                        sumArea += rec.Area(); break;
                    case 2:
                        Square squ = new Square(m1);
                        sumArea += squ.Area(); break;
                    case 3:
                        Triangle tri = new Triangle(m1, m2);
                        sumArea += tri.Area(); break;
                    default:
                        break;
                }
            }
            return sumArea;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StaticFactory.ChooseShape("triangle", -4, 6);
            RandomObject rdo = new RandomObject();
            Console.WriteLine("10个随机对象的面积和为：" + rdo.RandomGenerate());
        }
    }
}
