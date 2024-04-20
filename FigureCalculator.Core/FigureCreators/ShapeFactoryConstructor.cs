using FigureCalculator.Core.Exceptions;
using FigureCalculator.Core.Interfaces;
using FigureCalculator.Core.Shapes.Factories;

namespace FigureCalculator.Core.FigureCreators;

public class ShapeFactoryConstructor : IShapeConstructor
{
    private readonly IReadOnlyDictionary<string, IShapeFactory> _shapeFactories;

    public ShapeFactoryConstructor(IEnumerable<IShapeFactory> shapeFactories)
    {
        _shapeFactories = shapeFactories.ToDictionary(factory => factory.Type);
    }

    public static ShapeFactoryConstructor Default =>
        new(new IShapeFactory[] { new CircleFactory(), new TriangleFactory() });

    public IShapeArea Construct(string type, params double[] parameters)
    {
        if (_shapeFactories.TryGetValue(type, out var factory)) return factory.Parse(parameters);

        throw new ShapeCreatingException(nameof(type), type);
    }
}
