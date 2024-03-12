using System.Runtime.Serialization;

namespace Main;

sealed public class Address
{
	public static readonly int MinValue = int.MinValue;
	public static readonly int MaxValue = int.MaxValue;
	private readonly int _value;

	public Address(int value)
	{
		_value = IsOutOfRange(value)
		? throw new ArgumentOutOfRangeException($"{nameof(Address)}: must be >={MinValue} and <={MaxValue}: {value}")
		: value;
	}

	public int ToInt() => _value;

	public Address Add(Address other) =>
		new Address(checked(_value + other._value));

	public static bool operator <(Address a, Address b) =>
		a._value < b._value;
	
	public static bool operator >(Address a, Address b) =>
		a._value > b._value;

	private static bool IsOutOfRange(int value) =>
		value < MinValue || value > MaxValue;
}