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
	ModelVeiculo? CurrentVehicleSelected { get; set; }

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

		dgvListaVeiculos.Columns[ "Marca" ].Visible = false;
		dgvListaVeiculos.Columns[ "Modelo" ].Visible = false;
		dgvListaVeiculos.Columns[ "NomeMarca" ].HeaderText = "Nome da marca";
		dgvListaVeiculos.Columns[ "NomeModelo" ].HeaderText = "Nome do modelo";

		dgvListaVeiculos.ResumeLayout();
	}

	private async void ViewVehicles_Load(object sender, EventArgs e)
	{
		Marcas ??= await Api.GetBrands();
		if (Marcas is not null && Marcas.Count == 0)
			Marcas = await Api.GetBrands();

		CbMarca.DataSource = Marcas;
		await PopularDataGrid();

		// Temp
		//TxPlaca.Text = "ABC1234";
		//TxChassi.Text = "1HGCM82633A123456";
		//TxMarca.Text = "Ford";
		//TxModelo.Text = "Fiesta";
		//TxAnoFabricacao.Text = "2010";
		//TxAnoModelo.Text = "2010";
		//TxValorFIPE.Text = "20000.00";
		//TxValorVenda.Text = "25000.00";
		//TxObservacoes.Text = "Carro Novo teste";
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

			CurrentVehicleSelected = (ModelVeiculo)dgvListaVeiculos.CurrentRow.DataBoundItem;

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
			CurrentVehicleSelected = (ModelVeiculo)dgvListaVeiculos.CurrentRow.DataBoundItem;
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
		CbMarca.SelectedItem = null;
		CbModelo.SelectedItem = null;
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
			CurrentVehicleSelected ??= new ModelVeiculo();

			TxPlaca.Text = CurrentVehicleSelected.Placa;
			TxChassi.Text = CurrentVehicleSelected.Chassi;
			CbMarca.SelectedItem = Marcas?.Find(m => m.Codigo == CurrentVehicleSelected.Marca);
			CbModelo.SelectedItem = Modelos?.Modelos?.Find(m => m.Codigo == CurrentVehicleSelected.Modelo);
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
		if (TodosCamposValidos() is (bool CamposValidos, string msg) && !CamposValidos)
		{
			MessageBox.Show(msg);
			return;
		}

		CurrentVehicleSelected ??= new ModelVeiculo();

		var vehicle = new ModelVeiculo
		{
			Id = CurrentVehicleSelected.Id,
			Chassi = TxChassi.Text,
			Marca = CbMarca.SelectedValue.ToString(),
			Modelo = CbModelo.SelectedValue.ToString(),
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

		var cbModelo = (ExtModelsBrand)CbModelo.SelectedItem;
		var modelo = new ModelModelo
		{
			Codigo = cbModelo.Codigo,
			Nome = cbModelo.Nome,
		};

		var cbMarca = (Brand)CbMarca.SelectedItem;
		var marca = new ModelMarca
		{
			Codigo = cbMarca.Codigo,
			Nome = cbMarca.Nome,
		};

		if (CurrentStateEdit == StateEdit.create)
			await ControllerVehicle.Criar(vehicle, marca, modelo);
		else if (CurrentStateEdit == StateEdit.update)
			await ControllerVehicle.Atualizar(vehicle, marca, modelo);

		BtVoltarEdit_Click(sender, e);
	}

	private (bool, string) TodosCamposValidos()
	{
		if (string.IsNullOrEmpty(TxAnoModelo.Text))
			return (false, "O ano do modelo precisa estar preenchido!");
		else if (!int.TryParse(TxAnoModelo.Text, out var anoModelo) && anoModelo == 0)
			return (false, "O ano do modelo precisa ser um ano válido");

		if (!int.TryParse(TxAnoFabricacao.Text, out var anoFabricacao) && anoFabricacao == 0)
			return (false, "O ano da fabricação precisa ser um ano válido");
		else if (string.IsNullOrEmpty(TxAnoFabricacao.Text))
			return (false, "O ano da fabricação precisa estar preenchido!");

		if (string.IsNullOrEmpty(TxChassi.Text))
			return (false, "O Chassi precisa estar preenchido!");

		if (string.IsNullOrEmpty(TxPlaca.Text))
			return (false, "A placa precisa estar preenchido!");

		if (string.IsNullOrEmpty(TxValorFIPE.Text))
			return (false, "O Valor FIPE precisa estar preenchido!");
		else if (!decimal.TryParse(TxValorFIPE.Text, out var valorFipe) && valorFipe <= 0)
			return (false, "O Valor FIPE precisa ser um valor válido.");

		if (string.IsNullOrEmpty(TxValorVenda.Text))
			return (false, "O Valor de venda precisa estar preenchido!");
		else if (!decimal.TryParse(TxValorVenda.Text, out var valorVenda) && valorVenda <= 0)
			return (false, "O Valor de venda precisa ser um valor válido.");

		if (CbMarca.SelectedValue is null)
			return (false, "Necessário escolher uma marca!");

		if (CbModelo.SelectedValue is null)
			return (false, "Necessário escolher um modelo!");

		return (true, "");
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
	#endregion

	private async void CbMarca_SelectedValueChanged(object sender, EventArgs e)
	{
		if (CbMarca.SelectedValue is not null)
		{
			Modelos = await Api.SearchModels(CbMarca.SelectedValue.ToString()!);

			if (Modelos is not null && string.IsNullOrEmpty(Modelos.Error))
				CbModelo.DataSource = Modelos.Modelos;

			if (CurrentStateEdit == StateEdit.update && CurrentVehicleSelected is not null)
			{
				CbModelo.SelectedItem = Modelos?.Modelos?.Find(m => m.Codigo == CurrentVehicleSelected.Modelo);
			}
		}
	}
}
