namespace Net_BaslangicProjeleri.CalculationOfIntegers;

public class CalculatePairs
{
    public void Calculate()
    {
        Console.WriteLine("Insert as many integer pairs as you want and when finished type ''Done''!");
                
        var sumsOfIntegers = new List<int>();
        while (true)
        {
            var insert = Console.ReadLine();
            if (insert == "Done" || insert == "done") break;
            var pairs = insert.Split();
                    
            var sum = Int32.Parse(pairs[0]) + Int32.Parse(pairs[1]);
            if (pairs[0] == pairs[1])
            {
                            
                sumsOfIntegers.Add((int)MathF.Pow(sum,2));
            }
            else
            {
                sumsOfIntegers.Add(sum);
            }
                    
        }
                
        foreach (var i in sumsOfIntegers)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}