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
    public partial class Vilsonovo : ContentPage
    {
        public Vilsonovo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var location = new Location(43.85314284789809, 18.392855331139646);
            var options = new MapLaunchOptions { Name = "Wilson's promenade" };

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