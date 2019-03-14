﻿using System.Linq;

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

		private void SearchButton_Click(object sender, System.EventArgs e)
		{
			Search();
		}

		private void UsersListBox_DoubleClick(object sender, System.EventArgs e)
		{
			// روش احمقانه
			//Models.User selectedUser =
			//	(Models.User)usersListBox.SelectedItem;

			Models.User selectedUser =
				usersListBox.SelectedItem as Models.User;

			if (selectedUser != null)
			{
				// **************************************************
				//UpdateUserForm updateUserForm = new UpdateUserForm
				//{
				//	SelectedUserId = selectedUser.Id
				//};
				// **************************************************

				// **************************************************
				UpdateUserForm updateUserForm = new UpdateUserForm
				{
					SelectedUser = selectedUser
				};
				// **************************************************

				updateUserForm.ShowDialog();

				Search();
			}
		}

		private void DeleteUsersButton_Click(object sender, System.EventArgs e)
		{
			if (usersListBox.SelectedItems.Count == 0)
			{
				System.Windows.Forms.MessageBox.Show("You did not select any users for deleting!");

				return;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				foreach (var selectedItem in usersListBox.SelectedItems)
				{
					Models.User selectedUser = selectedItem as Models.User;

					if (selectedUser != null)
					{
						Models.User foundedUser =
							databaseContext.Users
							.Where(current => current.Id == selectedUser.Id)
							.FirstOrDefault();

						if (foundedUser != null)
						{
							if (foundedUser.IsAdmin == false)
							{
								if (string.Compare(foundedUser.Username,
									Infrastructure.Utility.AuthenticatedUser.Username, ignoreCase: true) != 0)
								{
									databaseContext.Users.Remove(foundedUser);

									databaseContext.SaveChanges();
								}
							}
						}
					}
				}

				Search();
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

		private void Search()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

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

				//var users; // Note: Compile Error!
				//var users = null; // Note: Compile Error!

				System.Collections.Generic.List<Models.User> users = null;

				// دستور ذیل خیلی جالب نیست
				//var users = new System.Collections.Generic.List<Models.User>();

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

				// **************************************************
				// Unbinding

				//usersListBox.Items.Clear();

				//foreach (var item in users)
				//{
				//	usersListBox.Items.Add(item.DisplayName);
				//}
				// **************************************************

				// **************************************************
				// Binding
				//usersListBox.DataSource = null;

				usersListBox.ValueMember = "Id";
				usersListBox.DisplayMember = "DisplayName";

				//usersListBox.DisplayMember = "FullName";
				//usersListBox.DisplayMember = "Username";

				usersListBox.DataSource = users;
				// **************************************************

				//if (users.Count == 0)
				//{
				//	System.Windows.Forms.MessageBox.Show("There is not any user with this full name!");
				//}
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

		private void UsersListForm_FormClosed
			(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			//if (databaseContext != null)
			//{
			//	databaseContext.Dispose();
			//	databaseContext = null;
			//}
		}
	}
}
