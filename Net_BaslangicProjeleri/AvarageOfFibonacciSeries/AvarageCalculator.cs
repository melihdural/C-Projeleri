namespace Net_BaslangicProjeleri.AvarageOfFibonacciSeries;

public class AvarageCalculator
{
    public void Avarage()
    {
        int length = 0;
        float overall = 0;
        
        Console.WriteLine("Set a Length for Fibonacci Series!");
        length = Int32.Parse(Console.ReadLine());

        FibonacciCreator creator = new FibonacciCreator();
        var fibonacciSeries = creator.FibonacciSeries(length);
            
        Console.WriteLine("Fibonacci Series");
        foreach (var number in fibonacciSeries)
        {
            Console.Write(number + ", ");
            overall += number;
        }
        
        
        var average = $"{overall / fibonacciSeries.Length:0,0}";
        
        Console.WriteLine();
        Console.WriteLine("Average of FibonacciSeries = {0}", average);
        Console.WriteLine();
            
    }
}