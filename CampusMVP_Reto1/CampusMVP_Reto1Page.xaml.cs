using Xamarin.Forms;

namespace CampusMVP_Reto1
{
	public partial class CampusMVP_Reto1Page : ContentPage
	{
		public CampusMVP_Reto1Page()
		{
			int count = 0;

			InitializeComponent();

			Clicker.Clicked += (sender, e) => 
			{
				Count.Text = string.Format("Botón pulsado {0} veces", ++count);
			};
		}
	}
}
