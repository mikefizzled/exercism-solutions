public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> set = new HashSet<int>();
        
        foreach (int multiple in multiples)
        {
            if (multiple == 0)
                continue;

            // starting at the first multiple
            // keep adding the original multiple until larger than max
            for (int j = multiple; j < max; j += multiple)
            {
                set.Add(j);
            }
        }

        return set.Sum();
    }
}