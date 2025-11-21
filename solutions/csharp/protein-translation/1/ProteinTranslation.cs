using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    private static Dictionary<string, string> ProteinPairs = new Dictionary<string, string> { 
            { "AUG", "Methionine" },
            { "UUU", "Phenylalanine"}, { "UUC","Phenylalanine"},
            { "UUA", "Leucine"} , { "UUG", "Leucine"},
            { "UCU", "Serine"}, { "UCC", "Serine"},{ "UCA", "Serine"}, { "UCG", "Serine"},
            { "UAU", "Tyrosine"}, { "UAC", "Tyrosine"},
            { "UGU", "Cysteine"}, { "UGC", "Cysteine"},
            { "UGG", "Tryptophan"},
            { "UAA", "STOP"}, { "UAG", "STOP"}, { "UGA", "STOP"}};
    
    public static string[] Proteins(string strand)
    {
        List<string> codons = new List<string>();

        string dictValue = "";
        int index = 0;
        while(index <= strand.Length -1 && dictValue != "STOP") 
        {
            dictValue = ProteinPairs[strand.Substring(index, 3)];
            index += 3;
            if (dictValue != "STOP")
                codons.Add(dictValue);
        }
        return codons.ToArray();
    }
}