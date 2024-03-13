using System.ComponentModel;
using Main.Address;
using Main.ValueObject;

namespace Test;

public class MemoryAddressTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [Description("MemoryAddressとOffsetAddressを加算して正しいMemoryAddressができる")]
    public void Increment_OffsetAddressを加算する(int addr, int offset, int expected)
    {
        // arrange
        var memoryAddress = new MemoryAddress(new AddressValue(addr));
        var offsetAddress = new OffsetAddress(new AddressValue(offset));
        // act
        var calcuratedAddress = memoryAddress.Increment(offsetAddress);
        // assert
        Assert.Equal(
            new MemoryAddress(new AddressValue(expected)).Value,
            calcuratedAddress.Value
        );
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [Description("MemoryAddressとDataLengthを加算して正しいMemoryAddressができる")]
    public void Increment_DataLengthを加算する(int addr, int length, int expected)
    {
        // arrange
        var memoryAddress = new MemoryAddress(new AddressValue(addr));
        var dataLength = new DataLength(new AddressValue(length));
        // act
        var calcuratedAddress = memoryAddress.Increment(dataLength);
        // assert
        Assert.Equal(
            new MemoryAddress(new AddressValue(expected)).Value,
            calcuratedAddress.Value
        );
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [Description("MemoryAddress同士を加算して正しいMemoryAddressができる")]
    public void Increment_MemoryAddressを加算する(int addr1, int addr2, int expected)
    {
        // arrange
        var memoryAddress1 = new MemoryAddress(new AddressValue(addr1));
        var memoryAddress2 = new DataLength(new AddressValue(addr2));
        // act
        var calcuratedAddress = memoryAddress1.Increment(memoryAddress2);
        // assert
        Assert.Equal(
            new MemoryAddress(new AddressValue(expected)).Value,
            calcuratedAddress.Value
        );
    }

}