using ShopCar.App.Services;
using ShopCar.App.Views;

using System.ComponentModel;

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

	public ViewChoicePage InstanceViewChoicePage = new()
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
		InstanceViewChoicePage.ChoiceChanged += InstanceViewChoicePage_ChoiceChanged;

		PnContainer.Controls.Add(InstanceViewLogin);
	}

	private void InstanceViewChoicePage_ChoiceChanged(object? sender, ViewChoicePage.Escolhas e)
	{
		PnContainer.Controls.Clear();
		if (e == ViewChoicePage.Escolhas.Login)
			PnContainer.Controls.Add(InstanceViewLogin);
		else
			PnContainer.Controls.Add(InstanceViewVehicle);
	}

	private void InstanceViewVehicle_CloseViewBehicles(object? sender, EventArgs e)
	{
		if (PnContainer.Controls.Contains(InstanceViewVehicle))
			PnContainer.Controls.Remove(InstanceViewVehicle);

		PnContainer.Controls.Add(InstanceViewChoicePage);
	}

	private void ViewLogin_ResultLogin(object? sender, bool e)
	{
		PnContainer.Controls.Clear();

		PnContainer.Controls.Add(InstanceViewVehicle);
	}
}
