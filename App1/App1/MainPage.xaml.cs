using System;

namespace App1
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();

			Appearing += (sender, args) => GetMemoryUsage();
		}

		private void Button_OnClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Page1());
		}

		private void Collect_OnClicked(object sender, EventArgs e)
		{
			GetMemoryUsage();
		}

		private void GetMemoryUsage()
		{
			GC.GetTotalMemory(true);
			GC.GetTotalMemory(true);
			GC.GetTotalMemory(true);

			memoryUsageLabel.Text = "GC memory usage: " + GC.GetTotalMemory(true) / (1024 * 1024) + "MB";
		}
	}
}