namespace PP7_4
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.Begin_button = new System.Windows.Forms.Button();
			this.Main_menu = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Main_menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// Begin_button
			// 
			this.Begin_button.Location = new System.Drawing.Point(12, 31);
			this.Begin_button.Name = "Begin_button";
			this.Begin_button.Size = new System.Drawing.Size(209, 94);
			this.Begin_button.TabIndex = 0;
			this.Begin_button.Text = "Begin";
			this.Begin_button.UseVisualStyleBackColor = true;
			this.Begin_button.Click += new System.EventHandler(this.Begin_button_Click);
			// 
			// Main_menu
			// 
			this.Main_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.Main_menu.Location = new System.Drawing.Point(0, 0);
			this.Main_menu.Name = "Main_menu";
			this.Main_menu.Size = new System.Drawing.Size(233, 28);
			this.Main_menu.TabIndex = 1;
			this.Main_menu.Text = "Main menu";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.menuToolStripMenuItem.Text = "Menu";
			this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 138);
			this.Controls.Add(this.Begin_button);
			this.Controls.Add(this.Main_menu);
			this.MainMenuStrip = this.Main_menu;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Main_menu.ResumeLayout(false);
			this.Main_menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Begin_button;
		private System.Windows.Forms.MenuStrip Main_menu;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
	}
}

