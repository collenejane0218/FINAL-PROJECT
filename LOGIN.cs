namespace FINAL
{
	public partial class LOGIN : Form
	{
		public LOGIN()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Please enter your password");
			}
			else if (textBox1.Text == "admin")
			{
				HOME x = new HOME();
				x.Show();
			}
			else
			{
				MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void chkshow_CheckedChanged(object sender, EventArgs e)
		{
			if (chkshow.Checked == true)
			{
				textBox1.UseSystemPasswordChar = false;
			}
			else
			{
				textBox1.UseSystemPasswordChar = true;
			}
		}

		private void button1_Enter(object sender, EventArgs e)
		{
			
		}

		private void button1_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void LOGIN_Load(object sender, EventArgs e)
		{
			
		}

		private void LOGIN_Enter(object sender, EventArgs e)
		{

		}

		private void LOGIN_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1.PerformClick();
			}
		}
	}
}