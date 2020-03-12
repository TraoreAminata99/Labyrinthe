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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btn.Clicked += Btn_Clicked;
            message.IsVisible = false;


        }


        async private void Btn_Clicked(object sender, EventArgs e)
        {

            /*throw new NotImplementedException();*/

            if (edit1.Text == "Laroche" && edit2.Text == "Elie" && edit3.Text == "laroche@gmail.com" && edit4.Text == "1234" && edit5.Text == "1234")
            {
                await Navigation.PushAsync(new Login());
            }
            else
            {
                message.Text = "Inscription impossible";
                message.IsVisible = true;
            }

        }
    }


}
