using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models.View
{
	public class AppVM : ViewModel
	{

		public PageVM CurrentPage
		{
			get => _currentPage;
			set => SetAndNotify(ref _currentPage, value, () => CurrentPage);
		}
		
		public AppVM()
		{
			CurrentPage = new SmurfsVM();
		}

		private PageVM _currentPage = null;
	}
}
