using ProjectEuler.Problems0To10;

namespace ProjectEulerTests;

public class Problems0To10Tests
{
    [Fact]
    public void GetSumOddSquareNumbers_5_35()
    {
        var expected = 35;

        var actual = OddSquareNumbers.GetSumOddSquareNumbers(5);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSumOddSquareNumbers_340000_6550666666610000()
    {
        var expected = 6550666666610000;

        var actual = OddSquareNumbers.GetSumOddSquareNumbers(340000);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMultipleOf3Or5_10_23()
    {
        var expected = 23;

        var actual = MultipleOf3Or5.GetMultipleOf3Or5(10);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMultipleOf3Or5_1000_233168()
    {
        var expected = 233168;

        var actual = MultipleOf3Or5.GetMultipleOf3Or5(1000);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSumEvenFibonacciNumbersSmaller4Million_CorrectValue()
    {
        var expected = 4613732;

        var actual = EvenFibonacciNumbers.GetSumEvenFibonacciNumbersSmaller4Million();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLargestPrimeFactor_13195_29()
    {
        var expected = 29;

        var actual = LargestPrimeFactor.GetLargestPrimeFactor(13195);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLargestPrimeFactor_600851475143_6857()
    {
        var expected = 6857;

        var actual = LargestPrimeFactor.GetLargestPrimeFactor(600851475143);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLargestPalindromeProduct_99_9009()
    {
        var expected = 9009;

        var actual = LargestPalindromeProduct.GetLargestPalindromeProduct(99);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLargestPalindromeProduct_999_29()
    {
        var expected = 906609;

        var actual = LargestPalindromeProduct.GetLargestPalindromeProduct(999);

        Assert.Equal(expected, actual);
    }
}