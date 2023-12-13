namespace TestShopCarAPI;

using ShopCarAPI;
using ShopCarAPI.Models;

[TestClass]
public class LoginTest
{

	const string ValidUser = "teste";
	const string ValidPass = "123";

	const string InvalidUser = "testes";
	const string InvalidPass = "1234";


	[TestMethod]
	public async Task InvalidLogin()
	{
		try
		{
			var user = await Api.Login(new ExtLoginUser
			{
				User = InvalidUser,
				Password = InvalidPass
			});

			Assert.IsTrue(user?.Error);
		} catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public async Task ValidLogin()
	{
		try
		{
			var user = await Api.Login(new ExtLoginUser
			{
				User = ValidUser,
				Password = ValidPass
			});

			Assert.IsFalse(user?.Error);
			Assert.AreEqual("John Smith", user?.User?.Name);
		} catch
		{
			Assert.Fail();
		}
	}
}
