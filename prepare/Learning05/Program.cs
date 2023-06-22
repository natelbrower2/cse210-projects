using System;

namespace learning05
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("blue", 5));
            shapes.Add(new Rectangle("Red", 3, 4));
            shapes.Add(new Circle("Green", 5));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.getColor());
                Console.WriteLine(shape.GetArea() + "\n");
            }

        }
    }
}