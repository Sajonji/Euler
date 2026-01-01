namespace ProjectEuler.Problems0To10;

public static class OddSquareNumbers
{
    public static long GetSumOddSquareNumbers(int upperBound)
    {
        long sum = 0;

        for (long i = 1; i <= upperBound; i += 2)
        {
            sum += i*i;
        }

        return sum;
    }
}