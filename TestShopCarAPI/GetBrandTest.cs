namespace TestShopCarAPI;

using ShopCarAPI;

[TestClass]
public class GetBrandTest
{
	[TestMethod]
	public async Task GetBrands()
	{
		var brands = await Api.GetBrands();

		Assert.IsTrue(brands.Count > 0);
	}
}
