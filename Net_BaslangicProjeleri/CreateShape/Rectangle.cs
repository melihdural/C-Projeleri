namespace Net_BaslangicProjeleri.CreateShape;

public class Rectangle : Shape
{
    public override void Draw(int size)
    {
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
    }
}