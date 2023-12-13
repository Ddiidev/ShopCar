using ShopCarAPI.Exceptions;
using ShopCarAPI.Models;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace ShopCarAPI;
public static partial class Api
{
	const string HttpUrlBrands = "https://parallelum.com.br/fipe/api/v1/carros/marcas";


	public static async Task<List<Marca>> GetBrands()
	{
		string resultJsonString;
		var client = new HttpClient
		{
			BaseAddress = new Uri(HttpUrlBrands)
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
			var marcas = JsonConvert.DeserializeObject<List<Marca>>(resultJsonString);
			if (marcas is null || marcas.Count == 0)
				marcas = new List<Marca>();

			return marcas;
		} catch (Exception ex)
		{
			throw new MarcaException("Falhou deserializando resultado da api", ex);
		}
	}

}
