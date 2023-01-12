using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
	public partial class HOME : Form
	{
		public HOME()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			lblDate.Text = DateTime.Now.ToLongDateString();
			timer1.Start();
			
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MeExit();
		}
		private void MeExit()
		{
			DialogResult iExit;

			iExit = MessageBox.Show("Confirm if you want to exit", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (iExit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MeExit();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			int offering, tithe, amount, add, minus;
			offering = Convert.ToInt32(txtoffering.Text);
			tithe = Convert.ToInt32(txttithe.Text);
			amount = Convert.ToInt32(txtamount.Text);

			add = offering + tithe;
			minus = amount - add;

			txtchange.Text = Convert.ToString(minus);

			
			richTextBox1.AppendText(Environment.NewLine);
			richTextBox1.AppendText("-------------------------------------------------------------------------------------" + Environment.NewLine);
			richTextBox1.AppendText("\t\t" + "Name: " + txtname.Text + Environment.NewLine);
			richTextBox1.AppendText("\t\t" + "Offering: " + txtoffering.Text + Environment.NewLine);
			richTextBox1.AppendText("\t\t" + "Tithe: " + txttithe.Text + Environment.NewLine);
			richTextBox1.AppendText("\t\t" + "Amount: " + txtamount.Text + Environment.NewLine);
			richTextBox1.AppendText("\t\t" + "Change: " + txtchange.Text + Environment.NewLine);
			richTextBox1.AppendText("\t\t" + lblDate.Text + Environment.NewLine);
			richTextBox1.AppendText("\t\t" + lblTime.Text + Environment.NewLine);
			richTextBox1.AppendText("-------------------------------------------------------------------------------------" + Environment.NewLine);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToLongTimeString();
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			txtname.Clear();
			txtamount.Clear();
			txtchange.Clear();
			txtoffering.Clear();
			txttithe.Clear();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();

			saveFile.FileName = "Notepad Text";
			saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
					sw.WriteLine(richTextBox1.Text);
			}
		}

		private void txtname_KeyUp(object sender, KeyEventArgs e)
		{

		}

		private void txtoffering_KeyUp(object sender, KeyEventArgs e)
		{
			
		}

		private void txttithe_KeyUp(object sender, KeyEventArgs e)
		{
		
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
