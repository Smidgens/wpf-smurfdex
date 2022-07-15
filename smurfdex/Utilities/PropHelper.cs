namespace Smurfdex
{
	using System.Windows;

	public static class PropHelper
	{
		public static DependencyProperty Register<PT, OT>(string name, PT defaultValue = default)
		{
			return DependencyProperty.Register(name, typeof(PT), typeof(OT), new PropertyMetadata(defaultValue));
		}
	}
}