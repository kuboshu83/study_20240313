namespace Main.ValueObject;

/// <summary>
/// アドレスを計算するための基本クラス
/// </summary>
/// <remarks>
/// アドレスとして計算するオブジェクトは、このクラスのオブジェクトを所有する。
/// </remarks>
sealed public record AddressValue
{
	public static readonly int MinValue = int.MinValue;
	public static readonly int MaxValue = int.MaxValue;
	private readonly int _value;

	public AddressValue(int value)
	{
		_value = IsOutOfRange(value)
		? throw new ArgumentOutOfRangeException($"{nameof(AddressValue)}: must be >={MinValue} and <={MaxValue}: {value}")
		: value;
	}

	public int ToInt() => _value;

	public AddressValue Add(AddressValue other) =>
		new AddressValue(checked(_value + other._value));

	public static bool operator <(AddressValue a, AddressValue b) =>
		a._value < b._value;

	public static bool operator >(AddressValue a, AddressValue b) =>
		a._value > b._value;

	public static bool operator <=(AddressValue a, AddressValue b) =>
		a._value <= b._value;

	public static bool operator >=(AddressValue a, AddressValue b) =>
		a._value >= b._value;

	private static bool IsOutOfRange(int value) =>
		value < MinValue || value > MaxValue;
}