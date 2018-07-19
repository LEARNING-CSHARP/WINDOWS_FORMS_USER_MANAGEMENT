namespace MyApplication
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			UpdateWelcomeToolStripStatusLabel();

			// **************************************************
			//if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
			//{
			//	adminToolStripMenuItem.Visible = true;
			//}
			//else
			//{
			//	adminToolStripMenuItem.Visible = false;
			//}
			// **************************************************

			// **************************************************
			adminToolStripMenuItem.Visible =
				Infrastructure.Utility.AuthenticatedUser.IsAdmin;
			// **************************************************
		}

		public void UpdateWelcomeToolStripStatusLabel()
		{
			// **************************************************
			//welcomeToolStripStatusLabel.Text =
			//	"Welcome " + Infrastructure.Utility.AuthenticatedUser.Username + "!";
			// **************************************************

			// **************************************************
			//welcomeToolStripStatusLabel.Text =
			//	string.Format("Welcome {0}!", Infrastructure.Utility.AuthenticatedUser.Username);
			// **************************************************

			// **************************************************
			//welcomeToolStripStatusLabel.Text =
			//	$"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }!";
			// **************************************************

			// **************************************************
			if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName))
			{
				welcomeToolStripStatusLabel.Text =
					$"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }!";
			}
			else
			{
				welcomeToolStripStatusLabel.Text =
					$"Welcome { Infrastructure.Utility.AuthenticatedUser.FullName }!";
			}
			// **************************************************
		}

		private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			//Note: Close() is not correct!
			//Close();

			System.Windows.Forms.DialogResult result =
				System.Windows.Forms.MessageBox.Show
					(text: "آیا به خروج از برنامه اطمینان دارید؟",
					caption: "سوال",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		//private void updateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
		//{
		//	UpdateProfileForm updateProfileForm = new UpdateProfileForm();

		//	updateProfileForm.MdiParent = this;

		//	updateProfileForm.Show();
		//}

		private UpdateProfileForm updateProfileForm;

		private void updateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((updateProfileForm == null) || (updateProfileForm.IsDisposed))
			{
				updateProfileForm = new UpdateProfileForm();

				updateProfileForm.MdiParent = this;
			}

			updateProfileForm.Show();
		}

		//private void changePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
		//{
		//	ChangePasswordForm changePasswordForm = new ChangePasswordForm();

		//	changePasswordForm.MdiParent = this;

		//	changePasswordForm.Show();
		//}

		private ChangePasswordForm changePasswordForm;

		private void changePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((changePasswordForm == null) || (changePasswordForm.IsDisposed))
			{
				changePasswordForm = new ChangePasswordForm();

				changePasswordForm.MdiParent = this;
			}

			changePasswordForm.Show();
		}

		//private void usersListToolStripMenuItem_Click(object sender, System.EventArgs e)
		//{
		//	Admin.UsersListForm usersListForm = new Admin.UsersListForm();

		//	usersListForm.MdiParent = this;

		//	usersListForm.Show();
		//}

		private Admin.UsersListForm usersListForm;

		private void usersListToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((usersListForm == null) || (usersListForm.IsDisposed))
			{
				usersListForm = new Admin.UsersListForm();

				usersListForm.MdiParent = this;
			}

			usersListForm.Show();
		}

		private void MainForm_FormClosed
			(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
