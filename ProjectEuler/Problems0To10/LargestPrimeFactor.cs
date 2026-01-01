namespace ProjectEuler.Problems0To10;

public static class LargestPrimeFactor
{
    public static int GetLargestPrimeFactor(long number)
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
        
        return primeFactors.Max();
    }
}