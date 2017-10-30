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
	public partial class GreetPage4 : ContentPage
	{
		public GreetPage4 ()
		{
			InitializeComponent ();
            slider4.Value = 0.5;
		}
	}
}