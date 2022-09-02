namespace MyApp.Tests;

public class LeapYearTests
{
    [Fact]
    public void calculate_if_leap_year_true()
    {
           // Arrange
        var year = new Year();

        //Act
        var IsLeapYear = year.isLeapYear(2016);

        // Assert
        IsLeapYear.Should().Be(true);
    }

    [Fact]
    public void calculate_if_leap_year_false()
    {
           // Arrange
        var year = new Year();

        //Act
        var IsLeapYear = year.isLeapYear(7);

        // Assert
        IsLeapYear.Should().Be(false);
    }

    [Fact]
    public void calculate_if_leap_year_divisible_by_400_true()
    {
           // Arrange
        var year = new Year();

        //Act
        var IsLeapYear = year.isLeapYear(800);

        // Assert
        IsLeapYear.Should().Be(true);
    }
}
