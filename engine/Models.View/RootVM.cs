
namespace Engine.Models.View
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Interfaces;

	public class RootVM : ViewModel, ILoginSubscriber
	{
		public ViewModel CurrentView
		{
			get => _currentView;
			set => SetAndNotify(ref _currentView, value, () => CurrentView);
		}
		
		public RootVM()
		{
			// CurrentView = new LoginVM(this as ILoginSubscriber);
			CurrentView = new SplashVM();
		}

		public void LoginSuccessful()
		{
			CurrentView = new AppVM();
		}

		private ViewModel _currentView = null;
	}
}
