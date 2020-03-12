using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inscription
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();


            btn1.Clicked += Btn1_Clicked;
            msg1.IsVisible = false;
            
        }

        async  private void Btn1_Clicked(object sender, EventArgs e)
        {
            /*throw new NotImplementedException();*/
            if ( edit1.Text == "laroche@gmail.com" && edit2.Text == "1234")
            {
                await Navigation.PushAsync(new Accueil());
            }
            else
            {
                msg1.Text = "Inscription impossible";
                msg1.IsVisible = true;
            }
        }
    }
}
