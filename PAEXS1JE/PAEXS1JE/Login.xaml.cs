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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael";
            string contrasena = "2023";
            if (usuario == txtUsuario.Text && contrasena == txtContrasena.Text)
            {
                Navigation.PushAsync(new MainPage());


            }
            else
            {
                DisplayAlert("Alerta", "Usuario o Contraseña Incorrecta", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }
    }
}