namespace ProjectEuler.Problems0To10;

public static class PrimeNumbers
{
    public static long GetNthPrimeNumber(int n)
    {
        int counter = 1;
        long numberToTest = 3;
        List<long> primeNumbers = [2];

        while(counter < n)
        {
            var prime = true;

            var sqr = Math.Sqrt(numberToTest);

            foreach (var num in primeNumbers)
            {
                if (num > (sqr + 1))
                {
                    break;
                }

                if (numberToTest % num == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                primeNumbers.Add(numberToTest);
                counter++;
            }

            numberToTest += 2;
        }

        return primeNumbers.Last();
    }
}