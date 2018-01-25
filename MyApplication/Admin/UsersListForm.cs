using System.Linq;

namespace MyApplication.Admin
{
	public partial class UsersListForm : Infrastructure.BaseForm
	{
		public UsersListForm()
		{
			InitializeComponent();
		}

		//private Models.DatabaseContext databaseContext;

		private void UsersListForm_Load(object sender, System.EventArgs e)
		{
			//databaseContext =
			//	new Models.DatabaseContext();
		}

		private void UsersListForm_FormClosed
			(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			//if (databaseContext != null)
			//{
			//	databaseContext.Dispose();
			//	databaseContext = null;
			//}
		}

		private void searchButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.User> users = null;

				// **************************************************
				fullNameTextBox.Text =
					fullNameTextBox.Text.Trim();

				// تا وقتی که در داخل متن، دو فاصله وجود دارد
				// دو فاصله را به یک فاصله تبدیل کن
				while (fullNameTextBox.Text.Contains("  "))
				{
					fullNameTextBox.Text =
						fullNameTextBox.Text.Replace("  ", " ");
				}
				// **************************************************

				if (fullNameTextBox.Text == string.Empty)
				{
					users =
						databaseContext.Users
						.OrderBy(current => current.FullName)
						.ToList()
						;
				}
				else
				{
					//users =
					//	databaseContext.Users
					//	.Where(current => current.FullName == fullNameTextBox.Text)
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					//users =
					//	databaseContext.Users
					//	.Where(current => string.Compare(current.FullName, fullNameTextBox.Text, true) == 0)
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					//users =
					//	databaseContext.Users
					//	.Where(current => current.FullName.StartsWith(fullNameTextBox.Text))
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					//users =
					//	databaseContext.Users
					//	.Where(current => current.FullName.EndsWith(fullNameTextBox.Text))
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					users =
						databaseContext.Users
						.Where(current => current.FullName.Contains(fullNameTextBox.Text))
						.OrderBy(current => current.FullName)
						.ToList()
						;
				}

				// Binding
				//usersListBox.DataSource = null;

				usersListBox.ValueMember = "Id";
				//usersListBox.DisplayMember = "FullName";
				usersListBox.DisplayMember = "DisplayName";
				usersListBox.DataSource = users;

				if (users.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show("There is not any user with this full name!");
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
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

		private void usersListBox_DoubleClick(object sender, System.EventArgs e)
		{
			Models.User oSelectedUser =
				usersListBox.SelectedItem as Models.User;

			if (oSelectedUser != null)
			{
				UpdateUserForm updateUserForm = new UpdateUserForm();

				updateUserForm.User = oSelectedUser;
				//updateUserForm.UserId = oSelectedUser.Id;

				updateUserForm.ShowDialog();
			}
		}
	}
}
