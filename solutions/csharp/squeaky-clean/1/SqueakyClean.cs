using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder(identifier.Length);

        bool kebabNext = false;
        for(int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];
            if(char.IsWhiteSpace(c))
                sb.Append('_');
            else if (char.IsDigit(c))
                sb.Append("");
            else if (char.IsControl(c))
                sb.Append("CTRL");
            else if (c == '-')
                kebabNext = true;
            else if(!char.IsLetterOrDigit(c) && !char.IsPunctuation(c))
                sb.Append("");
            else if(((int)c >= (int)'α') && ((int)c <= (int)'ω'))
                sb.Append("");
            else if (kebabNext)
                {
                    sb.Append(char.ToUpper(c));
                    kebabNext = false;
                }
            else
                sb.Append(c);
        }
    
        return sb.ToString();
        throw new NotImplementedException($"Please implement the (static) Identifier.Clean() method");
    }
}