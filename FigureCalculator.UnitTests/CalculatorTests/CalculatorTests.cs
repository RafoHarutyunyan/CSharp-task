using FigureCalculator.Core.Calculators;
using FigureCalculator.Core.Interfaces;
using FigureCalculator.UnitTests.AbstractTests;

namespace FigureCalculator.UnitTests.CalculatorTests;

public class CalculatorTests : AbstractCalculatorTests
{
    protected override double Call(object shapeWithArea)
    {
        var calculator = new Calculator();
        return calculator.Calculate((IShapeArea)shapeWithArea);
    }
}
