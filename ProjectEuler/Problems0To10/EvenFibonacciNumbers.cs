namespace ProjectEuler.Problems0To10;

public static class EvenFibonacciNumbers
{
    public static int GetSumEvenFibonacciNumbersSmaller4Million()
    {
        var sum = 0;

        var current = 1;
        var previous = 1;

        while(current < 4_000_000)
        {
            if (current % 2 == 0)
            {
                sum += current;
            }

            var next = current + previous;
            previous = current;
            current = next;            
        }

        return sum;
    }
}