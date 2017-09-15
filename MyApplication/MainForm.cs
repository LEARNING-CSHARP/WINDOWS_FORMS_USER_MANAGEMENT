﻿using System.Linq;
using System.Data.Entity;

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
			if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
			{
				adminToolStripMenuItem.Visible = true;
			}
			else
			{
				adminToolStripMenuItem.Visible = false;
			}

			//usernameToolStripStatusLabel.Text =
			//	"Welcome " + Infrastructure.Utility.AuthenticatedUser.Username + "!";

			usernameToolStripStatusLabel.Text =
				string.Format("Welcome {0}!", Infrastructure.Utility.AuthenticatedUser.Username);
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

		private Admin.UsersListForm _usersListForm;

		private void usersListToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((_usersListForm == null) || (_usersListForm.IsDisposed))
			{
				_usersListForm = new Admin.UsersListForm();

				_usersListForm.MdiParent = this;
			}

			_usersListForm.Show();
		}

		private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
