namespace ProjectEuler.Problems0To10;

public static class LargestPalindromeProduct
{
    public static int GetLargestPalindromeProduct(int upperBound)
    {
        var max = 0;

        for (int i = upperBound; i >= 0; i--)
        {
            if (max > i * 999)
            {
                break;
            }

            for (int j = upperBound; j >= 0; j--)
            {
                var num = i * j;

                if (num <= max)
                {
                    break;
                }

                if (IsPalindrome(num))
                {
                    max = num;
                }
            }
        }

        return max;
    }

    private static bool IsPalindrome(int number)
    {
        int original = number;
        int reversed = 0;

        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }

        return original == reversed;
    }
}