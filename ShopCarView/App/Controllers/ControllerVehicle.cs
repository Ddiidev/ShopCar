using ShopCar.App.Models;
using ShopCar.App.Services;

namespace ShopCar.App.Controllers;
public static class ControllerVehicle
{

	/// <summary>
	/// Cria um novo veículo
	/// </summary>
	/// <param name="veiculo"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException">Caso o AnoModelo/AnoFabricacao seja igual ou menor que 0</exception>
	public static async Task<int> Criar(ModelVehicle veiculo)
	{
		if (veiculo.AnoModelo <= 0)
			throw new ArgumentException($@"O Ano do modelo precisa ter valor superior a ""{veiculo.AnoModelo}""");

		if (veiculo.AnoFabricacao <= 0)
			throw new ArgumentException($@"O Ano do fabricação precisa ter valor superior a ""{veiculo.AnoFabricacao}""");

		return await ServiceVehicle.Add(veiculo);
	}

	/// <summary>
	/// Atualiza o veículo atual
	/// </summary>
	/// <param name="veiculo"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException">Caso o AnoModelo/AnoFabricacao seja igual ou menor que 0</exception>
	public static async Task<int> Atualizar(ModelVehicle veiculo)
	{
		if(veiculo.AnoModelo <= 0)
			throw new ArgumentException($@"O Ano do modelo precisa ter valor superior a ""{veiculo.AnoModelo}""");

		if (veiculo.AnoFabricacao <= 0)
			throw new ArgumentException($@"O Ano do fabricação precisa ter valor superior a ""{veiculo.AnoFabricacao}""");

		return await ServiceVehicle.Update(veiculo);
	}

	/// <summary>
	/// Pega todos os veículos existentes no banco.
	/// </summary>
	/// <returns></returns>
	public static async Task<IEnumerable<ModelVehicle>> PegarTodosVeiculos()
	{
		return await ServiceVehicle.GetAll();
	}

	/// <summary>
	/// Busca veículos pelo nome, modelo e placa
	/// </summary>
	/// <param name="termoBusca"></param>
	/// <returns></returns>
	public static async Task<IEnumerable<ModelVehicle>> BuscarVeiculos(string termoBusca)
	{
		if (string.IsNullOrWhiteSpace(termoBusca))
			return await ServiceVehicle.GetAll();

		return await ServiceVehicle.SearchAll(termoBusca);
	}

	/// <summary>
	/// Deletar veículo
	/// </summary>
	/// <param name="veiculo"></param>
	/// <returns></returns>
	/// <exception cref="Exception">Caso o veiculo seja nulo</exception>
	public static async Task<int> DeletarVeiculoPorId(ModelVehicle veiculo)
	{
		if (veiculo is null)
			throw new Exception("Falha ao deletar o veículo");

		return await ServiceVehicle.Delete(veiculo);
	}
}
