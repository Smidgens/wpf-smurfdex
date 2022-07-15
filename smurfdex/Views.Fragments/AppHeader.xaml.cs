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

namespace Smurfdex.Views.Fragments
{
	/// <summary>
	/// Interaction logic for AppHeader.xaml
	/// </summary>
	public partial class AppHeader : UserControl
	{

		public static readonly DependencyProperty HeaderTitleProperty = PropHelper.Register<string, AppHeader>("Header");
		public string HeaderTitle
		{
			get { return (string)GetValue(HeaderTitleProperty); }
			set { SetValue(HeaderTitleProperty, value); }
		}

		public AppHeader()
		{
			//DataContext = this;
			InitializeComponent();
		}
	}
}
