namespace App1
{
	public partial class Page1
	{
		private byte[] _payload;

		public Page1()
		{
			InitializeComponent();

			_payload = new byte[1024 * 1024 * 10];
		}
	}
}