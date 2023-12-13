using ShopCarAPI.Exceptions;
using ShopCarAPI.Models;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace ShopCarAPI;
public static partial class Api
{
	const string HttpUrlModel = @"https://parallelum.com.br/fipe/api/v1/carros/marcas/{0}/modelos";


	public static async Task<ModelsBrand?> SearchModels(string codeBrand)
	{
		string resultJsonString;
		var client = new HttpClient
		{
			BaseAddress = new Uri(string.Format(HttpUrlModel, codeBrand))
		};

		try
		{
			var result = await client.GetAsync(client.BaseAddress);
			resultJsonString = await result.Content.ReadAsStringAsync();
		} catch (Exception ex)
		{
			throw new MarcaException("Falhou ao capturar as marcas", ex);
		}

		try
		{
			return JsonConvert.DeserializeObject<ModelsBrand>(resultJsonString);
		} catch (Exception ex)
		{
			throw new MarcaException("Falhou deserializando resultado da api", ex);
		}
	}

}
