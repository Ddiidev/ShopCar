using Dapper;

using Microsoft.Data.Sqlite;

using MySql.Data.MySqlClient;

using System.Data;

namespace ShopCar.App.Services;
public class ServiceDb : IDisposable
{
	private static bool IsSqlLite;
	public IDbConnection Connection { get; set; }

	private static readonly Dictionary<string, string> Tables = new()
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
		},
		{
			"Marcas",
			@"CREATE TABLE IF NOT EXISTS Marcas (
				id INT AUTO_INCREMENT,
				codigo VARCHAR(15),
				nome VARCHAR(50),
				PRIMARY KEY (id)
			);"
		},
		{
			"Modelos",
			@"CREATE TABLE IF NOT EXISTS Modelos (
				id INT AUTO_INCREMENT,
				codigo VARCHAR(15),
				nome VARCHAR(50),
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
				if (IsSqlLite)
				{
					await service.Connection.ExecuteAsync(table.Value.Replace("DECIMAL", "TEXT"));
					await service.Connection.ExecuteAsync($@"
						CREATE TABLE IF NOT EXISTS auto_increment (value INT, table_name TEXT UNIQUE);
						INSERT OR IGNORE INTO auto_increment VALUES (0, '{table.Key}');

						CREATE TRIGGER IF NOT EXISTS increment AFTER INSERT ON {table.Key}
						BEGIN
						   UPDATE auto_increment 
						   SET    value = value + 1 
						   WHERE  table_name = '{table.Key}';

						   UPDATE {table.Key} 
						   SET    id = (
									   SELECT value 
									   FROM auto_increment 
									   WHERE table_name = '{table.Key}')
						   WHERE  ROWID = new.ROWID;
						END;
					");
				} else
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

		if (conf.force_db_sqlite == "True")
		{
			IsSqlLite = true;
			Connection = new SqliteConnection(@$"Filename={Environment.CurrentDirectory}\shopcar.db");
		} else
			Connection = new MySqlConnection($"server={conf.server};port={conf.port};user id={conf.user}; password={conf.password}; database={conf.database}; SslMode={conf.sslmode}");

		Connection.Open();
	}

	public void Dispose()
	{
		Connection.Close();
		GC.SuppressFinalize(this);
	}
}
