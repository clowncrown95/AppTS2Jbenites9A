using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTS2Jbenites9A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                string user = txtUser.Text;
                string pass = txtPass.Text;
                await Navigation.PushAsync(new MainPage(user,pass));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Advertencia", ex.Message,"ok");
            }
        }
    }
}