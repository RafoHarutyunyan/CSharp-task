using FluentAssertions;
using FigureCalculator.Core.Calculators;
using FigureCalculator.Core.Interfaces;
using FigureCalculator.Core.Shapes;

namespace FigureCalculator.UnitTests.AbstractTests;

public abstract class AbstractCalculatorTests
{
    protected abstract double Call(object shapeWithArea);

    [Theory]
    [MemberData(nameof(GetAppropriateTestData))]
    public void ShouldReturnCorrectArea_CorrectShape(IShapeArea shapeArea, double expected)
    {
        var actual = Call(shapeArea);

        actual.Should().BeApproximately(expected, Constants.Exactness);
    }

    public static IEnumerable<object[]> GetAppropriateTestData()
    {
        yield return new object[] { new Circle(2),2 * 2 * Math.PI };
        yield return new object[] { new Circle(30), 30 * 30 * Math.PI };
        yield return new object[] { new Circle(125), 125 * 125 * Math.PI };
        yield return new object[] { new Triangle(5, 4, 3), 6 };
        yield return new object[] { new Triangle(25, 16, 10), 43.329406873 };
        yield return new object[] { new Triangle(5, 5, 8), 12 };
    }
}
