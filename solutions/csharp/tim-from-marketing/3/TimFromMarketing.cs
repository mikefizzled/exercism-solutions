using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string formatId = id != null ? $"[{id}] - " : "";
        return $"{formatId}{name} - {(department ?? "OWNER").ToUpper()}";
    }
}
