namespace FigureCalculator.Core.Interfaces;

public interface IShapeConstructor
{
    IShapeArea Construct(string type, params double[] parameters);
}
