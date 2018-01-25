using System.Linq;

namespace MyApplication
{
	static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				int adminCount =
					databaseContext.Users
					.Where(current => current.IsAdmin)
					.Count();

				if (adminCount == 0)
				{
					Models.User adminUser = new Models.User();

					adminUser.IsAdmin = true;
					adminUser.IsActive = true;

					adminUser.Username = "Dariush";
					adminUser.Password = "1234512345";
					adminUser.FullName = "Mr. Dariush Tasdighi";

					databaseContext.Users.Add(adminUser);

					databaseContext.SaveChanges();
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				return;
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
			// **************************************************

			// **************************************************
			#region Runing Startup Form and then Disposing!
			LoginForm startupForm = new LoginForm();
			//RegisterForm startupForm = new RegisterForm();

			System.Windows.Forms.Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}

				startupForm = null;
			}
			#endregion /Runing Startup Form and then Disposing!
			// **************************************************
		}
	}
}
