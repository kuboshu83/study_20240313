using Main.ValueObject;

namespace Main.Address;

/// <summary>
/// メモリーのアドレス
/// </summary>
public class MemoryAddress : IAddressCalculable
{
	public AddressValue Value {get;}

	public MemoryAddress(AddressValue value)
	{
		Value = value;
	}

	public MemoryAddress Increment(IAddressCalculable other)
		=> new MemoryAddress(
			this.Value.Add(other.Value)
			);
}
