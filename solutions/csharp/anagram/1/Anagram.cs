public class Anagram
{
    string start;
    char[] letters;

    public Anagram(string baseWord)
    {
        start = baseWord.ToLowerInvariant();
        letters = start.ToCharArray();
        Array.Sort(letters);
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> results = new();
        foreach (string potential in potentialMatches)
        {
            string lowerPotential = potential.ToLowerInvariant();
            
            if (lowerPotential.Length != start.Length) continue;
            
            if (lowerPotential == start)  continue;
            
            if (CheckAnagram(lowerPotential))
            {
                results.Add(potential);    //adding the original capitalisation to satisfy tests
            }
        }
        return results.ToArray();
    }
    public bool CheckAnagram(string potential)
    {
        char[] potentialArray = potential.ToCharArray();
        Array.Sort(potentialArray);
        for(int i = 0; i < potentialArray.Length; i++)
        {
            if (potentialArray[i] != letters[i])
            {
                return false;
            }
        }
        return true;
    }
}