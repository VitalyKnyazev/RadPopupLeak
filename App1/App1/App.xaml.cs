using Xamarin.Forms;

namespace App1
{
	public partial class App
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}
	}
}