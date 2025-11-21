using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder sb = new StringBuilder();
            for(int i = 0; i < takeDown; i++)
            {
                if(startBottles > 1){
                    string firstPlural = startBottles > 1 ? $"{startBottles} bottles" : "1 bottle";
                    string secondPlural;
                    if(startBottles - 1 > 1)
                        secondPlural = $"{startBottles-1} bottles";
                    else if (startBottles -1 == 1)
                        secondPlural = "1 bottle";
                    else
                        secondPlural = "no more bottles";
                
                    sb.Append($"{firstPlural} of beer on the wall, {firstPlural} of beer.\n");
                    sb.Append($"Take {((startBottles - 1) > 0 ? "one" : "it")} down and pass it around, {secondPlural} of beer on the wall.");
                }
                else if (startBottles == 1){
                    sb.Append("1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.");  
                }
                else{
                     sb.Append("No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.");
                }
                if(i+1 < takeDown)
                    sb.Append("\n\n");
                startBottles--;
            }
        return sb.ToString();
    }
}