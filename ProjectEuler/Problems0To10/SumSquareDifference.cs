namespace ProjectEuler.Problems0To10;

public static class SumSquareDifference
{
    public static long GetSumSquareDifference(int upperBound)
    {
        return (upperBound * upperBound * (upperBound + 1) * (upperBound +1) / 4)  - (upperBound * (upperBound + 1) * (2 * upperBound + 1) / 6);
    }
}