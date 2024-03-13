using Main.ValueObject;

namespace Main;

/// <summary>
/// 販売個数
/// </summary>
public class SoldCount : ICountable
{
    public CountValue Value { get; }

	public SoldCount(CountValue value)
	{
		Value = value;
	}
}
