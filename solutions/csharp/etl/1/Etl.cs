public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> newValues = new ();

        foreach (var pair in old)
        {
            foreach (string s in pair.Value)
            {
                newValues.Add(s.ToLowerInvariant(), pair.Key);
            }
        }
        
        return newValues;
    }
}