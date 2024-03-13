namespace Main.ValueObject;

sealed public record CountValue
{
	private static readonly int MaxValue = int.MaxValue;
	private static readonly int MinValue = int.MinValue;

	private readonly int _value;

	public CountValue(int value)
	{
		_value = IsOutOfRange(value)
		? throw new ArgumentOutOfRangeException($"{nameof(PriceValue)}: must be >={MinValue} and <={MaxValue}: {value}")
		: value;
	}

	public static bool IsOutOfRange(int value)
		=> value < int.MinValue || value > int.MaxValue;

	public int ToInt() => _value;
}
