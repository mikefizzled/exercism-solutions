public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> uniqueLetters = new HashSet<char>();

        foreach(char c in input.ToLower())
        {
            if (char.IsLetter(c))
                uniqueLetters.Add(c);
        }
        return uniqueLetters.Count == 26;
    }
}
