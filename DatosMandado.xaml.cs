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
	public partial class DatosMandado : ContentPage
	{
		public DatosMandado ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
           // entregaInmediata.OnChanged += entregaInmediata_OnChangedClick;
        }

        private void entregaInmediata_OnChangedClick(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                DisplayAlert("elección","entregar inmediatamente", "Ok");
            }
            else
            {
                DisplayAlert("elección", "entregar con tiempo", "Ok");
            }
        }

        private async void IrFechaHora(object sender, EventArgs e)
        {
            var opcion = await DisplayAlert("Tarifar por servicio", "50$", "Aceptar", "Cancelar");
           

            if (opcion)
            {
                //Aceptar
                await Navigation.PopModalAsync();
            }
            else
            {
                //Cancelar
                await Navigation.PopModalAsync();
            }
        }

        


        private void seleccion(object sender, ToggledEventArgs e)
        {
            if (e.Value) {
                FechaHara.IsVisible = false;
                FechaHara.HeightRequest = 0;
                //DisplayAlert("elección", "entregar inmediatamente", "Ok");
            }
            else
            {
                //DisplayAlert("elección", "entregar con tiempo", "Ok");
                FechaHara.IsVisible = true;
                FechaHara.HeightRequest = 190;
            }
        }
    }
}