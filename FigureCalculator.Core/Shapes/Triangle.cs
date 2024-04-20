using FigureCalculator.Core.Calculators;
using FigureCalculator.Core.Exceptions;
using FigureCalculator.Core.Interfaces;

namespace FigureCalculator.Core.Shapes;

public class Triangle : IShapeArea, IRightTriangleCheck
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        FigureExceptions.ThrowNegativeOrZero(sideA, nameof(sideA));
        FigureExceptions.ThrowNegativeOrZero(sideB, nameof(sideB));
        FigureExceptions.ThrowNegativeOrZero(sideC, nameof(sideC));
        var biggerSide = Math.Max(sideA, Math.Max(sideB, sideC));
        var otherTwoSides = sideA + sideB + sideC - biggerSide;
        if (biggerSide >= otherTwoSides)
            throw new TriangleException();
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double SideA { get; }

    public double SideB { get; }

    public double SideC { get; }


    public bool CheckIsRight()
    {
        var hypotenuseSquare = Math.Max(SideA, Math.Max(SideB, SideC));
        hypotenuseSquare *= hypotenuseSquare;
        var sideSquaresSum = SideA * SideA + SideB * SideB + SideC * SideC;
        var result = Math.Abs(sideSquaresSum - hypotenuseSquare * 2) < Constants.Exactness;
        return result;
    }

    public double CalculateArea()
    {
        var halfOfPerimeter = (SideA + SideB + SideC) / 2d;
        var result = Math.Sqrt(halfOfPerimeter *
                               (halfOfPerimeter - SideA) *
                               (halfOfPerimeter - SideB) *
                               (halfOfPerimeter - SideC));
        return result;
    }
}
