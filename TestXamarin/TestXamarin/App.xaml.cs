using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Change this accordingly to try the diff greetpages [Original]
            //MainPage = new TestXamarin.GreetPage7();



            /*We have...
            GreetPage1: Using DisplayAlert. (Think DialogBox in WinForm)
            GreetPage2: Using StackLayout to stack multiple attributes (labels, sliders etc) into one form. And assigning an event
                            to the slider such that everytime it changes the value of the label will change to.
            GreetPage3: Applying simple data binding thru xaml rather than using an event to bind the text property of a label
                            to the slider object. (an improvement from GreetPage2)
            GreetPage4: Improving our binding codes for easier maintainability.  (an improvement from GreetPage3)
            GreetPage5: Best practices of applying binding (moving the 'Source') to all the attributes in the form. But if all your attributes
                            in your intended form is not meant to be binded to one common source, then you do not need to use this. 
                            (Stick to how we do it in GreetPage4) 
            GreetPage6: How to deal with device differences using C#.
            GreetPage7: How to deal with device differences using xaml.

             */





            //Using 'NavigationPage' -> allows buttons to have events that will create new pages to navigate to.
            //MainPage = new NavigationPage(new PlusPart2LabelButtonAndEntry());

            //PlusPart2LabelButtonAndEntry: Playing with labels, entry(ies), buttons etc in StackLayout and customizing them. Also basics on changing to diff pages.
            //            But for the navigation button to work, you will need to change the entire line to this...
            //            ->MainPage = new NavigationPage(new PlusPart2LabelButtonAndEntry());
            //              if you had use the normal way, will get exception when navigating.





            //Using 'TabbedPage' -> allows the creation of tabs at the top of the page for quick navigation to other pages.
            MainPage = new TabbedPage
            {
                Children =
                {
                    //Specify the page for the first tab
                    new PlusPart2LabelButtonAndEntry(),
                    //Specify the page for the second tab...and so on
                    new SecondPage("Hello!")

                    //NOTE: Make sure all the pages specify to be tabs have 'Title="..."' inside them under their 'ContentPage' at the top,
                        //as this will be the names of the tab itself that the user will see to navigate. Ignore the 'Next' buttons for now as it will not work.
                }
            };




            //Using 'CarouselPage' -> allows the creation of tabs but now, you navigate them by swiping left and right. SUPER COOOOOOLLLLLL~
            //MainPage = new CarouselPage
            //{
            //    Children =
            //    {
            //        //Specify the page for the first tab
            //        new PlusPart2LabelButtonAndEntry(),
            //        //Specify the page for the second tab...and so on
            //        new SecondPage("Hello!"),
            //        new GreetPage5(),
            //        new GreetPage7()

            //        //NOTE: Ignore the 'Next' buttons for now as it will not work. Designed to only work for 'TabbedPage' for now.
            //    }
            //};


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
