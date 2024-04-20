namespace FigureCalculator.Core.Interfaces;

public interface IShapeFactory
{
    string Type { get; }
    IShapeArea Parse(params double[] parameters);
}
