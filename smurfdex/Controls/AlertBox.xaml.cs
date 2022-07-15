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

using DP = System.Windows.DependencyProperty;


namespace Smurfdex.Controls
{	

	/// <summary>
	/// Interaction logic for AlertBox.xaml
	/// </summary>
	public partial class AlertBox : UserControl
	{

		public static readonly DP TextProperty = PropHelper.Register<string, AlertBox>("Text");

		public string Text
		{
			get => (string)GetValue(TextProperty);
			set => SetValue(TextProperty, value);
		}

		public AlertBox()
		{
			InitializeComponent();
			DataContext = this;
		}
	}
}
