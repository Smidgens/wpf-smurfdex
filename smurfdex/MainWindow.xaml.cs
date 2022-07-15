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
namespace Smurfdex
{
    using System.IO;
    using System.Media;
    using System.Windows.Media.Imaging;
	using System.Windows.Navigation;
	using System.Windows.Shapes;
	using Engine.Models.View;

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public MainWindow()
		{
			InitializeComponent();
			_viewModel = new RootVM();
			DataContext = _viewModel;


			TimeUtility.SetTimeout(() =>
			{
				_viewModel.CurrentView = new LoginVM(_viewModel);
			}, 1000);

			//Task.Factory.StartNew(() =>
			//{
			//	System.Threading.Thread.Sleep(2000);
			//	//var player = new System.Media.SoundPlayer(Properties.Resources.IntroTheme);
			//	//player.Load();
			//	//player.Play();

			//	_viewModel.CurrentView = new AppVM();
			//});


			//System.IO.Stream str = Properties.Resources.IntroTheme;

			//SoundPlayer player = new SoundPlayer(str);
			//player.Load();
			//player.Play();
		}

		private RootVM _viewModel = null;
	}
}
