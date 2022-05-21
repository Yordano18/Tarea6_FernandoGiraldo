using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana6CRUD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Delete();//Actualizar(); //aqui pones el nombre de la pantalla que quieres probar
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
