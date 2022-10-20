using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2JimmyToapanta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "jotoapanta";
            string contraseña = "12345";

            string tUsuario = txtUsuario.Text;
            string tContraseña = txtContraseña.Text;

            if (usuario == tUsuario & contraseña == tContraseña)
            {

                DisplayAlert("Registro de Notas", "Bienvenido :)", "Cerrar");

                Navigation.PushAsync(new Registro());  //instancia entre ventanas de navegacion
            }
            else

            {

                DisplayAlert("Alerta", "Usuario No existe!!", "Cerrar");

            }




        }



    }
}

