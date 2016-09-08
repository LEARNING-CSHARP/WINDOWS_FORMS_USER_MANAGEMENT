using System.Linq;
using System.Data.Entity;

namespace MyApplication
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			//Note: Close() is not correct!
			//Close();

			System.Windows.Forms.Application.Exit();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			UsernameToolStripStatusLabel.Text =
				Infrastructure.Utility.AuthenticatedUser.Username;
		}
	}
}
