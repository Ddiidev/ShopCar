namespace ShopCar.App.Views;


public partial class ViewLogin : UserControl
{
	public event EventHandler<bool> ResultLogin;

	public ViewLogin()
	{
		InitializeComponent();

		BackColor = Color.Transparent;
	}

	private void BtLogin_Click(object sender, EventArgs e)
	{
		ResultLogin?.Invoke(this, true);
	}
}
