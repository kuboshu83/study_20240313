using Main.ValueObject;

namespace Main.Address;

/// <summary>
/// メモリーのオフセットアドレス
/// </summary>
public class OffsetAddress : IAddressCalculable
{
	/// <summary>
	/// アドレスのオフセット値として設定可能な最大値
	/// </summary>
	private static readonly AddressValue MaxValue = new AddressValue(AddressValue.MaxValue);
	/// <summary>
	/// アドレスのオフセット値として設定可能な最小値
	/// </summary>
	private static readonly AddressValue MinValue = new AddressValue(0);
	public AddressValue Value { get; }

	public OffsetAddress(AddressValue address)
	{
		Value = IsOutOfRange(address)
			? throw new ArgumentOutOfRangeException($"{nameof(OffsetAddress)}: size is out of range: {address.ToInt()}")
			: address;
	}

	private static bool IsOutOfRange(AddressValue address) =>
		address < MinValue || address > MaxValue;
}
