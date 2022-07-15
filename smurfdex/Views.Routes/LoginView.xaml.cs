using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Smurfdex.Views
{
	//using Interfaces;
	using Controls;
	using System.ComponentModel;

	using Engine.Models.View;

	/// <summary>
	/// Interaction logic for LoginView.xaml
	/// </summary>
	public partial class LoginView : UserControl
	{
		public delegate void SubmitHandler();
		public event SubmitHandler Submit = null;

		public LoginView()
		{
			InitializeComponent();
			//var viewModel = new LoginVM();
			//DataContext = viewModel;
			//System.Diagnostics.Debug.WriteLine(DataContext.GetType().Name);
		}

	

		//public static readonly DependencyProperty ShowErrorProperty = PropUtility.Register<bool, LoginView>("ShowError", false);
		//public static readonly DependencyProperty ErrorMessageProperty = PropUtility.Register<string, LoginView>("ErrorMessage");


		//public string ErrorMessage
		//{
		//	get => (string)GetValue(ErrorMessageProperty);
		//	set => SetValue(ErrorMessageProperty, value);

		//}



		//public bool ShowError
		//{
		//	get => (bool)GetValue(ShowErrorProperty);
		//	set => SetValue(ShowErrorProperty, value);
		//}


		//public LoginView(ILoginHandler loginHandler, ILoginSubscriber owner)
		//{

		//	InitializeComponent();
		//	_loginHandler = loginHandler;
		//	DataContext = this;
		//}

		//private ILoginHandler _loginHandler = null;
		//private ILoginSubscriber _owner = null;


		private void OnSubmit()
		{
			var viewModel = (LoginVM)DataContext;
			viewModel.Accept();
			//Console.WriteLine(DataContext == null ? "Meh" : DataContext.GetType().Name);
		}

		//private async void OnSubmit(Models.Data.LoginArgs args)
		//{
		//	//System.Diagnostics.Debug.WriteLine("USER: " + args.Username);

		//	//try
		//	//{
		//	//	var result = await _loginHandler.Login(args);
		//	//	_owner?.LoginCompleted(result);
		//	//}
		//	//catch(Exceptions.LoginFailedException ex)
		//	//{
		//	//	ErrorMessage = ex.Message;
		//	//	ShowError = true;
		//	//	System.Diagnostics.Debug.WriteLine(ex.Message);
		//	//}



		//}
	}
}
