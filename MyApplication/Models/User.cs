namespace Models
{
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		// **********
		public bool IsAdmin { get; set; }
		// **********

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 6)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 8)]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 40, MinimumLength = 40)]

		[System.ComponentModel.Browsable(browsable: false)]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]
		public string FullName { get; set; }
		// **********

		// **********

		[System.ComponentModel.Browsable(browsable: false)]
		public string Description { get; set; }
		// **********

		// **********

		//[System.ComponentModel.Browsable(browsable: false)]
		public string DisplayName
		{
			get
			{
				//string result =
				//	$"Username: { Username }";

				string result =
					$"{nameof(Username)}: { Username }";

				if (string.IsNullOrWhiteSpace(FullName) == false)
				{
					result +=
						$" - Full Name: { FullName }";
				}

				if (IsActive)
				{
					result += " - [Enabled]";
				}
				else
				{
					result += " - [Disabled]";
				}

				if (IsAdmin)
				{
					result += " - [Admin]";
				}
				else
				{
					result += " - [User]";
				}

				return result;
			}
		}
		// **********
	}
}
