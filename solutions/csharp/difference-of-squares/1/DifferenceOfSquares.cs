public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int numberToSquare = 0;
        for (int i = 0; i <= max; i++)
        {
            numberToSquare += i;
        }
        return numberToSquare * numberToSquare;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int total = 0;
        for (int i = 0; i <= max; i++)
        {
            total += i * i;
        }
        return total;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}