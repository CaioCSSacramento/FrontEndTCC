using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appTCC.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class menuAdm : ContentPage
	{
		public menuAdm ()
		{
			InitializeComponent ();
		}

        private async void btnSair_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PopModalAsync(true);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }


        }

        
    }
}