using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoginTerceiro.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Protegida : ContentPage
    {
        public Protegida()
        {
            InitializeComponent();

            lbl_boasvindas.Text = App.Current.Properties["usuario_logado"].ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.Properties.Remove("usuario_logado");
                App.Current.MainPage = new Login();

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}