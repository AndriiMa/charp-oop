using System;

namespace csharp_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                new Circle('r', 1),
                new Circle('b', 2),
                new Circle('w', 3)
                };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            double area = GetTotalArea(shapes);

            Console.WriteLine("Area {0}", area);
        }

        public static double GetTotalArea(Shape[] shapes)
        {
            double area = 0D;

            foreach (Shape shape in shapes)
            {
                area += shape.CalculateArea();
            }
            return 1D;
        }
    }
}
