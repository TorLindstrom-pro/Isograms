using Isograms;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SingleLetter_IsIsogram()
    {
        // Act
        var result = Kata.IsIsogram("a");

        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void RepeatingLetters_IsNotIsogram()
    {
        // Act
        var result = Kata.IsIsogram("aa");

        // Assert
        Assert.That(result, Is.False);
    }
}