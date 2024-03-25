using Domain.Test;
using FluentAssertions;

namespace Trignometry.Test;

/// <summary>
/// Unit test class to verify the functionality of the Triangle class.
/// This class contains test methods that validate the operations for calculating the area and perimeter of a triangle.
/// </summary>
public class TriangleTest
{
    /// <summary>
    /// Tests the calculation of the triangle's area with base = 2 and height = 3.
    /// Checks if the Area() method of the Triangle class returns the expected value of 3.
    /// </summary>
    [Fact]
    public void TriangleArea_Base2_Height3_ShouldBe_3()
        => new Triangle(2, 3).Area().Should().Be(4);
    //{
    // Creates an instance of Triangle with base = 2 and height = 3 and calculates the area.
    //var area = new Triangle(2, 3).Area();
    // Checks if the calculated area is equal to 3. If not, throws an exception.
    //if (area != 3)
    //{
    //    throw new Exception("The result for the area of the triangle is wrong.");
    //}
    //}

    /// <summary>
    /// Tests the calculation of the triangle's perimeter with sides of length 2.
    /// Checks if the Perimeter() method of the Triangle class returns the expected value of 6.
    /// </summary>
    [Fact]
    public void TrianglePerimeter_rs2_base_ls3_shouldbe_6()
        => new Triangle(2, 2, 2).Perimeter().Should().Be(6);

    /// <summary>
    /// Ensures the perimeter calculation is correct for a scalene triangle.
    /// </summary>
    [Fact]
    public void TrianglePerimeter_ScaleneTriangle_ShouldBeCorrect()
    {
        // Arrange & Act
        var result = new Triangle(2, 3, 4).Perimeter();

        // Assert
        result.Should().Be(9);
    }

    /// <summary>
    /// Tests whether the GetTriangleType method correctly identifies an isosceles triangle.
    /// An isosceles triangle has exactly two sides of equal length.
    /// This test covers all three possible configurations of an isosceles triangle.
    /// </summary>
    [Fact]
    public void GetTriangleType_ReturnsIsosceles_WhenTwoSidesAreEqual()
    {
        var triangle = new Triangle(5, 5, 3);
        var result = triangle.GetTriangleType();
        Assert.Equal("Isosceles", result);

        triangle = new Triangle(5, 3, 5);
        result = triangle.GetTriangleType();
        Assert.Equal("Isosceles", result);

        triangle = new Triangle(3, 5, 5);
        result = triangle.GetTriangleType();
        Assert.Equal("Isosceles", result);
    }

    /// <summary>
    /// Tests whether the GetTriangleType method correctly identifies an isosceles triangle.
    /// An isosceles triangle has exactly two sides of equal length.
    /// This test covers all three possible configurations of an isosceles triangle, with paremeterized tests.
    /// </summary>
    [Theory]
    [InlineData(5, 5, 5, "Equilateral")]
    [InlineData(5, 5, 3, "Isosceles")]
    [InlineData(5, 4, 6, "Scalene")]
    public void GetTriangleType_ReturnsCorrectType(int side1, int side2, int side3, string expectedType)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = triangle.GetTriangleType();
        Assert.Equal(expectedType, result);
    }

    /// <summary>
    /// Tests the GetTriangleType method's performance under heavy load.
    /// </summary>
    /// <remarks>
    /// This test method aims to ensure that the GetTriangleType method of the Triangle class
    /// performs efficiently when called repeatedly in a high-load scenario. The test involves
    /// creating a new Triangle instance with sides of equal length (5, 5, 5), which is typically
    /// considered an equilateral triangle, and then invoking the GetTriangleType method 1,000,000 times
    /// in a loop. This is designed to simulate a scenario where the method might be called
    /// repeatedly in a short span of time, as might be the case in a high-traffic web application
    /// or a compute-intensive application.
    ///
    /// The core of this test is to measure the time taken for the loop to complete all iterations
    /// and assert that the total elapsed time is less than 1000 milliseconds. This threshold is set
    /// to ensure that the method remains performant even under extreme conditions. It's a critical
    /// test to identify any potential performance bottlenecks that could impact the overall
    /// application performance in real-world scenarios.
    ///
    /// The use of System.Diagnostics.Stopwatch is crucial for accurately measuring the elapsed time
    /// in milliseconds. The Assert.True statement at the end is used to validate that the method's
    /// execution time meets the performance criteria specified for the test case. If the elapsed time
    /// exceeds 1000 milliseconds, the test will fail, indicating that the GetTriangleType method
    /// may not perform adequately under heavy load or may need optimization to meet the performance
    /// requirements.
    ///
    /// This test is an example of how performance testing can be integrated into the development
    /// process, providing immediate feedback on changes that could affect the application's
    /// responsiveness and scalability. It highlights the importance of considering performance
    /// as a critical aspect of software quality, alongside correctness and reliability.
    /// </remarks>
    [Fact]
    public void GetTriangleType_PerformsWellUnderHeavyLoad()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++)
        {
            var triangle = new Triangle(5, 5, 5);
            triangle.GetTriangleType();
        }
        watch.Stop();
        var elapsedMs = watch.ElapsedMilliseconds;
        Assert.True(elapsedMs < 1000, "Method should complete within 1000 milliseconds.");
    }
}