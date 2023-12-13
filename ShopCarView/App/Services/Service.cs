using Dapper;

using MySql.Data.MySqlClient;

using System.Data;

namespace ShopCar.App.Services;
public class ServiceDb : IDisposable
{
	public IDbConnection Connection { get; set; }

	private static Dictionary<string, string> Tables = new()
	{
		{
			"Veiculos",
			@"CREATE TABLE IF NOT EXISTS Veiculos (
				id INT AUTO_INCREMENT,
				placa VARCHAR(10),
				chassi VARCHAR(20),
				marca VARCHAR(50),
				modelo VARCHAR(50),
				anofabricacao INT,
				anomodelo INT,
				valorfipe DECIMAL(10,2),
				valorvenda DECIMAL(10,2),
				observacoes TEXT,
				PRIMARY KEY (id)
			);"
		}
	};


	/// <summary>
	/// Cria tabela no banco se necessário.
	/// </summary>
	/// <returns></returns>
	/// <exception cref="Exception">Caso falhe em criar alguma tabela</exception>
	public static async Task Init()
	{
		using var service = new ServiceDb();

		foreach (var table in Tables)
		{
			try
			{
				await service.Connection.ExecuteAsync(table.Value);
			} catch (Exception ex)
			{
				throw new Exception($@"Falhou ao criar a tabela ""{table.Key}"" no banco de dados.", ex);
			}
		}
	}


	public ServiceDb()
	{
		var conf = ConfigDb.GetConfig();

		Connection = new MySqlConnection($"server={conf.server};port={conf.port};user id={conf.user}; password={conf.password}; database={conf.database}; SslMode={conf.sslmode}");
		Connection.Open();
	}

	public void Dispose()
	{
		Connection.Close();
		GC.SuppressFinalize(this);
	}
}
