using System.Linq;

namespace MyApplication.Admin
{
	public partial class UsersListForm : Infrastructure.BaseForm
	{
		public UsersListForm()
		{
			InitializeComponent();
		}

		private void UsersListForm_Load(object sender, System.EventArgs e)
		{
		}

		private void SearchButton_Click(object sender, System.EventArgs e)
		{
			Search();
		}

		private void Search()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				string fullName =
					fullNameTextBox.Text;

				fullName =
					Infrastructure.Utility.FixText(fullName);

				//var users; // Note: Compile Error!
				//var users = null; // Note: Compile Error!

				System.Collections.Generic.List<Models.User> users = null;

				// دستور ذیل خیلی جالب نیست
				//var users = new System.Collections.Generic.List<Models.User>();

				if (fullName == null)
				{
					//var users =
					//	databaseContext.Users
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

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
					//	.Where(current => current.FullName == fullName)
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					//users =
					//	databaseContext.Users
					//	.Where(current => string.Compare(current.FullName, fullName, true) == 0)
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					//users =
					//	databaseContext.Users
					//	.Where(current => current.FullName.ToLower() == fullName.ToLower())
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					//users =
					//	databaseContext.Users
					//	.Where(current => current.FullName.ToLower().StartsWith(fullName.ToLower()))
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					//users =
					//	databaseContext.Users
					//	.Where(current => current.FullName.ToLower().EndsWith(fullName.ToLower()))
					//	.OrderBy(current => current.FullName)
					//	.ToList()
					//	;

					users =
						databaseContext.Users
						.Where(current => current.FullName.ToLower().Contains(fullName.ToLower()))
						.OrderBy(current => current.FullName)
						.ToList()
						;
				}

				// **************************************************
				// Unbinding
				// **************************************************
				//usersListBox.Items.Clear();

				//foreach (var item in users)
				//{
				//	usersListBox.Items.Add(item.Username);
				//}
				// **************************************************

				// **************************************************
				// **************************************************
				// **************************************************
				// Binding
				// **************************************************
				usersListBox.DataSource = null;
				// **************************************************

				// **************************************************
				//usersListBox.ValueMember = "Id";
				//usersListBox.DisplayMember = "Username";

				//usersListBox.ValueMember = "Id1";
				//usersListBox.DisplayMember = "Username1";

				//usersListBox.ValueMember = nameof(Models.User.Id); // "Id"
				//usersListBox.DisplayMember = nameof(Models.User.Username); // "Username"

				//usersListBox.ValueMember = nameof(Models.User.Id1);
				//usersListBox.DisplayMember = nameof(Models.User.Username1);

				//usersListBox.ValueMember = nameof(Models.User.Id);
				//usersListBox.DisplayMember = nameof(Models.User.FullName);

				usersListBox.ValueMember = nameof(Models.User.Id);
				usersListBox.DisplayMember = nameof(Models.User.DisplayName);

				usersListBox.DataSource = users;
				// **************************************************
				// **************************************************
				// **************************************************

				//if (users.Count == 0)
				//{
				//	System.Windows.Forms.MessageBox
				//		.Show("There is not any user for displaying!");
				//}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"Error: { ex.Message }");
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

		private void UsersListBox_DoubleClick(object sender, System.EventArgs e)
		{
			if (usersListBox.SelectedItem == null)
			{
				System.Windows.Forms.MessageBox
					.Show("You did not specify any user for editing!");

				return;
			}

			// **************************************************
			// روش احمقانه
			// **************************************************
			//var selectedUser =
			//	(Models.User)usersListBox.SelectedItem;
			// **************************************************

			// **************************************************
			// روش یه کم منطقی
			// **************************************************
			//Models.User selectedUser = null;

			//if (usersListBox.SelectedItem is Models.User)
			//{
			//	selectedUser =
			//		(Models.User)usersListBox.SelectedItem;
			//}
			// **************************************************

			// **************************************************
			// روش هوشمندانه
			// **************************************************
			//var selectedUser =
			//	usersListBox.SelectedItem as Models.User;

			//if (selectedUser != null)
			//{
			//}
			// **************************************************

			// **************************************************
			// روش مدرن
			// **************************************************
			if (usersListBox.SelectedItem is Models.User selectedUser)
			{
				// **************************************************
				//var updateUserForm =
				//	new UpdateUserForm
				//	{
				//		SelectedUserId = selectedUser.Id,
				//	};
				// **************************************************

				// **************************************************
				var updateUserForm =
					new UpdateUserForm
					{
						SelectedUser = selectedUser,
					};
				// **************************************************

				updateUserForm.ShowDialog();

				Search();
			}
			// **************************************************
		}

		private void DeleteUsersButton_Click(object sender, System.EventArgs e)
		{
			if (usersListBox.SelectedItems.Count == 0)
			{
				System.Windows.Forms.MessageBox
					.Show("You did not select any users for deleting!");

				return;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				foreach (var selectedItem in usersListBox.SelectedItems)
				{
					// **************************************************
					// روش هوشمندانه
					// **************************************************
					//var selectedUser = selectedItem as Models.User;

					//if (selectedUser != null)
					//{
					//}
					// **************************************************

					// **************************************************
					// روش مدرن
					// **************************************************
					if (selectedItem is Models.User selectedUser)
					{
						var foundedUser =
							databaseContext.Users
							.Where(current => current.Id == selectedUser.Id)
							.FirstOrDefault();

						if (foundedUser != null)
						{
							if (foundedUser.IsAdmin == false)
							{
								databaseContext.Users.Remove(foundedUser);

								databaseContext.SaveChanges();
							}
						}
					}
				}

				Search();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"Error: { ex.Message }");
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
