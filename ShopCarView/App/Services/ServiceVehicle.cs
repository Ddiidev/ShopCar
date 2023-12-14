using Dapper;

using ShopCar.App.Models;

namespace ShopCar.App.Services;

public class ServiceVehicle
{
	const string SelectByNomeMarcaModelo = @"
		SELECT * FROM Veiculos 
		LEFT JOIN marcas ma ON v.marca = ma.codigo
		LEFT JOIN modelos mo ON v.modelo = mo.codigo
		WHERE UPPER(Placa) LIKE @TermSearch
		OR UPPER(Chassi) LIKE @TermSearch
		OR UPPER(Marca) LIKE @TermSearch
		OR UPPER(Modelo) LIKE @TermSearch;
	";

	const string SelectAllSql = @"
		SELECT v.*, ma.nome as nomemarca, mo.nome as nomemodelo FROM Veiculos v
		LEFT JOIN marcas ma ON v.marca = ma.codigo
		LEFT JOIN modelos mo ON v.modelo = mo.codigo
	";

	const string InsertSql = @"
		INSERT INTO Veiculos (Placa, Chassi, Marca, Modelo, AnoFabricacao, AnoModelo, ValorFipe, ValorVenda, Observacoes)
		VALUES (@Placa, @Chassi, @Marca, @Modelo, @AnoFabricacao, @AnoModelo, @ValorFipe, @ValorVenda, @Observacoes)
	";

	const string UpdateSql = @"
		UPDATE Veiculos 
		SET Placa = @Placa, 
		   Chassi = @Chassi, 
		   Marca = @Marca, 
		   Modelo = @Modelo, 
		   AnoFabricacao = @AnoFabricacao, 
		   AnoModelo = @AnoModelo, 
		   ValorFipe = @ValorFipe, 
		   ValorVenda = @ValorVenda, 
		   Observacoes = @Observacoes 
		WHERE Id = @Id
	";

	const string DeleteSql = @"
		DELETE FROM Veiculos WHERE Id = @Id;
	";

	public static async Task<int> Add(ModelVeiculo vehicle)
	{
		using var serviceDb = new ServiceDb();


		return await serviceDb.Connection.ExecuteAsync(InsertSql, vehicle);
	}

	public static async Task<int> Update(ModelVeiculo vehicle)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.ExecuteAsync(UpdateSql, vehicle);
	}

	public static async Task<int> Delete(ModelVeiculo vehicle)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.ExecuteAsync(DeleteSql, vehicle);
	}


	public static async Task<IEnumerable<ModelVeiculo>> GetAll()
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.QueryAsync<ModelVeiculo>(SelectAllSql);
	}

	public static async Task<IEnumerable<ModelVeiculo>> SearchAll(string term)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.QueryAsync<ModelVeiculo>(SelectByNomeMarcaModelo, new {
			TermSearch = $"{term}%"
		});
	}

}
