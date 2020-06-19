namespace PP7_9
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
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.addButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.remaveAllButton = new System.Windows.Forms.Button();
			this.addNodeTextBox = new System.Windows.Forms.TextBox();
			this.findButton = new System.Windows.Forms.Button();
			this.findNodeTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 12);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(271, 426);
			this.treeView1.TabIndex = 0;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(300, 12);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(119, 56);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(300, 74);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(119, 56);
			this.removeButton.TabIndex = 2;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// remaveAllButton
			// 
			this.remaveAllButton.Location = new System.Drawing.Point(300, 136);
			this.remaveAllButton.Name = "remaveAllButton";
			this.remaveAllButton.Size = new System.Drawing.Size(119, 56);
			this.remaveAllButton.TabIndex = 3;
			this.remaveAllButton.Text = "Remove All";
			this.remaveAllButton.UseVisualStyleBackColor = true;
			this.remaveAllButton.Click += new System.EventHandler(this.remaveAllButton_Click);
			// 
			// addNodeTextBox
			// 
			this.addNodeTextBox.Location = new System.Drawing.Point(441, 12);
			this.addNodeTextBox.Name = "addNodeTextBox";
			this.addNodeTextBox.Size = new System.Drawing.Size(119, 22);
			this.addNodeTextBox.TabIndex = 4;
			// 
			// findButton
			// 
			this.findButton.Location = new System.Drawing.Point(300, 198);
			this.findButton.Name = "findButton";
			this.findButton.Size = new System.Drawing.Size(119, 56);
			this.findButton.TabIndex = 5;
			this.findButton.Text = "Find";
			this.findButton.UseVisualStyleBackColor = true;
			this.findButton.Click += new System.EventHandler(this.findButton_Click);
			// 
			// findNodeTextBox
			// 
			this.findNodeTextBox.Location = new System.Drawing.Point(441, 198);
			this.findNodeTextBox.Name = "findNodeTextBox";
			this.findNodeTextBox.Size = new System.Drawing.Size(119, 22);
			this.findNodeTextBox.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 450);
			this.Controls.Add(this.findNodeTextBox);
			this.Controls.Add(this.findButton);
			this.Controls.Add(this.addNodeTextBox);
			this.Controls.Add(this.remaveAllButton);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.treeView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Click += new System.EventHandler(this.Form1_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button remaveAllButton;
		private System.Windows.Forms.TextBox addNodeTextBox;
		private System.Windows.Forms.Button findButton;
		private System.Windows.Forms.TextBox findNodeTextBox;
	}
}

