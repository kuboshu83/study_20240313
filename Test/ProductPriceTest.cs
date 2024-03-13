using Main;
using Main.Product;
using Main.ValueObject;

namespace Test;

public class ProductPriceTest
{
	[Theory]
	[InlineData(1, 2, 2)]
	public void Multiple_ProductCountをかける(int price, int count, int expected)
	{
		// arrange
		var productPrice = new ProductPrice(new PriceValue(price));
		var productCount = new ProductCount(new CountValue(count));
		// act
		var totalPrice = productPrice.Multiple(productCount);
		// assert
		Assert.Equal(
			new PriceValue(expected),
			totalPrice.Price
		);
	}

	[Theory]
	[InlineData(1, 2, 2)]
	public void Multiple_SoldCountをかける(int price, int count, int expected)
	{
		// arrange
		var productPrice = new ProductPrice(new PriceValue(price));
		var soledCount = new SoldCount(new CountValue(count));
		// act
		var soledPrice = productPrice.Multiple(soledCount);
		// assert
		Assert.Equal(
			new PriceValue(expected),
			soledPrice.Price
		);
	}

	[Theory]
	[InlineData(1, 2, 3)]
	public void Add_ProductPriceを足す(int price1, int price2, int expected)
	{
		// arrange
		var productPrice1 = new ProductPrice(new PriceValue(price1));
		var productPrice2 = new ProductPrice(new PriceValue(price2));
		// act
		var totalPrice = productPrice1.Add(productPrice2);
		// assert
		Assert.Equal(
			new PriceValue(expected),
			totalPrice.Price
		);
	}

}
