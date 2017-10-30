using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        //This is the constructor that will be initialize if the class is created with a string as its parameter.
        public SecondPage(string input)
        {
            InitializeComponent();
            Label1.Text = input;
            //This essentially outputs the message retrieved from the previous page to this current page
        }
    }
}