namespace Engine.Exceptions
{

	using System;

	public class LoginFailedException : Exception
	{
		public LoginFailedException(string msg) : base(msg)
		{

		}
	}
}
