using FigureCalculator.Core.Interfaces;

namespace FigureCalculator.Core.Calculators;

public class Calculator
{
    public double Calculate(IShapeArea shape)
    {
        return shape.CalculateArea();
    }
}
