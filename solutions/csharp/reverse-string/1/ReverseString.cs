using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        int size = input.Length;
        StringBuilder sb = new StringBuilder();

        for (int i = size - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }
        return sb.ToString();
    }
}