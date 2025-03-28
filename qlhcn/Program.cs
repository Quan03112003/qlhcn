using System;

class Program
{
    static void Main(string[] args)
    {
     
        Console.Write("Enter width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of the rectangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);

      
        rectangle.Display();
    }
}
