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
    public partial class Katedrala : ContentPage
    {
        public Katedrala()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            var location = new Location(43.85958091494313, 18.425320845855413);
            var options = new MapLaunchOptions { Name = "Sacred Heart Cathedral" };

            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception)
            {
                // No map application available to open
            }

        }
    }
}