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
	public partial class GreetPage5 : ContentPage
	{
		public GreetPage5 ()
		{
			InitializeComponent ();
            slider5.Value = 0.5;
        }
	}
}