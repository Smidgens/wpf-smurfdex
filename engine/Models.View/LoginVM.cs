using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models.View
{
	using Data;
	using Interfaces;

	public class LoginVM : ViewModel
	{
		public UserLoginDM UserData { get; set; }

		public LoginVM(ILoginSubscriber subscriber)
		{
			UserData = new UserLoginDM();
			_subscriber = subscriber;
		}

		public void Accept()
		{
			_subscriber.LoginSuccessful();
		}

		private ILoginSubscriber _subscriber = null;

		
	}
}
