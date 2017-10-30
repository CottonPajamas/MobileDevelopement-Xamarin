using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//This intro you to something like a dialogbox when a button is clicked.

namespace TestXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage1 : ContentPage
    {
        public GreetPage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Must unds each of the three strings and what they each represent in the dialogbox
            //For eg: "Ok" stands for the button in the dialogbox which user has to click to close it.
            DisplayAlert("Title", "Hello World", "Ok");
        }
    }
}