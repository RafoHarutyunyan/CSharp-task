using FluentAssertions;
using FigureCalculator.Core.Exceptions;
using FigureCalculator.Core.Interfaces;
using FigureCalculator.Core.Shapes;

namespace FigureCalculator.UnitTests.AbstractTests;

public abstract class AbstractShapeConstructorTests
{
    protected abstract IShapeConstructor ShapeConstructor { get; }

    [Theory]
    [MemberData(nameof(AppropriateParametersForCreation))]
    public void Construct_ShouldCreateCorrectShapes_CorrectParametersForCreation(
        object expected,
        string type,
        double[] parameters)
    {
        var actual = ShapeConstructor.Construct(type, parameters);

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Construct_ShouldThrowShapeConstructorException_UnknownType()
    {
        const string type = "Unknown";
        var parameters = new double[10];

        var method = () => ShapeConstructor.Construct(type, parameters);

        method.Should().Throw<ShapeCreatingException>();
    }

    [Fact]
    public void Construct_ShouldThrowArgumentOutOfRangeException_WrongCountOfArguments()
    {
        const string type = nameof(Triangle);
        var parameters = new double[2];

        var method = () => ShapeConstructor.Construct(type, parameters);

        method.Should().Throw<IndexOutOfRangeException>();
    }

    public static IEnumerable<object[]> AppropriateParametersForCreation()
    {
        yield return new object[] { new Circle(3), nameof(Circle), new double[] { 3 } };
        yield return new object[] { new Circle(4.5), nameof(Circle), new[] { 4.5 } };
        yield return new object[] { new Circle(200), nameof(Circle), new double[] { 200 } };
        yield return new object[] { new Triangle(4, 4, 6), nameof(Triangle), new double[] { 4, 4, 6 } };
        yield return new object[] { new Triangle(150, 150, 100), nameof(Triangle), new double[] { 150, 150, 100 } };
        yield return new object[] { new Triangle(12, 24,24 ), nameof(Triangle), new double[] { 12, 24, 24 } };
    }
}
