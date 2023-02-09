using System;

namespace AreaCalculator.Shapes
{
	/// <summary>
	/// Представляет треугольник.
	/// </summary>
	public class Triangle : IAreaCalculator
	{
		#region Data
		#region Fields
		private readonly double _firstSideLength;
		private readonly double _secondSideLength;
		private readonly double _thirdSideLength;
		#endregion
		#endregion

		#region .ctor
		/// <summary>
		/// Инициализирует экземпляр класса <see cref="Triangle"/> 
		/// </summary>
		/// <param name="firstSideLength">Сторона 1.</param>
		/// <param name="secondSideLength">Сторона 2.</param>
		/// <param name="thirdSideLength">Сторона 3.</param>
		/// <exception cref="ArgumentException">Если аргумент меньше, либо равен 0</exception>
		public Triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
		{
			if (firstSideLength <= 0 | secondSideLength <= 0 | thirdSideLength <= 0)
			{
				throw new ArgumentException();
			}
			_firstSideLength = firstSideLength;
			_secondSideLength = secondSideLength;
			_thirdSideLength = thirdSideLength;
		}
		#endregion

		#region IAreaCalculator members
		/// <inheritdoc/>
		double IAreaCalculator.CalculateArea()
		{
			var halfPerimeter = (_firstSideLength + _secondSideLength + _thirdSideLength) / 2;
			var area = Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSideLength) * (halfPerimeter - _secondSideLength) * (halfPerimeter - _thirdSideLength));
			return area;
		}
		#endregion
	}
}
