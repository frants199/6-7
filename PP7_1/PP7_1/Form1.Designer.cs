namespace PP7_1
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
			this.divider_box = new System.Windows.Forms.TextBox();
			this.dividend_box = new System.Windows.Forms.TextBox();
			this.rezult_label = new System.Windows.Forms.Label();
			this.calculate_button = new System.Windows.Forms.Button();
			this.Ststus_strip = new System.Windows.Forms.StatusStrip();
			this.DivideByZero_item = new System.Windows.Forms.ToolStripStatusLabel();
			this.Paint_item = new System.Windows.Forms.ToolStripStatusLabel();
			this.Ststus_strip.SuspendLayout();
			this.SuspendLayout();
			// 
			// divider_box
			// 
			this.divider_box.Location = new System.Drawing.Point(26, 75);
			this.divider_box.Name = "divider_box";
			this.divider_box.Size = new System.Drawing.Size(100, 22);
			this.divider_box.TabIndex = 0;
			// 
			// dividend_box
			// 
			this.dividend_box.Location = new System.Drawing.Point(26, 28);
			this.dividend_box.Name = "dividend_box";
			this.dividend_box.Size = new System.Drawing.Size(100, 22);
			this.dividend_box.TabIndex = 1;
			// 
			// rezult_label
			// 
			this.rezult_label.AutoSize = true;
			this.rezult_label.Location = new System.Drawing.Point(198, 28);
			this.rezult_label.Name = "rezult_label";
			this.rezult_label.Size = new System.Drawing.Size(43, 17);
			this.rezult_label.TabIndex = 2;
			this.rezult_label.Text = "rezult";
			// 
			// calculate_button
			// 
			this.calculate_button.Location = new System.Drawing.Point(166, 63);
			this.calculate_button.Name = "calculate_button";
			this.calculate_button.Size = new System.Drawing.Size(98, 34);
			this.calculate_button.TabIndex = 3;
			this.calculate_button.Text = "Calculate";
			this.calculate_button.UseVisualStyleBackColor = true;
			this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
			// 
			// Ststus_strip
			// 
			this.Ststus_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.Ststus_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DivideByZero_item,
            this.Paint_item});
			this.Ststus_strip.Location = new System.Drawing.Point(0, 152);
			this.Ststus_strip.Name = "Ststus_strip";
			this.Ststus_strip.Size = new System.Drawing.Size(288, 25);
			this.Ststus_strip.TabIndex = 4;
			this.Ststus_strip.Text = "Ststus_Strip";
			this.Ststus_strip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ststus_strip_MouseClick);
			this.Ststus_strip.Resize += new System.EventHandler(this.Ststus_strip_Resize);
			// 
			// DivideByZero_item
			// 
			this.DivideByZero_item.AutoSize = false;
			this.DivideByZero_item.Name = "DivideByZero_item";
			this.DivideByZero_item.Size = new System.Drawing.Size(151, 20);
			this.DivideByZero_item.Text = "Error_message_item";
			// 
			// Paint_item
			// 
			this.Paint_item.Image = global::PP7_1.Properties.Resources.edit;
			this.Paint_item.Name = "Paint_item";
			this.Paint_item.Size = new System.Drawing.Size(97, 20);
			this.Paint_item.Text = "Paint_item";
			this.Paint_item.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_item_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 177);
			this.Controls.Add(this.Ststus_strip);
			this.Controls.Add(this.calculate_button);
			this.Controls.Add(this.rezult_label);
			this.Controls.Add(this.dividend_box);
			this.Controls.Add(this.divider_box);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Ststus_strip.ResumeLayout(false);
			this.Ststus_strip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox divider_box;
		private System.Windows.Forms.TextBox dividend_box;
		private System.Windows.Forms.Label rezult_label;
		private System.Windows.Forms.Button calculate_button;
		private System.Windows.Forms.StatusStrip Ststus_strip;
		private System.Windows.Forms.ToolStripStatusLabel DivideByZero_item;
		private System.Windows.Forms.ToolStripStatusLabel Paint_item;
	}
}

