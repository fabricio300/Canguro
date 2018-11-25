using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CanguroR
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HistorialP : ContentPage
	{
		public HistorialP ()
		{
			InitializeComponent ();
		}

        private async void irElemeto(object sender, PropertyChangingEventArgs e)
        {
           await Navigation.PushModalAsync(new ServicioHistorial());
        }
    }
}