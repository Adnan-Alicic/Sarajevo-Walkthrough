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
    public partial class Gimnazija : ContentPage
    {
        public Gimnazija()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var location = new Location(43.85751219999695, 18.423726307304992);
            var options = new MapLaunchOptions { Name = "First Gymnasium" };

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