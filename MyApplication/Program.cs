using System.Linq;

namespace MyApplication
{
	static class Program
	{
		[System.STAThread]
		static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			Models.DatabaseContext oDatabaseContext = null;

			try
			{
				oDatabaseContext =
					new Models.DatabaseContext();

				int intAdminCount =
					oDatabaseContext.Users
					.Where(current => current.IsAdmin)
					.Count();

				if (intAdminCount == 0)
				{
					Models.User oAdminUser = new Models.User();

					oAdminUser.FullName = "Mr. Dariush Tasdighi";
					oAdminUser.IsActive = true;
					oAdminUser.IsAdmin = true;
					oAdminUser.Username = "Dariush";
					oAdminUser.Password = "1234512345";

					oDatabaseContext.Users.Add(oAdminUser);

					oDatabaseContext.SaveChanges();
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				return;
			}
			finally
			{
				if (oDatabaseContext != null)
				{
					oDatabaseContext.Dispose();
					oDatabaseContext = null;
				}
			}
			// **************************************************

			// **************************************************
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
			// **************************************************
		}
	}
}
