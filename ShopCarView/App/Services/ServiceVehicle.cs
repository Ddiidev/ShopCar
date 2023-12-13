using Dapper;

using ShopCar.App.Models;

namespace ShopCar.App.Services;

public class ServiceVehicle
{
	const string SelectByNomeMarcaModelo = @"
		SELECT * FROM Veiculos 
		WHERE UPPER(Placa) LIKE @TermSearch
		OR UPPER(Chassi) LIKE @TermSearch
		OR UPPER(Marca) LIKE @TermSearch
		OR UPPER(Modelo) LIKE @TermSearch;
	";

	const string SelectAllSql = @"
		SELECT * FROM Veiculos
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
		SELECT FROM Veiculos WHERE Id = @Id;
	";

	public static async Task<int> Add(ModelVehicle vehicle)
	{
		using var serviceDb = new ServiceDb();


		return await serviceDb.Connection.ExecuteAsync(InsertSql, vehicle);
	}

	public static async Task<int> Update(ModelVehicle vehicle)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.ExecuteAsync(UpdateSql, vehicle);
	}

	public static async Task<int> Delete(ModelVehicle vehicle)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.ExecuteAsync(DeleteSql, vehicle);
	}


	public static async Task<IEnumerable<ModelVehicle>> GetAll()
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.QueryAsync<ModelVehicle>(SelectAllSql);
	}

	public static async Task<IEnumerable<ModelVehicle>> SearchAll(string term)
	{
		using var serviceDb = new ServiceDb();

		return await serviceDb.Connection.QueryAsync<ModelVehicle>(SelectByNomeMarcaModelo, new {
			TermSearch = $"{term}%"
		});
	}

}
