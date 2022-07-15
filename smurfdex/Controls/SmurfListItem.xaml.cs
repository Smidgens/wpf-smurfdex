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
	using Engine.Models.Data;
	/// <summary>
	/// Interaction logic for SmurfListItem.xaml
	/// </summary>
	public partial class SmurfListItem : UserControl
	{
		public delegate void ClickHandler(string smurfID);
		public event ClickHandler Click = null;
		public SmurfListItem()
		{
			InitializeComponent();
			//var viewModel = new SmurfListItemVM();
			//DataContext = viewModel;
		}

		private void OnClickItem(object sender, MouseButtonEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Click!");
			System.Diagnostics.Debug.WriteLine(DataContext.GetType().Name);
			var smurf = (SmurfDM)DataContext;
			Click?.Invoke(smurf.Name);
		}
	}
}
