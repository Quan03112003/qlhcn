using System;

class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

 
    public void Display()
    {
        Console.WriteLine("Rectangle Information:");
        Console.WriteLine($"Width: {Width}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Area: {GetArea()}");
        Console.WriteLine($"Perimeter: {GetPerimeter()}");
    }
}
