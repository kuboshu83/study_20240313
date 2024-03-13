
using Main.ValueObject;

namespace Main.Address;

/// <summary>
/// アドレスを計算するためのインターフェース
/// </summary>
/// <remarks>
/// アドレスの計算に係るクラスはこのインターフェースを継承する必要がある。
/// </remarks>
public interface IAddressCalculable
{
	AddressValue Value {get;}
}
