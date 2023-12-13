namespace ShopCar.App.Views;

using ShopCarAPI;
using ShopCarAPI.Models;

public partial class ViewLogin : UserControl
{
	public event EventHandler<bool>? ResultLogin;

	public ViewLogin()
	{
		InitializeComponent();

		BackColor = Color.Transparent;
	}

	private async void BtLogin_Click(object sender, EventArgs e)
	{
		try
		{
			var user = await Api.Login(new ExtLoginUser
			{
				User = TxUser.Text,
				Password = TxPass.Text
			});

			if (!user.Error)
				ResultLogin?.Invoke(this, true);
			else
				throw new Exception(user.Message);
		} catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}
