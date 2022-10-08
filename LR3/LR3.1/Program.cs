using Microsoft.VisualBasic;
using System.Dynamic;

public class Rectangle
{
    public  Rectangle(double side1, double side2)
    {
        _side1 = side1;
        _side2 = side2;
    }
    double _side1 = 0;
    double _side2 = 0;

    double AreaCalculator() => _side1 * _side2;
    double PerimeterCalculator() => (_side1 + _side2) * 2;

    public double Area
    {
        get => AreaCalculator();
    }
    public double Perimeter
    {
        get => PerimeterCalculator();
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first side lenth: ");
        Double.TryParse(Console.ReadLine(), out double side1);
        
        Console.WriteLine("Enter second side lenth: ");
        Double.TryParse(Console.ReadLine(), out double side2);

        var rect = new Rectangle(side1, side2);
        Console.WriteLine("Area: " + rect.Area);       
        Console.WriteLine("Perimeter: " + rect.Perimeter);       
    }
}