namespace PP7_3
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
			this.get_elements_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// get_elements_button
			// 
			this.get_elements_button.Location = new System.Drawing.Point(12, 12);
			this.get_elements_button.Name = "get_elements_button";
			this.get_elements_button.Size = new System.Drawing.Size(262, 76);
			this.get_elements_button.TabIndex = 0;
			this.get_elements_button.Text = "Get elements";
			this.get_elements_button.UseVisualStyleBackColor = true;
			this.get_elements_button.Click += new System.EventHandler(this.get_elements_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 100);
			this.Controls.Add(this.get_elements_button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button get_elements_button;
	}
}

