using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldXamarinForm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Default,
                BarTextColor = Color.FromHex("#F6E8EA"),
            };
        }
    }
}
