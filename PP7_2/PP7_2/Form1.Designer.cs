namespace PP7_2
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
			this.Start_button = new System.Windows.Forms.Button();
			this.MsgBox_button = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// Start_button
			// 
			this.Start_button.Location = new System.Drawing.Point(12, 12);
			this.Start_button.Name = "Start_button";
			this.Start_button.Size = new System.Drawing.Size(133, 62);
			this.Start_button.TabIndex = 0;
			this.Start_button.Text = "Start thread";
			this.Start_button.UseVisualStyleBackColor = true;
			this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
			// 
			// MsgBox_button
			// 
			this.MsgBox_button.Location = new System.Drawing.Point(151, 12);
			this.MsgBox_button.Name = "MsgBox_button";
			this.MsgBox_button.Size = new System.Drawing.Size(133, 62);
			this.MsgBox_button.TabIndex = 1;
			this.MsgBox_button.Text = "MsgBox";
			this.MsgBox_button.UseVisualStyleBackColor = true;
			this.MsgBox_button.Click += new System.EventHandler(this.MsgBox_button_Click);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 89);
			this.Controls.Add(this.MsgBox_button);
			this.Controls.Add(this.Start_button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Start_button;
		private System.Windows.Forms.Button MsgBox_button;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
	}
}

