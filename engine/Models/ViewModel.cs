using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
	public abstract class ViewModel : ObservableObject
	{
		public string TypeName => GetType().Name;
	}
}
