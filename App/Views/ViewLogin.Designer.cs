namespace ShopCar.App.Views;

partial class ViewLogin
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
		TxUser = new TextBox();
		TxPass = new TextBox();
		BtLogin = new Button();
		LbTitle = new Label();
		SuspendLayout();
		// 
		// TxUser
		// 
		TxUser.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
		TxUser.Location = new Point(116, 258);
		TxUser.Multiline = true;
		TxUser.Name = "TxUser";
		TxUser.Size = new Size(252, 33);
		TxUser.TabIndex = 0;
		TxUser.TextAlign = HorizontalAlignment.Center;
		// 
		// TxPass
		// 
		TxPass.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
		TxPass.Location = new Point(116, 324);
		TxPass.Multiline = true;
		TxPass.Name = "TxPass";
		TxPass.Size = new Size(252, 33);
		TxPass.TabIndex = 1;
		TxPass.TextAlign = HorizontalAlignment.Center;
		// 
		// BtLogin
		// 
		BtLogin.Location = new Point(188, 378);
		BtLogin.Name = "BtLogin";
		BtLogin.Size = new Size(95, 39);
		BtLogin.TabIndex = 2;
		BtLogin.Text = "Login";
		BtLogin.UseVisualStyleBackColor = true;
		// 
		// LbTitle
		// 
		LbTitle.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
		LbTitle.Location = new Point(116, 81);
		LbTitle.Name = "LbTitle";
		LbTitle.Size = new Size(252, 98);
		LbTitle.TabIndex = 3;
		LbTitle.Text = "Bem vindo ao ShopCar";
		LbTitle.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// ViewLogin
		// 
		AutoScaleDimensions = new SizeF(7F, 17F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.Transparent;
		Controls.Add(LbTitle);
		Controls.Add(BtLogin);
		Controls.Add(TxPass);
		Controls.Add(TxUser);
		Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
		Name = "ViewLogin";
		Size = new Size(477, 487);
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private TextBox TxUser;
	private TextBox TxPass;
	private Button BtLogin;
	private Label LbTitle;
}
