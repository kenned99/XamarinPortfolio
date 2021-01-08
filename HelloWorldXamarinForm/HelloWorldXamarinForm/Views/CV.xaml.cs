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
    public partial class CV : ContentPage
    {
        public CV()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_ITkompetancer(object sender, EventArgs e)
        {
            var ITkompetancer = new ITkompetancer();
            await Navigation.PushModalAsync(ITkompetancer);
        }

        private void TapGestureRecognizer_projekter(object sender, EventArgs e)
        {

        }
        private async void TapGestureRecognizer_uddannelse(object sender, EventArgs e)
        {
            var uddannelse = new uddannelse();
            await Navigation.PushModalAsync(uddannelse);
        }
    }
}