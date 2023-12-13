namespace TestShopCarAPI;

using ShopCarAPI;

[TestClass]
public class GetModelTest
{
	const string ValidBrandCode = "59";
	const string InvalidBrandCode = "-59";

	[TestMethod]
	public async Task GetModels59()
	{
		var models = await Api.SearchModels(ValidBrandCode);

		Assert.IsTrue(models?.Modelos?.Count > 0);
	}

	[TestMethod]
	public async Task GetInvalidModels59()
	{
		var models = await Api.SearchModels(InvalidBrandCode);

		Assert.IsTrue(models?.Error != "");
	}
}
