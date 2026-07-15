using System.Collections.Generic;

public static class BottleSong
{
    private static readonly string[] NumberWords =
    {
        "no", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
    };


    private static string Capitalise(string text) => char.ToUpper(text[0]) + text.Substring(1);

    private static string PluralSuffix(int number) => number == 1 ? string.Empty : "s";
    
    public static IEnumerable<string> Recite(int bottles, int takeDown)
    {
        for (int i = 0; i < takeDown; i++)
        {
            string capitalised = Capitalise(NumberWords[bottles]);
            string currentPlural = PluralSuffix(bottles);
            string nextPlural = PluralSuffix(bottles - 1);

            yield return $"{capitalised} green bottle{currentPlural} hanging on the wall,";
            yield return $"{capitalised} green bottle{currentPlural} hanging on the wall,";
            yield return "And if one green bottle should accidentally fall,";
            yield return $"There'll be {NumberWords[bottles - 1]} green bottle{nextPlural} hanging on the wall.";

            bottles--;

            // Add a blank line between verses, but not after the final verse
            if (i < takeDown - 1)
            {
                yield return "";
            }
        }
    }
}
