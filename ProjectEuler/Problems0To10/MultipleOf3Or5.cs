namespace ProjectEuler.Problems0To10;

public static class MultipleOf3Or5
{
    public static int GetMultipleOf3Or5(int upperBoundExclusive)
    {
        var sum = 0;

        for (int i = 0; i < upperBoundExclusive; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}