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
	public partial class PlusPart2LabelButtonAndEntry : ContentPage
	{
		public PlusPart2LabelButtonAndEntry ()
		{
			InitializeComponent ();
		}

        //This event simply outputs whatever the user types in the username field into the outputlabel below of the screen.
        private void Button_Clicked(object sender, EventArgs e)
        {
            // ProTip: Build your solution first after stating the name of the Entry box containing the user-entry value (aka EntryContainer)
            // before writing this line below. Cos only after the solution is build will it register the new attribute (Entry box) and its name.
            string text = EntryContainer1.Text;

            OutputLabel.Text = "Hello " + text;
        }

        //This event ensures that the focus is set to the the specified entry field when clicked and that the keyboard will appear
        private void EntryContainer_Focused(object sender, FocusEventArgs e)
        {
            Focus();
            base.OnAppearing();
        }

        //This is the event that will change the screen to a diff page. Dont forget the 'asyn' after specifying the access modifier ('private')
            //Also you press the back button for Android to navigate backwards. But either way, for both platforms the typical backarrow at the
            //top will be available to navigate backwards.
        private async void NextPageBtn1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GreetPage5());
        }

        private async void NextPageBtn2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage(EntryContainer1.Text));
        }
    }
}