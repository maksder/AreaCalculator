using System;
using AreaCalculator;
using AreaCalculator.Shapes;
using NUnit.Framework;

namespace UnitTest
{
	/// <summary>
	/// Представляет набор тестов для <see cref="AreaCalculatorService"/>
	/// </summary>
	public class Tests
	{
		[Test]
		public void CalculateArea_CalculateTriangleAreaWithCorrectParameter_Success()
		{
			// Arrange
			var areaCalculator = new AreaCalculatorService(new Triangle(10, 13, 15));

			// Act
			var triangleArea = areaCalculator.CalculateArea();
			
			// Assert
			Assert.AreEqual(64, Math.Round(triangleArea));
		}
		
		[Test]
		public void CalculateArea_CalculateCircleAreaWithCorrectParameter_Success()
		{
			// Arrange
			var areaCalculator = new AreaCalculatorService(new Circle(10));

			// Act
			var circleArea = areaCalculator.CalculateArea();
			
			// Assert
			Assert.AreEqual(314, Math.Round(circleArea));
		}
		
		[Test]
		public void CalculateArea_CalculateCircleAreaWithIncorrectParameter_Failed()
		{
			Assert.Throws<ArgumentException>(() => new AreaCalculatorService(new Circle(-10)));
			Assert.Throws<ArgumentException>(() => new AreaCalculatorService(new Circle(0)));
		}
		
		[Test]
		public void CalculateArea_CalculateTriangleAreaWithIncorrectParameter_Failed()
		{
			Assert.Throws<ArgumentException>(() => new AreaCalculatorService(new Triangle(0, 13, 15)));
			Assert.Throws<ArgumentException>(() => new AreaCalculatorService(new Triangle(-5, 13, 15)));
		}
	}
}
