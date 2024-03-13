using Main.ValueObject;

namespace Main;

/// <summary>
/// 製品の個数
/// </summary>
sealed public class ProductCount : ICountable
{
    public CountValue Value { get; }

	public ProductCount(CountValue value)
	{
		Value = value;
	}
}
