namespace Net_BaslangicProjeleri.Absolute_Squaring;

public class AbsoluteSquare
{
    private int _sumOfDifference = 0;
    private double _absoluteSquaring = 0;
    
    public void AbsoluteSquaring()
    {
        Console.WriteLine("Insert as many integer as you want and when finished type ''Done''!");
        var numbers = new List<int>();
        while (true)
        {
            var insert = Console.ReadLine();
            if (insert == "Done" || insert == "done") break;
            var split = insert.Split();
            foreach (var number in split)
            {
                numbers.Add(int.Parse(number));
            }
        }

        var lower = numbers.Where(x => x < 67).ToList();
        var higher = numbers.Where(x => x > 67).ToList();
        
        foreach (var i in lower)
        {
            _sumOfDifference += 67 - i;
        }

        Console.WriteLine("The sum of the differences of those less than 67 = {0}", _sumOfDifference);
        Console.WriteLine();
        
        foreach (var i in higher)
        {
            var difference = i - 67;
            var pow = Math.Pow(difference, 2);
            _absoluteSquaring += pow;
        }

        Console.WriteLine("Sum of the absolute squares of differences greater than 67 = {0}", _absoluteSquaring);
        Console.WriteLine();
    }
}