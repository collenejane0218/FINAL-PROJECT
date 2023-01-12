namespace FINAL
{
	partial class HOME
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.txtoffering = new System.Windows.Forms.TextBox();
			this.txttithe = new System.Windows.Forms.TextBox();
			this.txtamount = new System.Windows.Forms.TextBox();
			this.txtchange = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblTime = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(36, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(36, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Offering";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(36, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tithe";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(27, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Amount";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(27, 223);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Change";
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(102, 28);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(175, 23);
			this.txtname.TabIndex = 6;
			this.txtname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyUp);
			// 
			// txtoffering
			// 
			this.txtoffering.Location = new System.Drawing.Point(102, 79);
			this.txtoffering.Name = "txtoffering";
			this.txtoffering.Size = new System.Drawing.Size(175, 23);
			this.txtoffering.TabIndex = 8;
			this.txtoffering.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtoffering_KeyUp);
			// 
			// txttithe
			// 
			this.txttithe.Location = new System.Drawing.Point(102, 122);
			this.txttithe.Name = "txttithe";
			this.txttithe.Size = new System.Drawing.Size(175, 23);
			this.txttithe.TabIndex = 9;
			this.txttithe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttithe_KeyUp);
			// 
			// txtamount
			// 
			this.txtamount.Location = new System.Drawing.Point(102, 177);
			this.txtamount.Name = "txtamount";
			this.txtamount.Size = new System.Drawing.Size(128, 23);
			this.txtamount.TabIndex = 10;
			// 
			// txtchange
			// 
			this.txtchange.Location = new System.Drawing.Point(102, 215);
			this.txtchange.Name = "txtchange";
			this.txtchange.Size = new System.Drawing.Size(128, 23);
			this.txtchange.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(84, 267);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button2.Location = new System.Drawing.Point(361, 324);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 14;
			this.button2.Text = "Print";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button3.Location = new System.Drawing.Point(361, 353);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 15;
			this.button3.Text = "Clear";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button4.Location = new System.Drawing.Point(361, 382);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 16;
			this.button4.Text = "Save";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button5.Location = new System.Drawing.Point(361, 411);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 17;
			this.button5.Text = "Exit";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.richTextBox1.Location = new System.Drawing.Point(442, 36);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(346, 402);
			this.richTextBox1.TabIndex = 19;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.BackColor = System.Drawing.Color.Transparent;
			this.lblTime.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblTime.Location = new System.Drawing.Point(12, 424);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(35, 15);
			this.lblTime.TabIndex = 20;
			this.lblTime.Text = "Time";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.BackColor = System.Drawing.Color.Transparent;
			this.lblDate.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblDate.Location = new System.Drawing.Point(12, 389);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(34, 15);
			this.lblDate.TabIndex = 21;
			this.lblDate.Text = "Date";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button6.Location = new System.Drawing.Point(165, 267);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 22;
			this.button6.Text = "Clear";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// HOME
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FINAL.Properties.Resources.white_trianglify_b79c7e1f;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtchange);
			this.Controls.Add(this.txtamount);
			this.Controls.Add(this.txttithe);
			this.Controls.Add(this.txtoffering);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "HOME";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HOME";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox txtname;
		private TextBox txtoffering;
		private TextBox txttithe;
		private TextBox txtamount;
		private TextBox txtchange;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;
		private RichTextBox richTextBox1;
		private System.Windows.Forms.Timer timer1;
		private Label lblTime;
		private Label lblDate;
		private Button button6;
	}
}