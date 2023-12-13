using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCar.App.Services;
internal class ConfigDb
{
	/// <summary>
	/// Retorna as configurações do arquivo chamado "conf.json".
	/// </summary>
	/// <returns>dynamic visto que são configurações pontuais</returns>
	/// <exception cref="Exception">Caso ocorra alguma falha para carregar as configurações.</exception>
	public static dynamic GetConfig()
	{
		try
		{
			var contentConfFile = File.ReadAllText($@"{Environment.CurrentDirectory}\conf.json");
			return JsonConvert.DeserializeObject<dynamic>(contentConfFile)!;
		} catch (Exception ex)
		{
			throw new Exception("Falhou ao carregar as configurações de banco de dados.", ex);
		}
	}
}
