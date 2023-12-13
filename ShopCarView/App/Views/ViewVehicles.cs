using System.Linq;
using ShopCar.App.Controllers;
using ShopCar.App.Models;

using ShopCarAPI;
using ShopCarAPI.Models;

namespace ShopCar.App.Views;
public partial class ViewVehicles : UserControl
{
	public event EventHandler? CloseViewVehicles;


	List<Brand>? Marcas { get; set; }
	ModelsBrand? Modelos { get; set; }
	ModelVehicle? CurrentVehicleSelected { get; set; }

	public ViewVehicles()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Adiciona todos os veículos do banco ao DataGridView
	/// </summary>
	/// <returns></returns>
	private async Task PopularDataGrid()
	{
		dgvListaVeiculos.DataSource = new { };

		dgvListaVeiculos.SuspendLayout();

		dgvListaVeiculos.DataSource = await ControllerVehicle.PegarTodosVeiculos();

		dgvListaVeiculos.ResumeLayout();
	}

	private async void ViewVehicles_Load(object sender, EventArgs e)
	{
		await PopularDataGrid();

		// Temp

		TxPlaca.Text = "ABC1234";
		TxChassi.Text = "1HGCM82633A123456";
		TxMarca.Text = "Ford";
		TxModelo.Text = "Fiesta";
		TxAnoFabricacao.Text = "2010";
		TxAnoModelo.Text = "2010";
		TxValorFIPE.Text = "20000.00";
		TxValorVenda.Text = "25000.00";
		TxObservacoes.Text = "Carro Novo teste";
	}

	/// <summary>
	/// Fechar a ViewVehicles
	/// </summary>
	private void BtVoltar_Click(object sender, EventArgs e) =>
		CloseViewVehicles?.Invoke(this, e);

	private void BtNovo_Click(object sender, EventArgs e)
	{
		ResetCamposEdit();

		CurrentStateEdit = StateEdit.create;

		TabMain.SelectedTab = PageEdit;
	}

	private void BtEditar_Click(object sender, EventArgs e)
	{
		try
		{
			ResetCamposEdit();

			CurrentStateEdit = StateEdit.update;

			CurrentVehicleSelected = (ModelVehicle)dgvListaVeiculos.CurrentRow.DataBoundItem;

			PopularCamposEdit();

			TabMain.SelectedTab = PageEdit;
		} catch
		{
			MessageBox.Show("Selecione um carro da lista");
		}
	}

	private async void BtDeletar_Click(object sender, EventArgs e)
	{
		try
		{
			CurrentVehicleSelected = (ModelVehicle)dgvListaVeiculos.CurrentRow.DataBoundItem;
		} catch
		{
			MessageBox.Show("Falha ao capturar o veículo selecionado, tente novamente.");
			return;
		}

		var msg = $"Deseja deletar o veículo {CurrentVehicleSelected.Marca} do modelo ({CurrentVehicleSelected.Modelo})";
		if (MessageBox.Show(msg, "Atenção!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
			return;

		try
		{
			await ControllerVehicle.DeletarVeiculoPorId(CurrentVehicleSelected);

			await PopularDataGrid();
		} catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private async void BtBuscar_Click(object sender, EventArgs e)
	{
		dgvListaVeiculos.DataSource = new { };

		dgvListaVeiculos.SuspendLayout();

		dgvListaVeiculos.DataSource = await ControllerVehicle.BuscarVeiculos(TxCampoBusca.Text);

		dgvListaVeiculos.ResumeLayout();
	}


	#region PÁGINA DE EDIÇÃO
	enum StateEdit
	{
		none,
		create,
		update
	}

	StateEdit CurrentStateEdit { get; set; } = StateEdit.none;

	/// <summary>
	/// Limpa todos os campos da página de edição
	/// </summary>
	private void ResetCamposEdit()
	{
		TxAnoFabricacao.Clear();
		TxAnoModelo.Clear();
		TxChassi.Clear();
		TxMarca.Clear();
		TxModelo.Clear();
		TxObservacoes.Clear();
		TxPlaca.Clear();
		TxValorVenda.Clear();
		TxValorFIPE.Clear();
	}

	/// <summary>
	/// Preenche todos os campos da página de Edição
	/// </summary>
	private void PopularCamposEdit()
	{
		try
		{
			if (CurrentVehicleSelected is null)
				CurrentVehicleSelected = new ModelVehicle();

			TxPlaca.Text = CurrentVehicleSelected.Placa;
			TxChassi.Text = CurrentVehicleSelected.Chassi;
			TxMarca.Text = CurrentVehicleSelected.Marca;
			TxModelo.Text = CurrentVehicleSelected.Modelo;
			TxAnoFabricacao.Text = CurrentVehicleSelected.AnoFabricacao.ToString();
			TxAnoModelo.Text = CurrentVehicleSelected.AnoModelo.ToString();
			TxValorFIPE.Text = CurrentVehicleSelected.ValorFipe.ToString();
			TxValorVenda.Text = CurrentVehicleSelected.ValorVenda.ToString();
			TxObservacoes.Text = CurrentVehicleSelected.Observacoes;
		} catch (Exception ex)
		{
			MessageBox.Show($"Algum(ns) dados incorretos\n{ex.Message}");
		}
	}

	private async void BtSalvar_Click(object sender, EventArgs e)
	{
		CurrentVehicleSelected ??= new ModelVehicle();

		var vehicle = new ModelVehicle
		{
			Id = CurrentVehicleSelected.Id,
			Chassi = TxChassi.Text,
			Marca = TxMarca.Text,
			Modelo = TxModelo.Text,
			Observacoes = TxObservacoes.Text,
			Placa = TxPlaca.Text
		};

		try
		{
			vehicle.AnoFabricacao = Convert.ToInt32(TxAnoFabricacao.Text);
			vehicle.AnoModelo = Convert.ToInt32(TxAnoModelo.Text);
			vehicle.ValorVenda = Convert.ToDecimal(TxValorVenda.Text);
			vehicle.ValorFipe = Convert.ToDecimal(TxValorFIPE.Text);
		} catch (Exception ex)
		{
			MessageBox.Show($"Campo com dado incorreto.\n{ex.Message}");
		}

		try {
			await ChecarCampoModelo();

			await ChecarCampoMarca();
		} catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return;
		}


		if (CurrentStateEdit == StateEdit.create)
			await ControllerVehicle.Criar(vehicle);
		else if (CurrentStateEdit == StateEdit.update)
			await ControllerVehicle.Atualizar(vehicle);

		BtVoltarEdit_Click(sender, e);
	}

	private void BtCancelar_Click(object sender, EventArgs e)
	{
		ResetCamposEdit();
		BtVoltarEdit_Click(sender, e);
	}

	private async void BtVoltarEdit_Click(object sender, EventArgs e)
	{
		await PopularDataGrid();

		TabMain.SelectedTab = PageMain;
	}


	private async Task ChecarCampoModelo()
	{
		Modelos ??= await Api.SearchModels(TxModelo.Text);
		if (Modelos.Modelos is null || (Modelos.Modelos is not null && Modelos.Modelos.Count == 0))
			Modelos ??= await Api.SearchModels(TxModelo.Text);

		if (!string.IsNullOrEmpty(Modelos.Error))
			throw new Exception(Modelos.Error);
	}

	private async Task ChecarCampoMarca()
	{
		if (Marcas is null || (Marcas is not null && Marcas.Count == 0))
			Marcas = await Api.GetBrands();

		if (!Marcas!.Any(m => m.Nome == TxMarca.Text))
			throw new Exception($@"Não existe a marca ""{TxMarca.Text}""");
	}
	#endregion
}
