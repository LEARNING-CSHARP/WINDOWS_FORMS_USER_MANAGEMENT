using System.Linq;
using System.Data.Entity;

namespace MyApplication.Admin
{
	public partial class UsersListForm : Infrastructure.BaseForm
	{
		public UsersListForm()
		{
			InitializeComponent();
		}

		private Models.DatabaseContext _myDatabaseContext;

		private void UsersListForm_Load(object sender, System.EventArgs e)
		{
			_myDatabaseContext =
				new Models.DatabaseContext();
		}

		private void UsersListForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			if (_myDatabaseContext != null)
			{
				_myDatabaseContext.Dispose();
				_myDatabaseContext = null;
			}
		}

		private void searchButton_Click(object sender, System.EventArgs e)
		{
			System.Collections.Generic.List<Models.User> oUsers = null;

			if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
			{
				oUsers =
					_myDatabaseContext.Users
					.OrderBy(current => current.FullName)
					.ToList()
					;
			}
			else
			{
				oUsers =
					_myDatabaseContext.Users
					.Where(current => current.FullName.Contains(fullNameTextBox.Text))
					.OrderBy(current => current.FullName)
					.ToList()
					;
			}

			usersListBox.ValueMember = "Id";
			usersListBox.DisplayMember = "FullName";
			usersListBox.DataSource = oUsers;

			if (oUsers.Count == 0)
			{
				System.Windows.Forms.MessageBox.Show("No Users!");
			}
		}

		private void usersListBox_DoubleClick(object sender, System.EventArgs e)
		{
			Models.User oSelectedUser =
				usersListBox.SelectedItem as Models.User;

			if (oSelectedUser != null)
			{
				Admin.UpdateUserForm updateUserForm = new UpdateUserForm();

				updateUserForm.UserId = oSelectedUser.Id;

				updateUserForm.ShowDialog();
			}
		}
	}
}
