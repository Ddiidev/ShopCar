namespace ShopCar.App.Views;

partial class ViewVehicles
{
	/// <summary> 
	/// Variável de designer necessária.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary> 
	/// Limpar os recursos que estão sendo usados.
	/// </summary>
	/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Código gerado pelo Designer de Componentes

	/// <summary> 
	/// Método necessário para suporte ao Designer - não modifique 
	/// o conteúdo deste método com o editor de código.
	/// </summary>
	private void InitializeComponent()
	{
		TabMain = new TabControl();
		PageMain = new TabPage();
		LayoutPanelMain = new TableLayoutPanel();
		dgvListaVeiculos = new DataGridView();
		LayoutPanelTop = new TableLayoutPanel();
		BtVoltar = new Button();
		tableLayoutPanel2 = new TableLayoutPanel();
		BtBuscar = new Button();
		TxCampoBusca = new TextBox();
		tableLayoutPanel3 = new TableLayoutPanel();
		BtNovo = new Button();
		BtEditar = new Button();
		BtDeletar = new Button();
		PageEdit = new TabPage();
		LayoutPanelEditTop = new TableLayoutPanel();
		tableLayoutPanel5 = new TableLayoutPanel();
		BtSalvar = new Button();
		BtCancelar = new Button();
		tableLayoutPanel4 = new TableLayoutPanel();
		BtVoltarEdit = new Button();
		PnContentEdit = new Panel();
		label9 = new Label();
		TxObservacoes = new TextBox();
		label8 = new Label();
		TxValorVenda = new TextBox();
		label7 = new Label();
		TxValorFIPE = new TextBox();
		label6 = new Label();
		TxAnoModelo = new TextBox();
		label5 = new Label();
		TxAnoFabricacao = new TextBox();
		label4 = new Label();
		TxModelo = new TextBox();
		label3 = new Label();
		TxMarca = new TextBox();
		label2 = new Label();
		TxChassi = new TextBox();
		label1 = new Label();
		TxPlaca = new TextBox();
		TabMain.SuspendLayout();
		PageMain.SuspendLayout();
		LayoutPanelMain.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvListaVeiculos).BeginInit();
		LayoutPanelTop.SuspendLayout();
		tableLayoutPanel2.SuspendLayout();
		tableLayoutPanel3.SuspendLayout();
		PageEdit.SuspendLayout();
		LayoutPanelEditTop.SuspendLayout();
		tableLayoutPanel5.SuspendLayout();
		tableLayoutPanel4.SuspendLayout();
		PnContentEdit.SuspendLayout();
		SuspendLayout();
		// 
		// TabMain
		// 
		TabMain.Controls.Add(PageMain);
		TabMain.Controls.Add(PageEdit);
		TabMain.Location = new Point(-3, -25);
		TabMain.Name = "TabMain";
		TabMain.SelectedIndex = 0;
		TabMain.Size = new Size(870, 632);
		TabMain.TabIndex = 0;
		// 
		// PageMain
		// 
		PageMain.Controls.Add(LayoutPanelMain);
		PageMain.Location = new Point(4, 25);
		PageMain.Name = "PageMain";
		PageMain.Padding = new Padding(3);
		PageMain.Size = new Size(862, 603);
		PageMain.TabIndex = 0;
		PageMain.Text = "PageMain";
		PageMain.UseVisualStyleBackColor = true;
		// 
		// LayoutPanelMain
		// 
		LayoutPanelMain.ColumnCount = 1;
		LayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
		LayoutPanelMain.Controls.Add(dgvListaVeiculos, 0, 1);
		LayoutPanelMain.Controls.Add(LayoutPanelTop, 0, 0);
		LayoutPanelMain.Controls.Add(tableLayoutPanel3, 0, 2);
		LayoutPanelMain.Dock = DockStyle.Fill;
		LayoutPanelMain.Location = new Point(3, 3);
		LayoutPanelMain.Name = "LayoutPanelMain";
		LayoutPanelMain.RowCount = 3;
		LayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5360441F));
		LayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 89.46396F));
		LayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
		LayoutPanelMain.Size = new Size(856, 597);
		LayoutPanelMain.TabIndex = 1;
		// 
		// dgvListaVeiculos
		// 
		dgvListaVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvListaVeiculos.Dock = DockStyle.Fill;
		dgvListaVeiculos.Location = new Point(3, 60);
		dgvListaVeiculos.Name = "dgvListaVeiculos";
		dgvListaVeiculos.RowTemplate.Height = 25;
		dgvListaVeiculos.Size = new Size(850, 478);
		dgvListaVeiculos.TabIndex = 1;
		// 
		// LayoutPanelTop
		// 
		LayoutPanelTop.ColumnCount = 2;
		LayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.767442F));
		LayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.23256F));
		LayoutPanelTop.Controls.Add(BtVoltar, 0, 0);
		LayoutPanelTop.Controls.Add(tableLayoutPanel2, 1, 0);
		LayoutPanelTop.Dock = DockStyle.Fill;
		LayoutPanelTop.Location = new Point(3, 3);
		LayoutPanelTop.Name = "LayoutPanelTop";
		LayoutPanelTop.Padding = new Padding(5);
		LayoutPanelTop.RowCount = 1;
		LayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
		LayoutPanelTop.Size = new Size(850, 51);
		LayoutPanelTop.TabIndex = 3;
		// 
		// BtVoltar
		// 
		BtVoltar.Dock = DockStyle.Fill;
		BtVoltar.Location = new Point(8, 8);
		BtVoltar.Name = "BtVoltar";
		BtVoltar.Size = new Size(76, 35);
		BtVoltar.TabIndex = 2;
		BtVoltar.Text = "< Voltar";
		BtVoltar.UseVisualStyleBackColor = true;
		BtVoltar.Click += BtVoltar_Click;
		// 
		// tableLayoutPanel2
		// 
		tableLayoutPanel2.ColumnCount = 2;
		tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.5164261F));
		tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4835739F));
		tableLayoutPanel2.Controls.Add(BtBuscar, 1, 0);
		tableLayoutPanel2.Controls.Add(TxCampoBusca, 0, 0);
		tableLayoutPanel2.Dock = DockStyle.Fill;
		tableLayoutPanel2.Location = new Point(90, 8);
		tableLayoutPanel2.Name = "tableLayoutPanel2";
		tableLayoutPanel2.RowCount = 1;
		tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
		tableLayoutPanel2.Size = new Size(752, 35);
		tableLayoutPanel2.TabIndex = 3;
		// 
		// BtBuscar
		// 
		BtBuscar.Dock = DockStyle.Fill;
		BtBuscar.Location = new Point(661, 3);
		BtBuscar.Name = "BtBuscar";
		BtBuscar.Size = new Size(88, 29);
		BtBuscar.TabIndex = 3;
		BtBuscar.Text = "Buscar 🔎";
		BtBuscar.UseVisualStyleBackColor = true;
		BtBuscar.Click += BtBuscar_Click;
		// 
		// TxCampoBusca
		// 
		TxCampoBusca.Dock = DockStyle.Fill;
		TxCampoBusca.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
		TxCampoBusca.Location = new Point(3, 3);
		TxCampoBusca.Name = "TxCampoBusca";
		TxCampoBusca.Size = new Size(652, 29);
		TxCampoBusca.TabIndex = 0;
		// 
		// tableLayoutPanel3
		// 
		tableLayoutPanel3.ColumnCount = 3;
		tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		tableLayoutPanel3.Controls.Add(BtNovo, 0, 0);
		tableLayoutPanel3.Controls.Add(BtEditar, 0, 0);
		tableLayoutPanel3.Controls.Add(BtDeletar, 0, 0);
		tableLayoutPanel3.Dock = DockStyle.Fill;
		tableLayoutPanel3.Location = new Point(3, 544);
		tableLayoutPanel3.Name = "tableLayoutPanel3";
		tableLayoutPanel3.RowCount = 1;
		tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		tableLayoutPanel3.Size = new Size(850, 50);
		tableLayoutPanel3.TabIndex = 4;
		// 
		// BtNovo
		// 
		BtNovo.Dock = DockStyle.Fill;
		BtNovo.Location = new Point(569, 3);
		BtNovo.Name = "BtNovo";
		BtNovo.Size = new Size(278, 44);
		BtNovo.TabIndex = 5;
		BtNovo.Text = "➕ Novo";
		BtNovo.UseVisualStyleBackColor = true;
		BtNovo.Click += BtNovo_Click;
		// 
		// BtEditar
		// 
		BtEditar.Dock = DockStyle.Fill;
		BtEditar.Location = new Point(286, 3);
		BtEditar.Name = "BtEditar";
		BtEditar.Size = new Size(277, 44);
		BtEditar.TabIndex = 4;
		BtEditar.Text = "✏️ Editar";
		BtEditar.UseVisualStyleBackColor = true;
		BtEditar.Click += BtEditar_Click;
		// 
		// BtDeletar
		// 
		BtDeletar.Dock = DockStyle.Fill;
		BtDeletar.Location = new Point(3, 3);
		BtDeletar.Name = "BtDeletar";
		BtDeletar.Size = new Size(277, 44);
		BtDeletar.TabIndex = 3;
		BtDeletar.Text = "❌ Deletar";
		BtDeletar.UseVisualStyleBackColor = true;
		BtDeletar.Click += BtDeletar_Click;
		// 
		// PageEdit
		// 
		PageEdit.Controls.Add(LayoutPanelEditTop);
		PageEdit.Location = new Point(4, 25);
		PageEdit.Name = "PageEdit";
		PageEdit.Padding = new Padding(3);
		PageEdit.Size = new Size(862, 603);
		PageEdit.TabIndex = 1;
		PageEdit.Text = "tabPage2";
		PageEdit.UseVisualStyleBackColor = true;
		// 
		// LayoutPanelEditTop
		// 
		LayoutPanelEditTop.ColumnCount = 1;
		LayoutPanelEditTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
		LayoutPanelEditTop.Controls.Add(tableLayoutPanel5, 0, 2);
		LayoutPanelEditTop.Controls.Add(tableLayoutPanel4, 0, 0);
		LayoutPanelEditTop.Controls.Add(PnContentEdit, 0, 1);
		LayoutPanelEditTop.Dock = DockStyle.Fill;
		LayoutPanelEditTop.Location = new Point(3, 3);
		LayoutPanelEditTop.Name = "LayoutPanelEditTop";
		LayoutPanelEditTop.RowCount = 3;
		LayoutPanelEditTop.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7485609F));
		LayoutPanelEditTop.RowStyles.Add(new RowStyle(SizeType.Percent, 89.25144F));
		LayoutPanelEditTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
		LayoutPanelEditTop.Size = new Size(856, 597);
		LayoutPanelEditTop.TabIndex = 0;
		// 
		// tableLayoutPanel5
		// 
		tableLayoutPanel5.ColumnCount = 3;
		tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		tableLayoutPanel5.Controls.Add(BtSalvar, 2, 0);
		tableLayoutPanel5.Controls.Add(BtCancelar, 1, 0);
		tableLayoutPanel5.Dock = DockStyle.Fill;
		tableLayoutPanel5.Location = new Point(3, 524);
		tableLayoutPanel5.Name = "tableLayoutPanel5";
		tableLayoutPanel5.Padding = new Padding(5);
		tableLayoutPanel5.RowCount = 1;
		tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		tableLayoutPanel5.Size = new Size(850, 70);
		tableLayoutPanel5.TabIndex = 5;
		// 
		// BtSalvar
		// 
		BtSalvar.Dock = DockStyle.Fill;
		BtSalvar.Location = new Point(566, 8);
		BtSalvar.Name = "BtSalvar";
		BtSalvar.Size = new Size(276, 54);
		BtSalvar.TabIndex = 3;
		BtSalvar.Text = "💾 Salvar";
		BtSalvar.UseVisualStyleBackColor = true;
		BtSalvar.Click += BtSalvar_Click;
		// 
		// BtCancelar
		// 
		BtCancelar.Dock = DockStyle.Fill;
		BtCancelar.Location = new Point(287, 8);
		BtCancelar.Name = "BtCancelar";
		BtCancelar.Size = new Size(273, 54);
		BtCancelar.TabIndex = 4;
		BtCancelar.Text = "❌ Cancelar";
		BtCancelar.UseVisualStyleBackColor = true;
		BtCancelar.Click += BtCancelar_Click;
		// 
		// tableLayoutPanel4
		// 
		tableLayoutPanel4.ColumnCount = 2;
		tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.767442F));
		tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.23256F));
		tableLayoutPanel4.Controls.Add(BtVoltarEdit, 0, 0);
		tableLayoutPanel4.Dock = DockStyle.Fill;
		tableLayoutPanel4.Location = new Point(3, 3);
		tableLayoutPanel4.Name = "tableLayoutPanel4";
		tableLayoutPanel4.Padding = new Padding(5);
		tableLayoutPanel4.RowCount = 1;
		tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
		tableLayoutPanel4.Size = new Size(850, 50);
		tableLayoutPanel4.TabIndex = 4;
		// 
		// BtVoltarEdit
		// 
		BtVoltarEdit.Dock = DockStyle.Fill;
		BtVoltarEdit.Location = new Point(8, 8);
		BtVoltarEdit.Name = "BtVoltarEdit";
		BtVoltarEdit.Size = new Size(76, 34);
		BtVoltarEdit.TabIndex = 2;
		BtVoltarEdit.Text = "< Voltar";
		BtVoltarEdit.UseVisualStyleBackColor = true;
		BtVoltarEdit.Click += BtVoltarEdit_Click;
		// 
		// PnContentEdit
		// 
		PnContentEdit.Controls.Add(label9);
		PnContentEdit.Controls.Add(TxObservacoes);
		PnContentEdit.Controls.Add(label8);
		PnContentEdit.Controls.Add(TxValorVenda);
		PnContentEdit.Controls.Add(label7);
		PnContentEdit.Controls.Add(TxValorFIPE);
		PnContentEdit.Controls.Add(label6);
		PnContentEdit.Controls.Add(TxAnoModelo);
		PnContentEdit.Controls.Add(label5);
		PnContentEdit.Controls.Add(TxAnoFabricacao);
		PnContentEdit.Controls.Add(label4);
		PnContentEdit.Controls.Add(TxModelo);
		PnContentEdit.Controls.Add(label3);
		PnContentEdit.Controls.Add(TxMarca);
		PnContentEdit.Controls.Add(label2);
		PnContentEdit.Controls.Add(TxChassi);
		PnContentEdit.Controls.Add(label1);
		PnContentEdit.Controls.Add(TxPlaca);
		PnContentEdit.Dock = DockStyle.Fill;
		PnContentEdit.Location = new Point(3, 59);
		PnContentEdit.Name = "PnContentEdit";
		PnContentEdit.Size = new Size(850, 459);
		PnContentEdit.TabIndex = 6;
		// 
		// label9
		// 
		label9.AutoSize = true;
		label9.Location = new Point(566, 39);
		label9.Name = "label9";
		label9.Size = new Size(82, 16);
		label9.TabIndex = 17;
		label9.Text = "Observacoes";
		// 
		// TxObservacoes
		// 
		TxObservacoes.Location = new Point(566, 58);
		TxObservacoes.Multiline = true;
		TxObservacoes.Name = "TxObservacoes";
		TxObservacoes.Size = new Size(250, 126);
		TxObservacoes.TabIndex = 16;
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Location = new Point(287, 294);
		label8.Name = "label8";
		label8.Size = new Size(79, 16);
		label8.TabIndex = 15;
		label8.Text = "Valor Venda";
		// 
		// TxValorVenda
		// 
		TxValorVenda.Location = new Point(287, 313);
		TxValorVenda.Multiline = true;
		TxValorVenda.Name = "TxValorVenda";
		TxValorVenda.Size = new Size(214, 44);
		TxValorVenda.TabIndex = 14;
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Location = new Point(287, 205);
		label7.Name = "label7";
		label7.Size = new Size(69, 16);
		label7.TabIndex = 13;
		label7.Text = "Valor FIPE";
		// 
		// TxValorFIPE
		// 
		TxValorFIPE.Location = new Point(287, 224);
		TxValorFIPE.Multiline = true;
		TxValorFIPE.Name = "TxValorFIPE";
		TxValorFIPE.Size = new Size(214, 44);
		TxValorFIPE.TabIndex = 12;
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new Point(287, 121);
		label6.Name = "label6";
		label6.Size = new Size(74, 16);
		label6.TabIndex = 11;
		label6.Text = "Ano Modelo";
		// 
		// TxAnoModelo
		// 
		TxAnoModelo.Location = new Point(287, 140);
		TxAnoModelo.Multiline = true;
		TxAnoModelo.Name = "TxAnoModelo";
		TxAnoModelo.Size = new Size(214, 44);
		TxAnoModelo.TabIndex = 10;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(287, 39);
		label5.Name = "label5";
		label5.Size = new Size(95, 16);
		label5.TabIndex = 9;
		label5.Text = "Ano fabricação";
		// 
		// TxAnoFabricacao
		// 
		TxAnoFabricacao.Location = new Point(287, 58);
		TxAnoFabricacao.Multiline = true;
		TxAnoFabricacao.Name = "TxAnoFabricacao";
		TxAnoFabricacao.Size = new Size(214, 44);
		TxAnoFabricacao.TabIndex = 8;
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(30, 294);
		label4.Name = "label4";
		label4.Size = new Size(49, 16);
		label4.TabIndex = 7;
		label4.Text = "Modelo";
		// 
		// TxModelo
		// 
		TxModelo.Location = new Point(30, 313);
		TxModelo.Multiline = true;
		TxModelo.Name = "TxModelo";
		TxModelo.Size = new Size(214, 44);
		TxModelo.TabIndex = 6;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(30, 205);
		label3.Name = "label3";
		label3.Size = new Size(41, 16);
		label3.TabIndex = 5;
		label3.Text = "Marca";
		// 
		// TxMarca
		// 
		TxMarca.Location = new Point(30, 224);
		TxMarca.Multiline = true;
		TxMarca.Name = "TxMarca";
		TxMarca.Size = new Size(214, 44);
		TxMarca.TabIndex = 4;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(30, 121);
		label2.Name = "label2";
		label2.Size = new Size(47, 16);
		label2.TabIndex = 3;
		label2.Text = "Chassi";
		// 
		// TxChassi
		// 
		TxChassi.Location = new Point(30, 140);
		TxChassi.Multiline = true;
		TxChassi.Name = "TxChassi";
		TxChassi.Size = new Size(214, 44);
		TxChassi.TabIndex = 2;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(30, 39);
		label1.Name = "label1";
		label1.Size = new Size(40, 16);
		label1.TabIndex = 1;
		label1.Text = "Placa";
		// 
		// TxPlaca
		// 
		TxPlaca.Location = new Point(30, 58);
		TxPlaca.Multiline = true;
		TxPlaca.Name = "TxPlaca";
		TxPlaca.Size = new Size(214, 44);
		TxPlaca.TabIndex = 0;
		// 
		// ViewVehicles
		// 
		AutoScaleDimensions = new SizeF(7F, 16F);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(TabMain);
		Name = "ViewVehicles";
		Size = new Size(866, 600);
		Load += ViewVehicles_Load;
		TabMain.ResumeLayout(false);
		PageMain.ResumeLayout(false);
		LayoutPanelMain.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dgvListaVeiculos).EndInit();
		LayoutPanelTop.ResumeLayout(false);
		tableLayoutPanel2.ResumeLayout(false);
		tableLayoutPanel2.PerformLayout();
		tableLayoutPanel3.ResumeLayout(false);
		PageEdit.ResumeLayout(false);
		LayoutPanelEditTop.ResumeLayout(false);
		tableLayoutPanel5.ResumeLayout(false);
		tableLayoutPanel4.ResumeLayout(false);
		PnContentEdit.ResumeLayout(false);
		PnContentEdit.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private TabControl TabMain;
	private TabPage PageMain;
	private TableLayoutPanel LayoutPanelMain;
	private DataGridView dgvListaVeiculos;
	private TableLayoutPanel LayoutPanelTop;
	private Button BtVoltar;
	private TableLayoutPanel tableLayoutPanel2;
	private Button BtBuscar;
	private TextBox TxCampoBusca;
	private TableLayoutPanel tableLayoutPanel3;
	private Button BtNovo;
	private Button BtEditar;
	private Button BtDeletar;
	private TabPage PageEdit;
	private TableLayoutPanel LayoutPanelEditTop;
	private TableLayoutPanel tableLayoutPanel4;
	private Button BtVoltarEdit;
	private TableLayoutPanel tableLayoutPanel5;
	private Button BtSalvar;
	private Button BtCancelar;
	private Panel PnContentEdit;
	private TextBox TxPlaca;
	private Label label9;
	private TextBox TxObservacoes;
	private Label label8;
	private TextBox TxValorVenda;
	private Label label7;
	private TextBox TxValorFIPE;
	private Label label6;
	private TextBox TxAnoModelo;
	private Label label5;
	private TextBox TxAnoFabricacao;
	private Label label4;
	private TextBox TxModelo;
	private Label label3;
	private TextBox TxMarca;
	private Label label2;
	private TextBox TxChassi;
	private Label label1;
}
