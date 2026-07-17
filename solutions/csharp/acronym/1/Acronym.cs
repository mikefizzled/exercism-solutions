using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        StringBuilder sb = new StringBuilder();

        char[] delimiters = { ' ', '-', '_'};
        string[] parts = phrase.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string part in parts)
        {
            sb.Append(part[0]);
        }
        
        return sb.ToString().ToUpper();
    }
}