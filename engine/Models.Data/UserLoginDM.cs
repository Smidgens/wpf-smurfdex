

namespace Engine.Models.Data
{
	using System;
	using Exceptions;
	/// <summary>
	/// Stores data for login attempt
	/// </summary>
	public class UserLoginDM : DataModel
	{
		public string Name
		{
			get => _name;
			set => SetAndNotify(ref _name, value, () => _name);
		}
		public string Password
		{
			get => _password;
			set => SetAndNotify(ref _password, value, () => _password);
		}

		
		/// <summary>
		/// Validates login data
		/// </summary>
		public bool Validate()
		{
			throw new NotImplementedException();
		}

		private string _name = "";
		private string _password = "";
	}
}
