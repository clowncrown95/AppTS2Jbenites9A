using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTS2Jbenites9A
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string user, string pass)
        {
            InitializeComponent();
            lblUser.Text = user;
            lblPass.Text = pass;
        }
        private void btnNotaFin_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(txtN1.Text);
                double valor2 = Convert.ToDouble(txtN2.Text);

                double ResN1 = valor1 * 0.3;
                double ResN2 = valor2 * 0.2;
                double RestP = ResN1 + ResN2;
                txtResultado1.Text = RestP.ToString();

                double valor3 = Convert.ToDouble(txtNS1.Text);
                double valor4 = Convert.ToDouble(txtNS2.Text);

                double ResNS1 = valor3 * 0.3;
                double ResNS2 = valor4 * 0.2;
                double RestSP = ResNS1 + ResNS2;
                txtResultado2.Text = RestSP.ToString();

                double ResPF = RestP + RestSP;
                if (ResPF >= 7)
                {
                    txtEstado.Text = "Aprobado";
                }
                else if (ResPF >= 5 && ResPF <= 6.9)
                {
                    txtEstado.Text = "Complementario";
                }
                else
                {
                    txtEstado.Text = "Reprobado";
                }

                txtResFinal.Text = ResPF.ToString();
            }
            
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "OK");
            }

        }
    }
}
