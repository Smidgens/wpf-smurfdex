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

	using Engine.Models.View;

	/// <summary>
	/// Interaction logic for AppView.xaml
	/// </summary>
	public partial class AppView : UserControl
	{		
		public AppView()
		{
			InitializeComponent();
			var viewModel = new AppVM();
			DataContext = viewModel;

			//Task.Factory.StartNew(() =>
			//{
			//	System.Threading.Thread.Sleep(1);
			//	var player = new System.Media.SoundPlayer(Properties.Resources.IntroTheme);
			//	player.Load();
			//	player.Play();
			//});

			
		}
	}
}