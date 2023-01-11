namespace Net_BaslangicProjeleri.CreateShape;

public class SelectShape
{
    internal static Shape? Select()
    {
        Console.WriteLine("Which Shape Did You Want");
        Console.WriteLine("[1] Rectangle");
        Console.WriteLine("[2] Circle");

        var input = Console.ReadLine();

        Shape? selectedShape = input switch
        {
            "1" => new Rectangle(),
            "2" => new Circle(),
            _ => null
        };

        return selectedShape;
    }

    internal static void StartDrawProgram(Shape shape)
    {
        shape.Draw();
    }
    
    internal static void StartCalculationProgram(Shape shape, string calculation)
    {
        switch (calculation)
        {
            case "1":
                shape.CalculateArea();
                break;
            case "2":
                shape.CalculatePerimeter();
                break;
            case "3":
                shape.CalculateVolume();
                break;
        }
    }
    
}