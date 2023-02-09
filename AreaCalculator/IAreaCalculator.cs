namespace AreaCalculator
{
	/// <summary>
	/// Представляет интерфейс вычисления полщади фигуры.
	/// </summary>
	public interface IAreaCalculator
	{
		#region Overridable
		/// <summary>
		/// Вычисляет площадь фигуры.
		/// </summary>
		/// <returns>Площадь фигуры.</returns>
		double CalculateArea();
		#endregion
	}
}
