using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < takeDown; i++)
        {
            sb.Append(FirstLine(startBottles));
            sb.Append(SecondLine(startBottles));
            if(i+1 < takeDown)
                sb.Append("\n\n");
            startBottles--;
        }
        return sb.ToString();
    }
    public static string FirstLine(int startBottles)
    {
        string plural = startBottles > 1 ? "bottles" : "bottle";
        switch(startBottles)
        {
            case 0: return "No more bottles of beer on the wall, no more bottles of beer.\n";
            default: return $"{startBottles} {plural} of beer on the wall, {startBottles} {plural} of beer.\n";
        }
    }
    public static string SecondLine(int startBottles)
    {
        switch(startBottles)
        {
            case 2: return "Take one down and pass it around, 1 bottle of beer on the wall.";
            case 1: return "Take it down and pass it around, no more bottles of beer on the wall.";
            case 0: return "Go to the store and buy some more, 99 bottles of beer on the wall.";
            default: return $"Take one down and pass it around, {(startBottles - 1)} bottles of beer on the wall.";
        }
    }
}