using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smurfdex
{
	public static class TimeUtility
	{
		public static void SetTimeout(Action action, int millisecondsTimeout)
		{
			Task.Factory.StartNew(() =>
			{
				System.Threading.Thread.Sleep(millisecondsTimeout);
				action();
			});
		}
	}
}
