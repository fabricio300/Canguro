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
	public partial class ServicioHistorial : ContentPage
	{
		public ServicioHistorial ()
		{
			InitializeComponent ();
		}

        private async void Regresar(object sender, EventArgs e)
        {
           await Navigation.PopModalAsync();
        }
    }
}