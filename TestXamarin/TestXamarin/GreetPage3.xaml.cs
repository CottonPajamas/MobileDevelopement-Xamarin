using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//----This here takes a step further by implementing data binding to our slider and label relationship

namespace TestXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage3 : ContentPage
	{
		public GreetPage3 ()
		{
			InitializeComponent();
            slider3.Value = 0.5;
        }
	}
}