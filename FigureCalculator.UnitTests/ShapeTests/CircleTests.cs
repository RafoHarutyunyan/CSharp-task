﻿using FluentAssertions;
using FigureCalculator.Core.Exceptions;
using FigureCalculator.Core.Shapes;

namespace FigureCalculator.UnitTests.ShapeTests;

public class CircleTests
{
    [Theory]
    [InlineData(1d)]
    [InlineData(2d)]
    [InlineData(3d)]
    [InlineData(4d)]
    [InlineData(5d)]
    [InlineData(6d)]
    [InlineData(1000000d)]
    public void SuccessfulCreation_CorrectParameters(double radius)
    {
        var method = () => new Circle(radius);
        method.Should().NotThrow();
    }

    [Theory]
    [InlineData(-1d)]
    [InlineData(-2d)]
    public void FailCreationWithNegativeParameterException_NegativeRadius(double radius)
    {
        var method = () => new Circle(radius);
        method.Should().Throw<NegativeException>();
    }

    [Fact]
    public void FailCreationWithZeroParameterException_ZeroRadius()
    {
        var method = () => new Circle(0);
        method.Should().Throw<ZeroException>();
    }
}
