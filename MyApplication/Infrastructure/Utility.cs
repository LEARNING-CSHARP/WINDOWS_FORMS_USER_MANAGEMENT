//namespace MyApplication.Infrastructure
namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		// **************************************************
		// **************************************************
		// **************************************************
		//public static string FullName { get; set; }
		//public static System.Guid? UserId { get; set; }

		public static Models.User AuthenticatedUser { get; set; }
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.MainForm mainForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.MainForm MainForm
		{
			get
			{
				if (mainForm == null)
				{
					mainForm =
						new MyApplication.MainForm();
				}

				mainForm.InitializeMainForm();

				return mainForm;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.LoginForm loginForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.LoginForm LoginForm
		{
			get
			{
				if (loginForm == null)
				{
					loginForm =
						new MyApplication.LoginForm();
				}

				loginForm.ResetForm();

				return loginForm;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.RegisterForm registerForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.RegisterForm RegisterForm
		{
			get
			{
				if (registerForm == null)
				{
					registerForm =
						new MyApplication.RegisterForm();
				}

				registerForm.ResetForm();

				return registerForm;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
