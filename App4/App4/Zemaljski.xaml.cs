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
    public partial class Zemaljski : ContentPage
    {
        public Zemaljski()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
       
        {

            var location = new Location(43.85506821621925, 18.40261733788448);
            var options = new MapLaunchOptions { Name = "Zemaljski muzej" };

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