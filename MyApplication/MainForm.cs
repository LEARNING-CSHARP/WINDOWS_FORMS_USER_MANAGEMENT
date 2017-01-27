using System.Linq;
using System.Data.Entity;

namespace MyApplication
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			//Note: Close() is not correct!
			//Close();

			System.Windows.Forms.DialogResult enmResult =
				System.Windows.Forms.MessageBox.Show
					(text: "آیا به خروج از برنامه اطمینان دارید؟",
					caption: "سوال",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (enmResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			UsernameToolStripStatusLabel.Text =
				Infrastructure.Utility.AuthenticatedUser.Username;
		}

		private void updateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			UpdateProfileForm frmUpdateProfile = new UpdateProfileForm();

			frmUpdateProfile.Show();
		}
	}
}
