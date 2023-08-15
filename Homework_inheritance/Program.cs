using System.Drawing;
using System.Threading.Tasks;

namespace Homework_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.Write("Rectangle's primeter = ");
            rectangle.CalculatePerimeter(); 
            
            Console.Write("Rectangle's area = ");
            rectangle.CalculateArea();

            Console.Write("Rectangle's diagonal = ");
            rectangle.CalculateDiagonal();

            Circle circle = new Circle();

            Console.Write("Circle's area = ");
            circle.CalculateArea();

            Console.Write("Circle's Primetr = ");
            circle.CalculatePerimeter();


        }
    }
            

    class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle() 
        {
            Height = 10;
            Width = 20;
        }

        public double CalculatePerimeter()
        {
            return (Height + Width) * 2;
        }

        public double CalculateArea()
        {
            return Height * Width;
        }

        public double CalculateDiagonal() 
        {
            return Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        }
    }
    class Circle
    {
        public double Radius { get; set; }
        
        public Circle() 
        {
            Radius = 5;
        }

        public double CalculatePerimeter()
        {
            return 3.14 * 2 * Radius;
        }

        public double CalculateArea()
        {
            return Radius * 2 * Radius;
        }
    }
}