public static class Bob
{
    public enum RemarkType
    {
        Question,
        Yelling,
        YelledQuestion,
        Silence,
        Other
    }

    public static string Response(string statement)
    {
        RemarkType statementType = CheckStatement(statement);

        return statementType switch
        {
            RemarkType.Question => "Sure.",
            RemarkType.Yelling => "Whoa, chill out!",
            RemarkType.YelledQuestion => "Calm down, I know what I'm doing!",
            RemarkType.Silence => "Fine. Be that way!",
            RemarkType.Other => "Whatever.",
            _ => "Whatever.",
        };
    }

    public static RemarkType CheckStatement(string statement)
    {
        statement = statement.Trim();

        if (string.IsNullOrEmpty(statement))
            return RemarkType.Silence;

        bool isYelled = IsYelled(statement);
        bool isQuestion = IsQuestion(statement);

        if (isYelled && isQuestion)
            return RemarkType.YelledQuestion;

        if (isYelled)
            return RemarkType.Yelling;

        if (isQuestion)
            return RemarkType.Question;

        return RemarkType.Other;
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
    private static bool IsQuestion(string statement) => statement.EndsWith('?');
}