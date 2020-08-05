using System;

namespace csharp_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                new Shape('r'),
                new Shape('b'),
                new Shape('w')                
                };

                Console.WriteLine(shapes[0].ToString());

                foreach (var shape in shapes)
                {
                    Console.WriteLine(shape);
                }
        }
    }
}
