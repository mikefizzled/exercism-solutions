using System;

public static class ResistorColorDuo
{
    private static string[] _colors = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
    
    public static int Value(string[] colors)
    {
        string resistance = "";
        for(int i = 0; i < 2; i++)
            resistance += Array.IndexOf(_colors, colors[i]);
        
        return Convert.ToInt32(resistance);
    }
}
