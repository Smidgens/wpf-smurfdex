using System;
using System.Net;
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

namespace Smurfdex.Controls
{

	//using Models.Data;

	/// <summary>
	/// Interaction logic for LoginForm.xaml
	/// </summary>
	public partial class LoginFormControl : UserControl
	{
		public delegate void SubmitHandler();

		public event SubmitHandler Submit = null;

		public LoginFormControl()
		{
			InitializeComponent();
		}

		//private string GetPassword() => new NetworkCredential(string.Empty, Password.SecurePassword).Password;

		private void OnSubmit(object sender, RoutedEventArgs e)
		{
			Submit?.Invoke();
			//Submit?.Invoke(new LoginArgs
			//{
			//	Username = Username.Text,
			//	//Password = GetPassword()
			//	Password = Password.Text
			//});
		}
	}
}
