using FigureCalculator.Core.Interfaces;

namespace FigureCalculator.Core.Shapes.Factories;

public class CircleFactory : IShapeFactory
{
    public string Type => nameof(Circle);

    public IShapeArea Parse(params double[] parameters)
    {
        return new Circle(parameters[0]);
    }
}
