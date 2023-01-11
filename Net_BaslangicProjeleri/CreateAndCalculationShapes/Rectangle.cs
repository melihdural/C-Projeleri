namespace Net_BaslangicProjeleri.CreateShape;

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Insert a size for Rectangle");
        var size = Int32.Parse(Console.ReadLine());
        
        int gap = size;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < gap; j++)
            {
                Console.Write(" ");
            }
            gap--;
            for (int j = 0; j < (i + 1); j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public override float CalculateArea()
    {
        Console.WriteLine("Insert a base edge size of Rectangle");
        var baseSize = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Insert a height of Rectangle");
        var height = Int32.Parse(Console.ReadLine());

        var area = (baseSize * height) / 2;
        Console.WriteLine("Area = {0}",area);
        Console.WriteLine();
        return area;

    }

    public override void CalculatePerimeter()
    {
        Console.WriteLine("Insert base edge size of Rectangle");
        var baseSize = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Insert 1st edge size of Rectangle");
        var edge1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Insert 2nd edge size of Rectangle");
        var edge2 = Int32.Parse(Console.ReadLine());

        float perimeter = baseSize + edge1 + edge2;
        Console.WriteLine("Perimeter of Rectangle = {0}",perimeter);
        Console.WriteLine();
    }

    public override void CalculateVolume()
    {
        var area = CalculateArea();
        
        Console.WriteLine("Insert height of Triangular Prism");
        var prism = Int32.Parse(Console.ReadLine());
        
        double volume = area * prism;

        Console.WriteLine("Volume of Rectangle = {0}", volume);
        Console.WriteLine();
    }
}