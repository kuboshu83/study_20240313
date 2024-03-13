namespace Main.ValueObject;

sealed public record PriceValue
{
	private static readonly int MaxValue = int.MaxValue;
	private static readonly int MinValue = int.MinValue; 
	private readonly int _value;

	public PriceValue(int value)
	{
		_value = IsOutOfRange(value)
		? throw new ArgumentOutOfRangeException($"{nameof(PriceValue)}: must be >={MinValue} and <={MaxValue}: {value}")
		: value;
	}

	public PriceValue Add(PriceValue other) =>
		new PriceValue(checked(_value + other._value));

	public PriceValue Sub(PriceValue other) =>
		new PriceValue(checked(_value - other._value));

	public PriceValue Multiple(CountValue value) =>
		new PriceValue(checked(_value * value.ToInt()));

	private static bool IsOutOfRange(int value) =>
		value < int.MinValue || value > int.MaxValue;
}
