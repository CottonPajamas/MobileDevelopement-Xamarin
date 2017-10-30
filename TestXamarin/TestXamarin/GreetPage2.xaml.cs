using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


//This form introduce the slider which is capable of changing the value inside the label.

namespace TestXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage2 : ContentPage
    {
        public GreetPage2()
        {
            InitializeComponent();

            //What this does is that it auto set the slider value with e appropriate string to 0.5.
            //It will overwrite the text in label2 as seen in the xml file cos when this page is instantiated,
            //immediately this line below is run.
            slider2.Value = 0.5;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //Use this to get the new value of the slider
            //The value we get here is a floating point number from 0-1 so there is gonna be alot of dp.
            //Thats why you use 0:F2 to indicate a fixed point of 2 dp. Otherwise its gonna be crazy.
            label1.Text = String.Format("Value is {0:F2}", e.NewValue);
        }

        private void Slider_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            label2.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}