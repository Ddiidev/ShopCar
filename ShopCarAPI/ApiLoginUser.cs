using ShopCarAPI.Exceptions;
using ShopCarAPI.Models;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace ShopCarAPI;
public static partial class Api
{
	const string HttpUrlLogin = "https://test-api-y04b.onrender.com/signIn";


	/// <summary>
	/// Login de usuário com nome e senha
	/// </summary>
	/// <param name="username">nome</param>
	/// <param name="password">senha</param>
	/// <returns></returns>
	/// <exception cref="LoginException">Caso ocorra alguma falha durante login/deserializando objeto vindo da api</exception>
	public static async Task<UserLogged?> Login(ExtLoginUser user)
	{
		string resultJsonString;
		var client = new HttpClient
		{
			BaseAddress = new Uri(HttpUrlLogin)
		};

		try
		{
			var result = await client.PostAsJsonAsync(client.BaseAddress, user);
			resultJsonString = await result.Content.ReadAsStringAsync();
		} catch (Exception ex)
		{
			throw new LoginException("Falhou ao logar", ex);
		}

		try
		{
			return JsonConvert.DeserializeObject<UserLogged>(resultJsonString);
		} catch (Exception ex)
		{
			throw new LoginException("Falhou deserializando resultado da api", ex);
		}
	}

}
