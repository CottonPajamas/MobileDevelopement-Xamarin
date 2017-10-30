using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//--------------------------How to deal with device differences in C#----------------------------//

namespace TestXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage6 : ContentPage
	{
		public GreetPage6 ()
		{
			InitializeComponent ();
            slider6.Value = 0.5;

            //---This will specifily target the desired platform based on the physical device. There are three ways:

            // 1st way - But its an obsolete way
            //if (Device.OS == TargetPlatform.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);   //Please remember the order: left, top, right, bottom.
            //else if (Device.OS == TargetPlatform.Android)
            //    Padding = new Thickness(10, 20, 0, 0);




            // 2nd way - Using the Device class with an 'OnPlatform()' method that takes GENERIC OVERLOADS
            //Note: This method is not ideal, as it will ONLY work if all three platform types are specified. Failure
            //to specify any even if your app doesnt need it will result in an error. Try with one of them commented out.
            //Padding = Device.OnPlatform(              //We put 'Padding' here to specify what we are doing with the 'Thickness' that we specify.
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(10, 20, 0, 0),
            //    WinPhone: new Thickness(30, 20, 0, 0)
            //    );   





            // 3rd way - Using the Device class with an 'OnPlatform()' method but this time it takes ACTIONS
            //Compared to the 2nd way, the devices specified here are optional, so you can only specify the platform that you want.
            //Device.OnPlatform(
            //    iOS: () =>
            //    {
            //        Padding = new Thickness(0, 20, 0, 0);
            //    },
            //    Android: () =>
            //    {
            //        Padding = new Thickness(10, 20, 0, 0);
            //    }
            //    );




            //--All the above 3 works but they are considered obsolete.

            // 4th way - Using 'switch(Device.RuntimePlatform)'. This is considered to be the most updated way to do it. [BEST METHOD]
            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(10, 20, 0, 0);
                    break;
            }
            //Recall: How we do switch statements. This is the most simplest and cleanest way.
        }
    }
}