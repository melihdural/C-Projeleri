namespace Net_BaslangicProjeleri.CreateShape;

public class Circle : Shape
{
    private const float Pi = 3.14f;
    public override void Draw()
    {

        Console.WriteLine("Insert a redius for Circle");
        var radius = Int32.Parse(Console.ReadLine());
        
        for (double y = -radius; y <= radius; y ++)
        {
            for (double x = -radius; x <= radius; x += 0.5)
            {
                if ( (x * x) + (y * y) >= radius * radius)
                    Console.Write("-");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public override float CalculateArea()
    {
        Console.WriteLine("Insert a Radius of Circle");
        var radius = Int32.Parse(Console.ReadLine());

        var area = Pi * MathF.Pow(radius, 2);

        Console.WriteLine("Area = {0}", area);
        Console.WriteLine();
        return area;
    }

    public override void CalculatePerimeter()
    {
        Console.WriteLine("Insert a Radius of Circle");
        var radius = Int32.Parse(Console.ReadLine());
        var perimeter = 2 * Pi * radius;

        Console.WriteLine("Perimeter of Circle = {0}", perimeter);
        Console.WriteLine();
    }

    public override void CalculateVolume()
    {
        Console.WriteLine("Insert a Radius of Circle");
        var radius = Int32.Parse(Console.ReadLine());
        
        var volume = (4 * (Pi * Math.Pow(radius, 3))) / 3;
        Console.WriteLine("Volume of  Circle = {0}", volume);
        Console.WriteLine();
    }
}