class Program
{
    static void Main()
    {
        Console.Write("Please enter symbols: ");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();
        
        Console.Write("Count of unique symbols: ");
        Console.WriteLine(GetTotalNumberUniqueChars(input));

        Console.Write("Count of unique symbols in sequence: ");
        Console.WriteLine(GetMaxNumberUniqueCharsSeq(input));
    }

    private static int GetTotalNumberUniqueChars(string source)
    {
        HashSet<char> uniqueChars = new();
        foreach (var @char in source)
        {
            uniqueChars.Add(@char);
        }

        return uniqueChars.Count;
    }

    private static int GetMaxNumberUniqueCharsSeq(string source)
    {
        int max = 1;
        int totalMax = 0;

        for (int i = 1; i < source.Length; i++)
        {
            if (source[i] != source[i - 1])
            {
                max++;
            }
            else
            {
                totalMax = Math.Max(max, totalMax);
                max = 1;
            }
        }

        return Math.Max(max, totalMax);
    }
}
