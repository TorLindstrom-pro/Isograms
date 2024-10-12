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
    
    [Test]
    public void MultipleUniqueLetters_IsIsogram()
    {
        // Act
        var result = Kata.IsIsogram("abc");

        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void MixedUniqueAndRepeatingLetters_IsNotIsogram()
    {
        // Act
        var result = Kata.IsIsogram("abcabc");

        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void SameLetters_DifferentCase_IsNotIsogram()
    {
        // Act
        var result = Kata.IsIsogram("abcABC");

        // Assert
        Assert.That(result, Is.False);
    }
}