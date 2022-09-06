namespace MyApp.Tests;

public class LeapYearTests
{
    [Fact]
    public void calculate_if_leap_year_true()
    {
           // Arrange

        //Act
        var IsLeapYear = Year.isLeapYear(2016);

        // Assert
        IsLeapYear.Should().Be(true);
    }

    [Fact]
    public void calculate_if_leap_year_false()
    {
           // Arrange

        //Act
        var IsLeapYear = Year.isLeapYear(7);

        // Assert
        IsLeapYear.Should().Be(false);
    }

    [Fact]
    public void calculate_if_leap_year_divisible_by_400_true()
    {
           // Arrange
        //Act
        var IsLeapYear = Year.isLeapYear(800);

        // Assert
        IsLeapYear.Should().Be(true);
    }

    [Fact]
    public void check_if_output_is_yay_leap_year_true()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        
        // When
        Year.isInputLeapYear("800");
        
        // Then
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

    [Fact]
    public void check_if_output_is_nay_leap_year_false()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        
        // When
        Year.isInputLeapYear("1000");
        
        // Then
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }
}


