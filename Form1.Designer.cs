namespace WindowsFormsDZ29081
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
			this.TopLevelMenu = new System.Windows.Forms.TextBox();
			this.SubItem = new System.Windows.Forms.TextBox();
			this.AddPrimary = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TopLevelMenu
			// 
			this.TopLevelMenu.Location = new System.Drawing.Point(66, 243);
			this.TopLevelMenu.Name = "TopLevelMenu";
			this.TopLevelMenu.Size = new System.Drawing.Size(331, 22);
			this.TopLevelMenu.TabIndex = 0;
			// 
			// SubItem
			// 
			this.SubItem.Location = new System.Drawing.Point(66, 307);
			this.SubItem.Name = "SubItem";
			this.SubItem.Size = new System.Drawing.Size(330, 22);
			this.SubItem.TabIndex = 1;
			// 
			// AddPrimary
			// 
			this.AddPrimary.Location = new System.Drawing.Point(427, 241);
			this.AddPrimary.Name = "AddPrimary";
			this.AddPrimary.Size = new System.Drawing.Size(235, 28);
			this.AddPrimary.TabIndex = 2;
			this.AddPrimary.Text = "Добавить пункт меню";
			this.AddPrimary.UseVisualStyleBackColor = true;
			this.AddPrimary.Click += new System.EventHandler(this.AddPrimary_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(427, 305);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(235, 28);
			this.button2.TabIndex = 3;
			this.button2.Text = "Добавить подменю";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.AddPrimary);
			this.Controls.Add(this.SubItem);
			this.Controls.Add(this.TopLevelMenu);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TopLevelMenu;
		private System.Windows.Forms.TextBox SubItem;
		private System.Windows.Forms.Button AddPrimary;
		private System.Windows.Forms.Button button2;
	}
}

