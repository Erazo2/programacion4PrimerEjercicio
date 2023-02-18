using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace programacion4PrimerEjercicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private void btnprocesar_Clicked(object sender, EventArgs e)
        {
            var emple = new Empleados
            {
               id = 1,
               nombre = txtnombre.Text,
               apellido = txtapellido.Text,
               foto = null
            };

            // DisplayAlert("Bienvenido programacion4PrimerEjercicio 4", txtnombre.Text + " " + txtapellido.Text, "okey");


            //esto es para llamar a una segunda pagina y pasar parametros a otro
            var secondpage = new PageResultado();
            secondpage.BindingContext = emple; //paso de parametros a la pantalla
            Navigation.PushAsync(secondpage);
        }
    }
}