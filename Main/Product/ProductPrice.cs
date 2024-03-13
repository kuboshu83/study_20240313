using Main.ValueObject;

namespace Main.Product;

sealed public class ProductPrice
{
	public PriceValue Price {get;}

	public ProductPrice(PriceValue price)
	{
		Price = price;
	}

	public ProductPrice Multiple<T>(T count) where T : ICountable =>
		new ProductPrice(Price.Multiple(count.Value));
	
	public ProductPrice Add(ProductPrice other) =>
		new ProductPrice(Price.Add(other.Price));

	public ProductPrice Sub(ProductPrice other) =>
		new ProductPrice(Price.Sub(other.Price));
}
