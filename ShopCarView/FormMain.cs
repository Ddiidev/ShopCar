using ShopCar.App.Services;
using ShopCar.App.Views;

namespace ShopCar;

public partial class FormMain : Form
{
	public ViewLogin InstanceViewLogin = new()
	{
		Dock = DockStyle.Fill,
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

		Container.Controls.Add(InstanceViewLogin);
	}

	private void ViewLogin_ResultLogin(object? sender, bool e)
	{
		throw new NotImplementedException();
	}
}
