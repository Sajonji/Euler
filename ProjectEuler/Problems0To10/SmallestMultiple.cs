namespace ProjectEuler.Problems0To10;

public static class SmallestMultiple
{
    public static long GetSmallestMultiple(int upperBound)
    {
        Dictionary<int, int> powerByPrimeFactor = [];

        for (int i = upperBound; i > upperBound / 2; i--)
        {
            var primeFactors = PrimeFactor.GetAllPrimeFactors(i);
            var t = primeFactors.GroupBy(a => a);

            foreach (var group in t)
            {
                if (powerByPrimeFactor.TryGetValue(group.Key, out var power))
                {
                    if (group.Count() > power)
                    {
                        powerByPrimeFactor[group.Key] = group.Count();
                    }
                }
                else
                {
                    powerByPrimeFactor[group.Key] = group.Count();
                }
            }
        }

        long value = 1;

        foreach (var kvp in powerByPrimeFactor)
        {
            value *= Pow(kvp.Key, kvp.Value);
        }

        return value;
    }

    private static long Pow(int number, int exp)
    {
        long value = 1;

        for (int i = 0; i < exp; i++)
        {
            value *= number;
        }

        return value;
    }
}