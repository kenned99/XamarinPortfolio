using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldXamarinForm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ITkompetancer : ContentPage
    {
        public ITkompetancer()
        {
            InitializeComponent();
        }
        async void ToCV(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CV());
        }
        async void ReturnToCV(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}