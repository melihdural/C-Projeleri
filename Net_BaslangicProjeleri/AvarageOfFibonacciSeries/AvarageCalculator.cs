namespace Net_BaslangicProjeleri.AvarageOfFibonacciSeries;

public class AvarageCalculator
{
    public string Avarage()
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
        
        
        return String.Format("{0:0,0}", overall/fibonacciSeries.Length);
            
    }
}