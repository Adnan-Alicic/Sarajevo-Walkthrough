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
    public partial class Bezistan : ContentPage
    {
        public Bezistan()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var location = new Location(43.85907452325165, 18.428023420048675);
            var options = new MapLaunchOptions { Name = "Bezistan" };

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