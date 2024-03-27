using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

[TestFixture]
public class ProgramTests
{
    private string testFilePath;

    [SetUp]
    public void Setup()
    {
        // Create a temporary test file
        testFilePath = Path.GetTempFileName();
        File.WriteAllText(testFilePath, "SWIFT123456789  1000.00USD20220101BICCODE123");
    }

    [TearDown]
    public void Cleanup()
    {
        // Delete the temporary test file
        File.Delete(testFilePath);
    }

    [Test]
    public void Main_ValidFile_AddsSwiftBicsToDatabase()
    {
        // Arrange
        var expectedSwiftBics = new List<SwiftBic>
        {
            new SwiftBic
            {
                SwiftCode = "SWIFT123456789",
                PaymentAmount = 1000.00m,
                PaymentCurrency = "USD",
                PaymentDate = new DateTime(2022, 01, 01),
                BicCode = "BICCODE123"
            }
        };

        // Act
        Program.Main();

        // Assert
        using (var context = new DbContext())
        {
            var actualSwiftBics = context.Set<SwiftBic>().ToList();
            CollectionAssert.AreEqual(expectedSwiftBics, actualSwiftBics);
        }
    }

    [Test]
    public void Main_InvalidFile_ShowsErrorMessage()
    {
        // Arrange
        File.WriteAllText(testFilePath, "InvalidLine");

        // Act
        Program.Main();

        // Assert
        StringAssert.Contains("An error occurred with file", Console.Out.ToString());
    }

    [Test]
    public void IsValid_ValidSwiftBic_ReturnsTrue()
    {
        // Arrange
        var swiftBic = new SwiftBic
        {
            SwiftCode = "SWIFT123456789",
            PaymentAmount = 1000.00m,
            PaymentCurrency = "USD",
            PaymentDate = new DateTime(2022, 01, 01),
            BicCode = "BICCODE123"
        };

        // Act
        var isValid = Program.IsValid(swiftBic);

        // Assert
        Assert.IsTrue(isValid);
    }

    // Add more test cases for different scenarios

}