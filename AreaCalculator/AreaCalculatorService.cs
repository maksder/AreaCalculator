namespace AreaCalculator
{
	/// <summary>
	/// Представляет инструмент вычисления площади фигуры.
	/// </summary>
	public class AreaCalculatorService
	{
		#region Data
		#region Fields
		private readonly IAreaCalculator _areaCalculator;
		#endregion
		#endregion

		#region .ctor
		/// <summary>
		/// Инициализирует экземпляр класса <see cref="AreaCalculatorService" />
		/// </summary>
		/// <param name="areaCalculator">Реализация инстурмента вычисления площади фигуры.</param>
		public AreaCalculatorService(IAreaCalculator areaCalculator) => _areaCalculator = areaCalculator;
		#endregion

		#region Public
		/// <summary>
		/// Вычисляет площадь фигуры.
		/// </summary>
		/// <returns>Площадь фигуры.</returns>
		public double CalculateArea() => _areaCalculator.CalculateArea();
		#endregion
	}
}
