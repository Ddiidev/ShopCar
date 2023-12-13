using ShopCar.App.Services;
using ShopCar.App.Views;

namespace ShopCar;

public partial class FormMain : Form
{
	public ViewLogin InstanceViewLogin = new()
	{
		Dock = DockStyle.Fill,
	};

	public ViewVehicles InstanceViewVehicle = new()
	{
		Dock = DockStyle.Fill
	};

	public FormMain()
	{
		InitializeComponent();
		InitializeInstances();

		Task.Run(async () => await ServiceDb.Init());
	}

	public void InitializeInstances()
	{
		InstanceViewLogin.ResultLogin += ViewLogin_ResultLogin;
		InstanceViewVehicle.CloseViewVehicles += InstanceViewVehicle_CloseViewBehicles;

		Container.Controls.Add(InstanceViewVehicle);
	}

	private void InstanceViewVehicle_CloseViewBehicles(object? sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private void ViewLogin_ResultLogin(object? sender, bool e)
	{
		throw new NotImplementedException();
	}
}
