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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }


        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string carrera = txtCarrera.Text;
            double identificacion = Convert.ToDouble(txtIdentificacion.Text);
            double nseguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
            double nexamen1 = Convert.ToDouble(txtNexamen1.Text);
            double nseguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
            double nexamen2 = Convert.ToDouble(txtNexamen2.Text);
            double a = 0.3;
            double b = 0.2;
            double nsegA1;
            double nexamB1;
            double nsegA2;
            double nexamB2;
            double parcial1;
            double parcial2;
            double nfinal;

            nsegA1 = nseguimiento1 * a;
            nexamB1 = nexamen1 * b;
            nsegA2 = nseguimiento2 * a;
            nexamB2 = nexamen2 * b;
            parcial1 = nsegA1 + nexamB1;
            parcial2 = nsegA2 + nexamB2;
            nfinal = parcial1 + parcial2;

            if (nfinal >= 7)
            {
                DisplayAlert("Registro de Notas", "Tu nombre es : " + nombre + " " + apellido + "\nCarrera: " + carrera + "\nIdentificacion: " + identificacion + "\nAprobado Con " + nfinal, "Cerrar");
            }
            else if (nfinal >= 5 && nfinal <= 6.9)
            {
                DisplayAlert("Registro de Notas", "Tu nombre es : " + nombre + " " + apellido + "\nCarrera: " + carrera + "\nIdentificacion: " + identificacion + "\nAprobado Con " + nfinal, "Cerrar");
            }
            else if (nfinal < 5)
            {
                DisplayAlert("Registro de Notas", "Tu nombre es : " + nombre + " " + apellido + "\nCarrera: " + carrera + "\nIdentificacion: " + identificacion + "\nAprobado Con " + nfinal, "Cerrar");
            }
            else if (nfinal > 10)
            {
                DisplayAlert("Error en el ingreso", "Los Valores ingresados son incorrectos", "Cerrar");
            }

        }

        private void txtSeguimiento1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nseguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);

            if (nseguimiento1 > 10)
            {
                DisplayAlert("Error en el ingreso", "El valor no puede ser mayor a 10 ", "Cerrar");
            }
            else
            {

            }
        }

        private void txtNexamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nexamen1 = Convert.ToDouble(txtNexamen1.Text);

            if (nexamen1 > 10)
            {
                DisplayAlert("Error en el ingreso", "El valor no puede ser mayor a 10 ", "Cerrar");
            }
            else
            {

            }

        }

        private void txtSeguimiento2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nseguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
            if (nseguimiento2 > 10)
            {
                DisplayAlert("Error en el ingreso", "El valor no puede ser mayor a 10 ", "Cerrar");
            }
            else
            {

            }


        }

        private void txtNexamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nexamen2 = Convert.ToDouble(txtNexamen2.Text);
            if (nexamen2 > 10)
            {

                DisplayAlert("Error en el ingreso", "El valor no puede ser mayor a 10 ", "Cerrar");

            }
            else
            {

            }

        }

        private void btnParciaL1_Clicked(object sender, EventArgs e)
        {

            double nseguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
            double nexamen1 = Convert.ToDouble(txtNexamen1.Text);
            double a = 0.3;
            double b = 0.2;
            double nsegA1;
            double nexamB1;
            double parcial1;
            nsegA1 = nseguimiento1 * a;
            nexamB1 = nexamen1 * b;

            parcial1 = nsegA1 + nexamB1;

            notaP1.Text = parcial1.ToString();

        }

        private void btnParciaL2_Clicked(object sender, EventArgs e)
        {
            double nseguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
            double nexamen2 = Convert.ToDouble(txtNexamen2.Text);
            double a = 0.3;
            double b = 0.2;
            double nsegA2;
            double nexamB2;
            double parcial2;

            nsegA2 = nseguimiento2 * a;
            nexamB2 = nexamen2 * b;
            parcial2 = nsegA2 + nexamB2;

            notaP2.Text = parcial2.ToString();


        }
    }
}
    
