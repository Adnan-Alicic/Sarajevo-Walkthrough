using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vjecna());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vijecnica());
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Zemaljski());
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Festina());
        }

        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Narodno());
        }

        private async void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Saborna());
        }

        private async void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Katedrala());
        }

        private async void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Alipasina());
        }


        private async void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gimnazija());
        }

        private async void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Trznica());
        }

        private async void TapGestureRecognizer_Tapped_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kamarija());
        }

        private async void TapGestureRecognizer_Tapped_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Trebevic());
        }

        private async void TapGestureRecognizer_Tapped_12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Historijski());
        }

        private async void TapGestureRecognizer_Tapped_13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bezistan());
        }

        private async void TapGestureRecognizer_Tapped_14(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Galerija());
        }

        private async void TapGestureRecognizer_Tapped_15(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vilsonovo());
        }
    }
}