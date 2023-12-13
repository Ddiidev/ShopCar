using ShopCar.App.Models;
using ShopCar.App.Services;

namespace ShopCar.App.Controllers;
public static class ControllerVehicle
{

	public static async Task<int> CreateNewVehicle(ModelVehicle vehicle)
	{
		if (vehicle.AnoModelo <= 0)
			throw new ArgumentException($@"O Ano do modelo precisa ter valor superior a ""{vehicle.AnoModelo}""");

		return await ServiceVehicle.Add(vehicle);
	}

}
