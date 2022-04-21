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
			//ResetForm();
		}

		public void ResetForm()
		{
			// **************************************************
			//if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
			//{
			//	adminToolStripMenuItem.Visible = true;
			//}
			//else
			//{
			//	adminToolStripMenuItem.Visible = false;
			//}

			adminToolStripMenuItem.Visible =
				Infrastructure.Utility.AuthenticatedUser.IsAdmin;
			// **************************************************

			// **************************************************
			// **************************************************
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
			//	$"Welcome {Infrastructure.Utility.AuthenticatedUser.Username}!";
			// **************************************************

			// **************************************************
			//welcomeToolStripStatusLabel.Text =
			//	$"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }!";
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// سر کلاس دستور فوق کفایت می‌کند
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			//if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName))
			//{
			//	welcomeToolStripStatusLabel.Text =
			//		$"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }!";
			//}
			//else
			//{
			//	welcomeToolStripStatusLabel.Text =
			//		$"Welcome { Infrastructure.Utility.AuthenticatedUser.FullName }!";
			//}
			// **************************************************

			// **************************************************
			string userDisplayName =
				Infrastructure.Utility.AuthenticatedUser.Username;

			if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName) == false)
			{
				userDisplayName =
					Infrastructure.Utility.AuthenticatedUser.FullName;
			}

			welcomeToolStripStatusLabel.Text = $"Welcome { userDisplayName }!";
			// **************************************************
			// **************************************************
			// **************************************************
		}

		// **************************************************
		// **************************************************
		// **************************************************
		//private void UpdateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
		//{
		//	var updateProfileForm = new UpdateProfileForm
		//	{
		//		MdiParent = this,
		//	};

		//	updateProfileForm.Show();
		//}
		// **************************************************

		// **************************************************
		private UpdateProfileForm _updateProfileForm;

		private void UpdateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (_updateProfileForm == null || _updateProfileForm.IsDisposed)
			{
				_updateProfileForm = new UpdateProfileForm
				{
					MdiParent = this,
				};
			}

			_updateProfileForm.Show();
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		private ChangePasswordForm _changePasswordForm;

		private void ChangePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (_changePasswordForm == null || _changePasswordForm.IsDisposed)
			{
				_changePasswordForm = new ChangePasswordForm
				{
					MdiParent = this,
				};
			}

			_changePasswordForm.Show();
		}
		// **************************************************

		// **************************************************
		private Admin.UsersListForm _usersListForm;

		private void UsersListToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (_usersListForm == null || _usersListForm.IsDisposed)
			{
				_usersListForm = new Admin.UsersListForm
				{
					MdiParent = this,
				};
			}

			_usersListForm.Show();
		}
		// **************************************************

		// **************************************************
		private Admin.NewUsersListForm _newUsersListForm;

		private void NewUsersListToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (_newUsersListForm == null || _newUsersListForm.IsDisposed)
			{
				_newUsersListForm = new Admin.NewUsersListForm
				{
					MdiParent = this,
				};
			}

			_newUsersListForm.Show();
		}
		// **************************************************

		private void LogoutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Hide();
			//Infrastructure.Utility.MainForm.Hide();

			Infrastructure.Utility.LoginForm.Show();

			Infrastructure.Utility.LoginForm.ResetForm();
		}

		private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void MainForm_FormClosing
			(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			System.Windows.Forms.DialogResult result =
				System.Windows.Forms.MessageBox.Show
					(text: "آیا به خروج از برنامه اطمینان دارید؟",
					caption: "سوال",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (result == System.Windows.Forms.DialogResult.No)
			{
				// بی خیال شو = شتر دیدی ندیدی
				e.Cancel = true;
			}
		}

		private void MainForm_FormClosed
			(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
