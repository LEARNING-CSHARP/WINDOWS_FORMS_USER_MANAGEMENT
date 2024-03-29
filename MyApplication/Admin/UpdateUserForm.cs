﻿using System.Linq;

namespace MyApplication.Admin
{
	public partial class UpdateUserForm : Infrastructure.BaseForm
	{
		public UpdateUserForm()
		{
			InitializeComponent();
		}

		public Models.User SelectedUser { get; set; }
		//public System.Guid SelectedUserId { get; set; }

		private void UpdateUserForm_Load(object sender, System.EventArgs e)
		{
			// یعنی خود کاربر ادمین که لاگین کرده‌است
			// نتواند خودش را غیر فعال کرده و یا دسترسی خود را از ادمین خارج نماید
			if (Infrastructure.Utility.AuthenticatedUser.Id == SelectedUser.Id)
			{
				isAdminCheckBox.Enabled = false;
				isActiveCheckBox.Enabled = false;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var foundedUser =
					databaseContext.Users
					.Where(current => current.Id == SelectedUser.Id)
					//.Where(current => current.Id == SelectedUserId)
					.FirstOrDefault();

				if (foundedUser == null)
				{
					System.Windows.Forms.MessageBox
						.Show(text: "There is no such a user anymore!");

					Close();
				}

				isAdminCheckBox.Checked = foundedUser.IsAdmin;
				isActiveCheckBox.Checked = foundedUser.IsActive;

				fullNameTextBox.Text = foundedUser.FullName;
				descriptionTextBox.Text = foundedUser.Description;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(text: $"Error: { ex.Message }");

				Close();
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User foundedUser =
					databaseContext.Users
					.Where(current => current.Id == SelectedUser.Id)
					//.Where(current => current.Id == SelectedUserId)
					.FirstOrDefault();

				if (foundedUser == null)
				{
					System.Windows.Forms.MessageBox
						.Show(text: "There is no such a user anymore!");

					Close();
				}

				foundedUser.IsAdmin = isAdminCheckBox.Checked;
				foundedUser.IsActive = isActiveCheckBox.Checked;

				foundedUser.FullName = fullNameTextBox.Text;
				foundedUser.Description = descriptionTextBox.Text;

				databaseContext.SaveChanges();

				if (Infrastructure.Utility.AuthenticatedUser.Id == SelectedUser.Id)
				{
					Infrastructure.Utility.AuthenticatedUser = foundedUser;

					Infrastructure.Utility.MainForm.ResetForm();
				}

				Close();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(text: $"Error: { ex.Message }");

				Close();
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
	}
}
