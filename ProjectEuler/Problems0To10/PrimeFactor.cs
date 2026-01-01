namespace ProjectEuler.Problems0To10;

public static class PrimeFactor
{
    public static int GetLargestPrimeFactor(long number)
    {
        var primeFactors = ComputePrimeFactors(number);
        
        return primeFactors.Max();
    }

    public static List<int> GetAllPrimeFactors(long number)
    {
        return ComputePrimeFactors(number);
    }

    private static List<int> ComputePrimeFactors(long number)
    {
        List<int> primeFactors = [];

        while(number > 1)
        {
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    primeFactors.Add(i);
                    number /= i;
                    break;
                }
            }
        }
        
        return primeFactors;
    }
}