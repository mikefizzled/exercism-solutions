public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> uniqueLetters = new HashSet<char>();
        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                if (!uniqueLetters.Add(char.ToLowerInvariant(c)))
                {
                    return false;
                }
            }
            
        }
        return true;
    }
}