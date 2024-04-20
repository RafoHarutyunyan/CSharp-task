using FigureCalculator.Core.Exceptions;
using FigureCalculator.Core.Interfaces;

namespace FigureCalculator.Core.Shapes;

public  class Circle : IShapeArea
{
    public Circle(double radius)
    {
        FigureExceptions.ThrowNegativeOrZero(radius, nameof(radius));

        Radius = radius;
    }

    public double Radius { get; }

    public double CalculateArea()
    {
        var result = Radius * Radius * Math.PI;
        return result;
    }
}
