namespace ShopCar.App.Views;

partial class ViewChoicePage
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
		BtVoltarLogin = new Button();
		BtIrVeículos = new Button();
		SuspendLayout();
		// 
		// BtVoltarLogin
		// 
		BtVoltarLogin.Location = new Point(244, 195);
		BtVoltarLogin.Name = "BtVoltarLogin";
		BtVoltarLogin.Size = new Size(174, 102);
		BtVoltarLogin.TabIndex = 0;
		BtVoltarLogin.Text = "Voltar para o login";
		BtVoltarLogin.UseVisualStyleBackColor = true;
		BtVoltarLogin.Click += BtVoltarLogin_Click;
		// 
		// BtIrVeículos
		// 
		BtIrVeículos.Location = new Point(446, 195);
		BtIrVeículos.Name = "BtIrVeículos";
		BtIrVeículos.Size = new Size(174, 102);
		BtIrVeículos.TabIndex = 1;
		BtIrVeículos.Text = "Ir para os veículos";
		BtIrVeículos.UseVisualStyleBackColor = true;
		BtIrVeículos.Click += BtIrVeículos_Click;
		// 
		// ViewChoice
		// 
		AutoScaleDimensions = new SizeF(7F, 16F);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(BtIrVeículos);
		Controls.Add(BtVoltarLogin);
		Name = "ViewChoice";
		Size = new Size(866, 600);
		ResumeLayout(false);
	}

	#endregion

	private Button BtVoltarLogin;
	private Button BtIrVeículos;
}
