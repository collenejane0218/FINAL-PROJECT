namespace FINAL
{
	partial class LOGIN
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.chkshow = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(139, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Password";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(212, 137);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.UseSystemPasswordChar = true;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(222, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Enter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.Enter += new System.EventHandler(this.button1_Enter);
			this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
			// 
			// chkshow
			// 
			this.chkshow.AutoSize = true;
			this.chkshow.BackColor = System.Drawing.Color.Transparent;
			this.chkshow.Location = new System.Drawing.Point(318, 141);
			this.chkshow.Name = "chkshow";
			this.chkshow.Size = new System.Drawing.Size(55, 19);
			this.chkshow.TabIndex = 3;
			this.chkshow.Text = "Show";
			this.chkshow.UseVisualStyleBackColor = false;
			this.chkshow.CheckedChanged += new System.EventHandler(this.chkshow_CheckedChanged);
			// 
			// LOGIN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FINAL.Properties.Resources.white_trianglify_b79c7e1f;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(503, 309);
			this.Controls.Add(this.chkshow);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LOGIN";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN";
			this.Load += new System.EventHandler(this.LOGIN_Load);
			this.Enter += new System.EventHandler(this.LOGIN_Enter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LOGIN_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Button button1;
		private CheckBox chkshow;
	}
}