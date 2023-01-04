using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S4_clases.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = "USUARIO CONECTADO: " +usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtprecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                double valor = precio * cantidad; //(%12)
                DisplayAlert("VALOR TOTAL DEL PRODUCTO", valor.ToString(), "Cerar");
            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
            
        }
    }
}