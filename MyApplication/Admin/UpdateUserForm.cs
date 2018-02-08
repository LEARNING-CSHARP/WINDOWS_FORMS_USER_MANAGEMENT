using System.Linq;

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
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User selectedUser =
					databaseContext.Users
					.Where(current => current.Id == SelectedUser.Id)
					//.Where(current => current.Id == SelectedUserId)
					.FirstOrDefault();

				if (selectedUser == null)
				{
					System.Windows.Forms.MessageBox.Show("There is no such a user!");

					Close();
				}

				isAdminCheckBox.Checked = selectedUser.IsAdmin;
				isActiveCheckBox.Checked = selectedUser.IsActive;

				fullNameTextBox.Text = selectedUser.FullName;
				descriptionTextBox.Text = selectedUser.Description;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

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

		private void saveButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User selectedUser =
					databaseContext.Users
					.Where(current => current.Id == SelectedUser.Id)
					//.Where(current => current.Id == SelectedUserId)
					.FirstOrDefault();

				if (selectedUser == null)
				{
					System.Windows.Forms.MessageBox.Show("There is no such a user!");

					Close();
				}

				selectedUser.IsAdmin = isAdminCheckBox.Checked;
				selectedUser.IsActive = isActiveCheckBox.Checked;

				selectedUser.FullName = fullNameTextBox.Text;
				selectedUser.Description = descriptionTextBox.Text;

				databaseContext.SaveChanges();

				Close();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

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
