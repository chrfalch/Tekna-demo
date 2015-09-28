using System;
using System.Threading.Tasks;

namespace XFTester
{
	public interface IAlertProvider
	{
		Task ShowAlertAsync(string title, string message);
	}
}

