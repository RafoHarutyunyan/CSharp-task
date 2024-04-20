using FigureCalculator.Core.FigureCreators;
using FigureCalculator.Core.Interfaces;
using FigureCalculator.UnitTests.AbstractTests;

namespace FigureCalculator.UnitTests.FigureCreatorsTests;

public class ShapeFactoryConstructorTests : AbstractShapeConstructorTests
{
    protected override IShapeConstructor ShapeConstructor => ShapeFactoryConstructor.Default;
}
