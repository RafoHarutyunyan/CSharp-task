using FigureCalculator.Core.Exceptions;
using FigureCalculator.Core.Interfaces;
using FigureCalculator.Core.Shapes;

namespace FigureCalculator.Core.FigureCreators;

public class ShapeSwitchConstructor : IShapeConstructor
{
    public IShapeArea Construct(string type, params double[] parameters)
    {
        return type switch
        {
            nameof(Circle) => new Circle(parameters[0]),
            nameof(Triangle) => new Triangle(parameters[0], parameters[1], parameters[2]),
            _ => throw new ShapeCreatingException(nameof(type), type)
        };
    }
}
