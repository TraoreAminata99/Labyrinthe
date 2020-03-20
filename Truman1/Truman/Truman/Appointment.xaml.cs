using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Truman
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Appointment : ContentPage
    {
        public Appointment()
        {
            InitializeComponent();
            btn2.Clicked += Btn2_Clicked;
        }

       async private void Btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Confirm());

        }
    }
}