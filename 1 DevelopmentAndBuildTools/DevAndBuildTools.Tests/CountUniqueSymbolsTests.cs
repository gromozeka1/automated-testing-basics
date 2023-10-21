using ConsoleProgram;

namespace DevAndBuildTools.Tests;

[TestFixture]
public class CountUniqueSymbolsTests
{
    [Test]
    [TestCase("abcd", ExpectedResult = 4)]
    [TestCase("a", ExpectedResult = 1)]
    [TestCase("aab", ExpectedResult = 2)]
    [TestCase("abcabb", ExpectedResult = 5)]
    public int WhenValidInputThenValidResult(string source)
    {
        return Program.GetMaxNumberUniqueCharsSeq(source);
    }

    [Test]
    public void WhenInputIsEmptyThenResultIsZero()
    {
        var source = string.Empty;
        var expected = 0;

        var actual = Program.GetMaxNumberUniqueCharsSeq(source);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void WhenInputIsNullThenThrowException()
    {
        string? source = null;

        Assert.Throws<ArgumentNullException>(() => Program.GetMaxNumberUniqueCharsSeq(source));
    }
}