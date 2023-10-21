using ConsoleProgram;

namespace DevAndBuildTools.Tests;

[TestFixture]
public class CountMaxNumberConsecutiveLatinLetters
{
    [Test]
    [TestCase("abcd", ExpectedResult = 1)]
    [TestCase("a", ExpectedResult = 1)]
    [TestCase("aab", ExpectedResult = 1)]
    [TestCase("abcabb", ExpectedResult = 2)]
    public int WhenValidInputThenValidResult(string source)
    {
        return Program.GetMaxNumberConsecutiveIdenticalLatinLetters(source);
    }

    [Test]
    public void WhenInputIsEmptyThenResultIsZero()
    {
        var source = string.Empty;
        var expected = 0;

        var actual = Program.GetMaxNumberConsecutiveIdenticalLatinLetters(source);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void WhenInputIsNullThenThrowException()
    {
        string? source = null;

        Assert.Throws<ArgumentNullException>(() => Program.GetMaxNumberConsecutiveIdenticalLatinLetters(source));
    }
}
