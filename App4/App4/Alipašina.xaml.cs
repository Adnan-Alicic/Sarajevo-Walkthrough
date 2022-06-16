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
    public partial class Alipasina : ContentPage
    {
        public Alipasina()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            var location = new Location(43.858062349303346, 18.412674322062536);
            var options = new MapLaunchOptions { Name = "Alipasa's Mosque" };

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