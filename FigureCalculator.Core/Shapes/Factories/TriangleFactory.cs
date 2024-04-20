using FigureCalculator.Core.Interfaces;

namespace FigureCalculator.Core.Shapes.Factories;

public class TriangleFactory : IShapeFactory
{
    public string Type => nameof(Triangle);

    public IShapeArea Parse(params double[] parameters)
    {
        return new Triangle(parameters[0], parameters[1], parameters[2]);
    }
}
