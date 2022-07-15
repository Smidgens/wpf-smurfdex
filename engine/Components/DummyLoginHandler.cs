//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Smurfdex.Components
//{
//	using Interfaces;
//	using Smurfdex.Models.Data;
//	using Exceptions;
//	internal class DummyLoginHandler : ILoginHandler
//	{

//		/// <summary>
//		/// 
//		/// </summary>
//		/// <param name="args"></param>
//		/// <returns></returns>
//		/// <exception cref="LoginFailedException">Thrown if login fails for any reason.</exception>
//		public Task<LoginResult> Login(LoginArgs args)
//		{
//			//throw new LoginFailedException("You're up to no good. Stop it.");
//			return Task.FromResult(new LoginResult
//			{
//				Username = args.Username,
//				Token = "DummyToken"
//			});

			
//		}
//	}
//}
