using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Façade_Pattern_HandsOn
{
    internal class FacadePatternDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= Drawing Shapes ============ ");
            Console.WriteLine("Enter 1 for Circle");
            Console.WriteLine("Enter 2 for Rectangle");
            Console.WriteLine("Enter 3 for Square");
            Console.WriteLine("Enter your Choice:");
            int num = Convert.ToInt32(Console.ReadLine());
            ShapeMaker s1 = new ShapeMaker();   
            switch (num)
            {
                case 1:
                    {
                        s1.DrawCircle();
                    }
                    break;
                case 2:
                    {
                        s1.DrawRectangle();
                    }
                    break;
                case 3:
                    {
                        s1.DrawSquare();    
                    }
                    break;
                default:
                    {
                        Console.WriteLine("No Shape is Drawn");
                    }
                    return;
            }

        }

    }
    public interface IShape
    {
        public void Draw();
    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is Circle");
        }
    }
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is Rectangle");
        }
    }
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is Square");
        }
    }
    public class ShapeMaker
    {
        private IShape Circle ;
        private IShape Rectangle ;
        private IShape Square ;

        public ShapeMaker()
        {
            Circle = new Circle();
            Rectangle = new Rectangle();
            Square = new Square();
        }
        public void DrawCircle()
        {
            Circle.Draw();
        }
        public void DrawRectangle()
        {
            Rectangle.Draw();   
        }
        public void DrawSquare()
        {
            Square.Draw();
        }

    }
}
