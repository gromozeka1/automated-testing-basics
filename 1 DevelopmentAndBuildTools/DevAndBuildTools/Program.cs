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

        Console.Write("Count the maximum number of consecutive identical letters of the Latin alphabet in a line: ");
        Console.WriteLine(GetMaxNumberConsecutiveIdenticalLatinLetters(input));

        Console.Write("Count the maximum number of consecutive identical digits in a line: ");
        Console.WriteLine(GetMaxNumberConsecutiveIdenticalDigits(input));
    }

    /// <summary>
    /// Calculate total number of unique chars in source string.
    /// </summary>
    /// <param name="source">Source string</param>
    /// <returns>Number of unique chars</returns>
    private static int GetTotalNumberUniqueChars(string source)
    {
        HashSet<char> uniqueChars = new();
        foreach (var @char in source)
        {
            uniqueChars.Add(@char);
        }

        return uniqueChars.Count;
    }

    /// <summary>
    /// Calculate maximum number of unique consecutive chars in source string.
    /// </summary>
    /// <param name="source">Source string</param>
    /// <returns>Maximum number of unique consecutive chars</returns>
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

    /// <summary>
    /// Calculate the maximum number of consecutive identical letters of the Latin alphabet in a line
    /// </summary>
    /// <param name="source">Source string</param>
    /// <returns>Maximum number of consecutive identical letters of the Latin alphabet</returns>
    private static int GetMaxNumberConsecutiveIdenticalLatinLetters(string source)
    {
        int totalMax = 0;
        int counter = 0;
        for (int i = 0; i < source.Length - 1; i++)
        {
            if (IsLatinLetter(source[i]) && source[i] == source[i + 1])
            {
                counter++;
                while (source[i] == source[i + 1])
                {
                    counter++;
                    i++;
                }
            }
            else
            {
                totalMax = Math.Max(totalMax, counter);
                counter = 0;
            }
        }

        return Math.Max(counter, totalMax);

        static bool IsLatinLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
    }

    /// <summary>
    /// Calculate the maximum number of consecutive identical digits in a line
    /// </summary>
    /// <param name="source">Source string</param>
    /// <returns>Naximum number of consecutive identical digits</returns>
    private static int GetMaxNumberConsecutiveIdenticalDigits(string source)
    {
        int totalMax = 0;
        int counter = 0;
        for (int i = 0; i < source.Length - 1; i++)
        {
            if (char.IsDigit(source[i]) && source[i] == source[i + 1])
            {
                counter++;
            }
            else
            {
                totalMax = Math.Max(totalMax, counter);
                counter = 0;
            }
        }

        return Math.Max(counter, totalMax);
    }
}
