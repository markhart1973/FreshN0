using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FreshN0
{
    public class App : Application
    {
        public App()
        {
            var quoteViewModel = new QuoteViewModel();

            var firstEntry = new Entry();
            firstEntry.SetBinding(Entry.TextProperty, "QuoteName", BindingMode.TwoWay);
            firstEntry.HorizontalOptions = LayoutOptions.FillAndExpand;

            var button = new Button();
            button.SetBinding(Button.CommandProperty, "ResetQuoteName");
            button.Text = "Reset Quote in Code";

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        firstEntry,
                        new QuoteView(),
                        button
                    }
                },
                BindingContext = quoteViewModel
            };
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
