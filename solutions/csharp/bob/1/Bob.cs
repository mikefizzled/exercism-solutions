public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        if (string.IsNullOrEmpty(statement.Trim()))
            return "Fine. Be that way!";

        bool isYelled = IsYelled(statement);
        bool isQuestion = IsQuestion(statement);

        if (isYelled && isQuestion)
            return "Calm down, I know what I'm doing!";
        
        if (isYelled)
            return "Whoa, chill out!";
        
        if (isQuestion)
            return "Sure.";

        return "Whatever.";
    }

    private static bool IsYelled(string statement)
    {
        int letterTotal = 0;
        int capsTotal = 0;

        for (int i = 0; i < statement.Length; i++)
        {
            if (char.IsLetter(statement[i]))
            {
                letterTotal++;
                if (char.IsUpper(statement[i]))
                {
                    capsTotal++;
                }
            }
        }

        return letterTotal > 0 && letterTotal == capsTotal;

    }
    
    private static bool IsQuestion(string statement) => statement[^1] == '?';
}