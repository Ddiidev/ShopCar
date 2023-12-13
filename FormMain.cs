using ShopCar.App.Services;

namespace ShopCar;

public partial class FormMain : Form
{
	public FormMain()
	{
		InitializeComponent();

		Task.Run(async ()=> await ServiceDb.Init());
	}
}
