namespace ShopCar;

partial class FormMain
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		PnContainer = new Panel();
		SuspendLayout();
		// 
		// Container
		// 
		PnContainer.Dock = DockStyle.Fill;
		PnContainer.Location = new Point(5, 5);
		PnContainer.Name = "Container";
		PnContainer.Size = new Size(866, 600);
		PnContainer.TabIndex = 0;
		// 
		// FormMain
		// 
		AutoScaleDimensions = new SizeF(7F, 16F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(876, 610);
		Controls.Add(PnContainer);
		Name = "FormMain";
		Padding = new Padding(5);
		Text = "ShopCar";
		ResumeLayout(false);
	}

	#endregion

	private Panel PnContainer;
}
