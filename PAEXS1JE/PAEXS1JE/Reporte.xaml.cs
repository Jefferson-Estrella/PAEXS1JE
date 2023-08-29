using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAEXS1JE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reporte : ContentPage
    {
        public Reporte(string usuario, String nombre, string apellido, double salario,string direccion)
        {
            InitializeComponent();
            lblusuario.Text = "Uusario Conectado" +usuario;  
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtSalario.Text = salario;
            txtdireccion.Text = direccion;
            //comentarios Jefferson 
            //Hola 
            //Hola


        }
    }
}