using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicicios_en__cas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage1 : ContentPage
    {
        public SecondPage1()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            Personas persona = new Personas
            {
                Nombre = txtnombre.Text,
            Apellidos = txtapellidos.Text,
            Edad = Convert.ToInt32(txtedad.Text),

            
            Correo = txtcorreo.Text

            };
            var resulpage = new ResultPage();
            resulpage.BindingContext = persona;
            await  Navigation.PushAsync(resulpage);
            }
    }
}