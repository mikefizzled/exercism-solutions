using System;
using System.Text;

public static class PigLatin
{
    public static string Translate(string word)
    {
        string[] words = word.Split(' ');
        StringBuilder sb = new StringBuilder();
        foreach(string s in words)
        {
            if(StartsWithVowel(s))
                sb.Append($"{s}ay ");
            else
                sb.Append($"{ConsonantRules(s)} ");
        }
        return sb.ToString().Trim();
    }
    
    private static bool StartsWithVowel(string word)
    {
        bool vowel = "aeiou".IndexOf(word[0]) >= 0;
        bool vowelExtras = word.StartsWith("xr") || word.StartsWith("yt");
        return vowel || vowelExtras;
    }
    private static string ConsonantRules(string word)
    {
        int vowelIndex = -1;
        if(word.StartsWith("qu"))
            vowelIndex = 2;
        else if (word.StartsWith("y"))
            vowelIndex = 1;
        else
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < word.Length; i++)
            {
                vowelIndex = word.IndexOfAny(vowels);
                if (vowelIndex > 0 && word[vowelIndex - 1] == 'q' && word[vowelIndex] == 'u')
                    vowelIndex++;
            }
        }

        if (vowelIndex >= 0)
            word = string.Concat(word.AsSpan(vowelIndex), word.Substring(0, vowelIndex), "ay");
        return word;
    }

}