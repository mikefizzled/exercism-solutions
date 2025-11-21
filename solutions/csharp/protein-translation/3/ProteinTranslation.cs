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

        int index = 0;
        string dictValue = "";
    
        while(index <= strand.Length - 3 && ProteinPairs[strand.Substring(index, 3)] != "STOP") 
        {
            dictValue = ProteinPairs[strand.Substring(index, 3)];
            codons.Add(dictValue);
            index += 3;         
        }

        return codons.ToArray();
    }
}