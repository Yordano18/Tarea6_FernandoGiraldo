using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana6CRUD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Delete : ContentPage
    {
        const string uri = "http://10.28.39.70:8080/moviles/post.php";
        public Delete()
        {
            InitializeComponent();
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            WebClient cliente = new WebClient();

            string parametros = "";

            parametros += "?codigo=" + txtCodigo.Text;

            var urlCompleta = new Uri(uri + parametros);

            cliente.UploadString(urlCompleta, "DELETE", "");

            DisplayAlert("Alerta", "Registro eliminado satisfactoriamente.", "Ok");

        }
    }
}