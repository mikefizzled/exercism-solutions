using System.Text;

public static class RotationalCipher
{
    public const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in text)
        {
            if(char.IsUpper(c))
            {
                sb.Append(PerformRotate(c, shiftKey, true));
            }
            else if(char.IsLower(c))
            {
                sb.Append(PerformRotate(c, shiftKey, false));
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    public static char PerformRotate(char c, int shiftKey, bool isUpper)
    {
        int index = Alphabet.IndexOf(char.ToLower(c));
        char x = Alphabet[((index + shiftKey) % 26)];
        
        if(isUpper)
            return char.ToUpper(x);
        else
            return x;
    }
}