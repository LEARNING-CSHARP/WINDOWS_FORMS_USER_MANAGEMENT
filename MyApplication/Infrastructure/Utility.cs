//namespace MyApplication.Infrastructure
namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		// **************************************************
		//public static System.Guid UserId { get; set; }

		public static Models.User AuthenticatedUser { get; set; }
		// **************************************************

		// **************************************************
		private static MyApplication.LoginForm loginForm;

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

				return (loginForm);
			}
		}
		// **************************************************

		// **************************************************
		private static MyApplication.RegisterForm registerForm;

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

				return (registerForm);
			}
		}
		// **************************************************
	}
}
