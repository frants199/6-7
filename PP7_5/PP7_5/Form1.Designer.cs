namespace PP7_5
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
			this.Main_menu = new System.Windows.Forms.MenuStrip();
			this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
			this.edit_menu = new System.Windows.Forms.ToolStripMenuItem();
			this.cut_Item = new System.Windows.Forms.ToolStripMenuItem();
			this.copy_Item = new System.Windows.Forms.ToolStripMenuItem();
			this.paste_Item = new System.Windows.Forms.ToolStripMenuItem();
			this.Add_button = new System.Windows.Forms.Button();
			this.get_info_button = new System.Windows.Forms.Button();
			this.Main_menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// Main_menu
			// 
			this.Main_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.edit_menu});
			this.Main_menu.Location = new System.Drawing.Point(0, 0);
			this.Main_menu.Name = "Main_menu";
			this.Main_menu.Size = new System.Drawing.Size(398, 28);
			this.Main_menu.TabIndex = 0;
			this.Main_menu.Text = "menuStrip1";
			// 
			// file_menu
			// 
			this.file_menu.Name = "file_menu";
			this.file_menu.Size = new System.Drawing.Size(44, 24);
			this.file_menu.Text = "File";
			// 
			// edit_menu
			// 
			this.edit_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cut_Item,
            this.copy_Item,
            this.paste_Item});
			this.edit_menu.Name = "edit_menu";
			this.edit_menu.Size = new System.Drawing.Size(47, 24);
			this.edit_menu.Text = "Edit";
			// 
			// cut_Item
			// 
			this.cut_Item.Name = "cut_Item";
			this.cut_Item.Size = new System.Drawing.Size(216, 26);
			this.cut_Item.Text = "Cut";
			this.cut_Item.Click += new System.EventHandler(this.cut_Item_Click);
			// 
			// copy_Item
			// 
			this.copy_Item.Name = "copy_Item";
			this.copy_Item.Size = new System.Drawing.Size(216, 26);
			this.copy_Item.Text = "Copy";
			this.copy_Item.Click += new System.EventHandler(this.copy_Item_Click);
			// 
			// paste_Item
			// 
			this.paste_Item.Name = "paste_Item";
			this.paste_Item.Size = new System.Drawing.Size(216, 26);
			this.paste_Item.Text = "Paste";
			this.paste_Item.Click += new System.EventHandler(this.paste_Item_Click);
			// 
			// Add_button
			// 
			this.Add_button.Location = new System.Drawing.Point(12, 31);
			this.Add_button.Name = "Add_button";
			this.Add_button.Size = new System.Drawing.Size(145, 37);
			this.Add_button.TabIndex = 1;
			this.Add_button.Text = "Add context menu";
			this.Add_button.UseVisualStyleBackColor = true;
			this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
			// 
			// get_info_button
			// 
			this.get_info_button.Location = new System.Drawing.Point(224, 31);
			this.get_info_button.Name = "get_info_button";
			this.get_info_button.Size = new System.Drawing.Size(162, 37);
			this.get_info_button.TabIndex = 2;
			this.get_info_button.Text = "Get info";
			this.get_info_button.UseVisualStyleBackColor = true;
			this.get_info_button.Click += new System.EventHandler(this.get_info_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 78);
			this.Controls.Add(this.get_info_button);
			this.Controls.Add(this.Add_button);
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

		private System.Windows.Forms.MenuStrip Main_menu;
		private System.Windows.Forms.ToolStripMenuItem file_menu;
		private System.Windows.Forms.ToolStripMenuItem edit_menu;
		private System.Windows.Forms.ToolStripMenuItem cut_Item;
		private System.Windows.Forms.ToolStripMenuItem copy_Item;
		private System.Windows.Forms.ToolStripMenuItem paste_Item;
		private System.Windows.Forms.Button Add_button;
		private System.Windows.Forms.Button get_info_button;
	}
}

