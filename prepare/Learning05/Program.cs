using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>(){
            new Square("red", 4),
            new Rectangle("blue", 2, 4.5),
            new Circle("yellow", 3.5)
        };
        foreach (Shape shape in list){
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}