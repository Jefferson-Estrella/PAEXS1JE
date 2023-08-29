using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PAEXS1JE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario =lblusuario.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double salario = Convert.ToDouble(txtSalario.Text);
            string direccion = txtDireccion.Text;   
            Navigation.PushAsync(new Reporte(usuario, nombre, apellido, salario, direccion));   
            
          

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            int edad = fecha.Year - Convert.ToInt32(txtEdad.Text);
            DisplayAlert("Usted nacio en el año de ", " " + edad, "Cerrar");
        }
    }
}
