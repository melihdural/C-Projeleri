namespace Net_BaslangicProjeleri.AvarageOfFibonacciSeries;

public class FibonacciCreator
{
    public int[] FibonacciSeries(int depth)
    {
        int[] fibonacciSeries = new int[depth];

        for (int i = 0; i < depth; i++)
        {
            if (i == 0 || i == 1)
            {
                fibonacciSeries[i] = i;
            }
            else
            {
                fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
            }
        }

        return fibonacciSeries;
    }
}