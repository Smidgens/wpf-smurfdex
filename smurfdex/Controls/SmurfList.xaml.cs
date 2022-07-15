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

namespace Smurfdex.Controls
{
	using Engine.Models.View;

	/// <summary>
	/// Interaction logic for SmurfList.xaml
	/// </summary>
	public partial class SmurfList : UserControl
	{
		public SmurfList()
		{
			InitializeComponent();
			var viewModel = new SmurfListVM();
			DataContext = viewModel;
		}

		public void OnClickSmurf(string smurfID)
		{
			System.Diagnostics.Debug.WriteLine(smurfID);
		}
	}
}
