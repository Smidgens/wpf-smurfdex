using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models.View
{
	using Models.Data;
	using DataSources;

	public class SmurfListVM : ViewModel
	{
		public IEnumerable<SmurfDM> Items
		{
			get => _items;
			set => SetAndNotify(ref _items, value, () => Items);
		}
	
		public SmurfListVM()
		{
			var source = new DummySmurfSource();
			Items = source.GetSmurfs();
		}

		private IEnumerable<SmurfDM> _items = null;
	}
}
