using System;
namespace csharp_oop{
    public class Circle : Shape
    {

        int radius;

        public Circle(char color, int radius) :base(color)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius *radius;
        }
    }
}