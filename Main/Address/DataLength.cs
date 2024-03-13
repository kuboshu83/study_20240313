using Main.ValueObject;

namespace Main.Address;

public class DataLength : IAddressCalculable
{
	/// <summary>
	/// 設定可能なデータ長の最大値
	/// </summary>
	public static readonly AddressValue MaxValue = new AddressValue(100);
	/// <summary>
	/// 設定可能なデータ長の最小値
	/// </summary>
	public static readonly AddressValue MinValue = new AddressValue(1);

    public AddressValue Value { get; }

	/// <remarks>
	/// 設定可能なデータ長に注意
	/// </remarks>
	public DataLength(AddressValue value)
	{
		Value = value;
	}
}
