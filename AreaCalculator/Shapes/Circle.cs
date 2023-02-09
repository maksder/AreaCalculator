using System;

namespace AreaCalculator.Shapes
{
	/// <summary>
	/// Представляет круг.
	/// </summary>
	public class Circle : IAreaCalculator
	{
		#region Data
		#region Fields
		private readonly double _radius;
		private const double PI = 3.14;
		#endregion
		#endregion

		#region .ctor
		/// <summary>
		/// Инициализирует экземпляр класса <see cref="Circle"/> 
		/// </summary>
		/// <param name="radius">Радиус.</param>
		/// <exception cref="ArgumentException">Если аргумент меньше, либо равен 0</exception>
		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentException();
			}
			_radius = radius;
		}
		#endregion

		#region IAreaCalculator members
		/// <inheritdoc/>
		double IAreaCalculator.CalculateArea() => PI * (_radius * _radius);
		#endregion
	}
}
