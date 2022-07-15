
namespace Engine.Models
{

	using System;
	using System.ComponentModel;
	using System.Linq.Expressions;

	public abstract class ObservableObject : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SetAndNotify<T>(ref T field, T value, Expression<Func<T>> property)
		{
			if (!ReferenceEquals(field, value))
			{
				field = value;
				OnPropertyChanged(property);
			}
		}

		protected virtual void OnPropertyChanged<T>(Expression<Func<T>> changedProperty)
		{
			if (PropertyChanged != null)
			{
				string name = ((MemberExpression)changedProperty.Body).Member.Name;
				PropertyChanged(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}

