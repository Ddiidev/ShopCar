namespace ShopCar.App.Views;
public partial class ViewChoicePage : UserControl
{
	public event EventHandler<Escolhas>? ChoiceChanged;

	public enum Escolhas
	{
		Login,
		IrVeiculos
	}

	public ViewChoicePage()
	{
		InitializeComponent();
	}

	private void BtVoltarLogin_Click(object sender, EventArgs e)
	{
		ChoiceChanged?.Invoke(sender, Escolhas.Login);
	}

	private void BtIrVeículos_Click(object sender, EventArgs e)
	{
		ChoiceChanged?.Invoke(sender, Escolhas.IrVeiculos);
	}
}
