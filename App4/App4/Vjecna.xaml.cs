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
    public partial class Vjecna
        : ContentPage
    {
        public Vjecna()
        { 
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var location = new Location(43.859001723491254, 18.421831320048028);
            var options = new MapLaunchOptions { Name = "Ethernal flame" };

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