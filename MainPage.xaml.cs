using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace CanguroR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void IrASigiente(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DatosMandado());
            
        }

        private async void irHistorial(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new HistorialP());
        }
    }
}
