namespace ShopCar.App.Views;

partial class ViewVeicles
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
		this.DgListVeicles = new DataGridView();
		this.BtNew = new Button();
		splitContainer2 = new SplitContainer();
		TxSearch = new TextBox();
		splitter1 = new Splitter();
		BtFind = new Button();
		tableLayoutPanel1 = new TableLayoutPanel();
		button2 = new Button();
		BtDelete = new Button();
		tableLayoutPanel2 = new TableLayoutPanel();
		((System.ComponentModel.ISupportInitialize)this.DgListVeicles).BeginInit();
		((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
		splitContainer2.Panel1.SuspendLayout();
		splitContainer2.Panel2.SuspendLayout();
		splitContainer2.SuspendLayout();
		tableLayoutPanel1.SuspendLayout();
		tableLayoutPanel2.SuspendLayout();
		SuspendLayout();
		// 
		// DgListVeicles
		// 
		this.DgListVeicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DgListVeicles.Location = new Point(3, 73);
		this.DgListVeicles.Name = "DgListVeicles";
		this.DgListVeicles.RowTemplate.Height = 25;
		this.DgListVeicles.Size = new Size(819, 412);
		this.DgListVeicles.TabIndex = 0;
		// 
		// BtNew
		// 
		this.BtNew.Dock = DockStyle.Left;
		this.BtNew.Location = new Point(3, 3);
		this.BtNew.Name = "BtNew";
		this.BtNew.Size = new Size(196, 37);
		this.BtNew.TabIndex = 1;
		this.BtNew.Text = "Novo";
		this.BtNew.UseVisualStyleBackColor = true;
		this.BtNew.Click += this.BtNew_Click;
		// 
		// splitContainer2
		// 
		splitContainer2.Location = new Point(3, 3);
		splitContainer2.Name = "splitContainer2";
		// 
		// splitContainer2.Panel1
		// 
		splitContainer2.Panel1.Controls.Add(TxSearch);
		splitContainer2.Panel1.Padding = new Padding(7);
		// 
		// splitContainer2.Panel2
		// 
		splitContainer2.Panel2.Controls.Add(splitter1);
		splitContainer2.Panel2.Controls.Add(BtFind);
		splitContainer2.Panel2.Padding = new Padding(7);
		splitContainer2.Size = new Size(819, 64);
		splitContainer2.SplitterDistance = 682;
		splitContainer2.TabIndex = 4;
		// 
		// TxSearch
		// 
		TxSearch.AcceptsReturn = true;
		TxSearch.Dock = DockStyle.Fill;
		TxSearch.Location = new Point(7, 7);
		TxSearch.Multiline = true;
		TxSearch.Name = "TxSearch";
		TxSearch.Size = new Size(668, 50);
		TxSearch.TabIndex = 0;
		// 
		// splitter1
		// 
		splitter1.Dock = DockStyle.Right;
		splitter1.Location = new Point(123, 7);
		splitter1.Name = "splitter1";
		splitter1.Size = new Size(3, 50);
		splitter1.TabIndex = 2;
		splitter1.TabStop = false;
		// 
		// BtFind
		// 
		BtFind.Dock = DockStyle.Fill;
		BtFind.Location = new Point(7, 7);
		BtFind.Name = "BtFind";
		BtFind.Size = new Size(119, 50);
		BtFind.TabIndex = 1;
		BtFind.Text = "Buscar";
		BtFind.UseVisualStyleBackColor = true;
		// 
		// tableLayoutPanel1
		// 
		tableLayoutPanel1.ColumnCount = 3;
		tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.6237831F));
		tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.3762169F));
		tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 311F));
		tableLayoutPanel1.Controls.Add(button2, 1, 0);
		tableLayoutPanel1.Controls.Add(this.BtNew, 0, 0);
		tableLayoutPanel1.Controls.Add(BtDelete, 2, 0);
		tableLayoutPanel1.Location = new Point(3, 517);
		tableLayoutPanel1.Name = "tableLayoutPanel1";
		tableLayoutPanel1.RowCount = 1;
		tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
		tableLayoutPanel1.Size = new Size(819, 43);
		tableLayoutPanel1.TabIndex = 5;
		// 
		// button2
		// 
		button2.Dock = DockStyle.Fill;
		button2.Location = new Point(310, 3);
		button2.Name = "button2";
		button2.Size = new Size(194, 37);
		button2.TabIndex = 3;
		button2.Text = "Editar";
		button2.UseVisualStyleBackColor = true;
		// 
		// BtDelete
		// 
		BtDelete.Dock = DockStyle.Right;
		BtDelete.Location = new Point(620, 3);
		BtDelete.Name = "BtDelete";
		BtDelete.Size = new Size(196, 37);
		BtDelete.TabIndex = 2;
		BtDelete.Text = "Remover";
		BtDelete.UseVisualStyleBackColor = true;
		// 
		// tableLayoutPanel2
		// 
		tableLayoutPanel2.ColumnCount = 1;
		tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
		tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 2);
		tableLayoutPanel2.Controls.Add(splitContainer2, 0, 0);
		tableLayoutPanel2.Controls.Add(this.DgListVeicles, 0, 1);
		tableLayoutPanel2.Location = new Point(13, 18);
		tableLayoutPanel2.Name = "tableLayoutPanel2";
		tableLayoutPanel2.RowCount = 3;
		tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
		tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 89.50749F));
		tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4925051F));
		tableLayoutPanel2.Size = new Size(825, 567);
		tableLayoutPanel2.TabIndex = 6;
		// 
		// ViewVeicles
		// 
		AutoScaleDimensions = new SizeF(7F, 16F);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(tableLayoutPanel2);
		Name = "ViewVeicles";
		Size = new Size(866, 600);
		((System.ComponentModel.ISupportInitialize)this.DgListVeicles).EndInit();
		splitContainer2.Panel1.ResumeLayout(false);
		splitContainer2.Panel1.PerformLayout();
		splitContainer2.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
		splitContainer2.ResumeLayout(false);
		tableLayoutPanel1.ResumeLayout(false);
		tableLayoutPanel2.ResumeLayout(false);
		ResumeLayout(false);
	}

	#endregion

	private DataGridView dataGridView1;
	private Button button1;
	private TextBox textBox1;
	private TextBox textBox2;
	private SplitContainer splitContainer2;
	private TextBox TxSearch;
	private Splitter splitter1;
	private Button BtFind;
	private TableLayoutPanel tableLayoutPanel1;
	private Button button2;
	private Button BtDelete;
	private TableLayoutPanel tableLayoutPanel2;
}
