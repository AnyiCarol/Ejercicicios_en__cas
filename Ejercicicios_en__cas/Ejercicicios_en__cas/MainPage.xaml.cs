using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicicios_en__cas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void btnsuma_Clicked(object sender, EventArgs e)
        {
           try
            {
                DisplayAlert("Suma", Convert.ToString(Convert.ToInt32(txtnum1.Text) + Convert.ToInt32(txtnum2.Text)), "Ok");

            }
            catch (Exception ex)

            {

                DisplayAlert("Suma", "La suma no se pudo ejecutar", "Ok");

            }

        }

        private void btnresta_Clicked(object sender, EventArgs e)
        {

            try
            {
                DisplayAlert("Resta", Convert.ToString(Convert.ToInt32(txtnum1.Text) - Convert.ToInt32(txtnum2.Text)), "Ok");

            }
            catch (Exception ex)

            {

                DisplayAlert("Resta", "La resta no se pudo ejecutar", "Ok");

            }
        }

        private void btnmulti_Clicked(object sender, EventArgs e)
        {

            try
            {
                DisplayAlert("Multiplicar", Convert.ToString(Convert.ToInt32(txtnum1.Text) * Convert.ToInt32(txtnum2.Text)), "Ok");

            }
            catch (Exception ex)

            {

                DisplayAlert("Multiplicar", "La multiplicacion no se pudo ejecutar", "Ok");

            }

        }

        private void btndividir_Clicked(object sender, EventArgs e)
        {
            try
            {
                DisplayAlert("Dividir", Convert.ToString(Convert.ToDouble(txtnum1.Text) / Convert.ToDouble(txtnum2.Text)), "Ok");

            }
            catch (Exception ex)

            {

                DisplayAlert("Dividir", "La division no se pudo ejecutar", "Ok");

            }
        }

        private async void btnsegunda_Clicked(object sender, EventArgs e)
        {
            var seconpage = new SecondPage1();
            await Navigation.PushAsync(seconpage);


        }
    }
}
