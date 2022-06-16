using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Timers;

namespace App4
{
    public partial class GlavnaDetail : ContentPage
    {
        public class SAWCarousel
        {
            public ImageSource Slike { get; set; }
        }

        private ObservableCollection<SAWCarousel> slikePocetna;
        public ObservableCollection<SAWCarousel> SlikePocetna
        {
            get { return slikePocetna; }
            set
            {
                slikePocetna = value;
                OnPropertyChanged();
            }
        }
        public GlavnaDetail()
        {
            InitializeComponent();
            BindingContext = this;
            SlikePocetna = new ObservableCollection<SAWCarousel>
            {
                new SAWCarousel{Slike="bascarsija1.jpg"},
                new SAWCarousel{Slike="katedrala1.jpg"},
                new SAWCarousel{Slike="musala1.jpg"},
                new SAWCarousel{Slike="sebilj1.jpg"},
                new SAWCarousel{Slike="pravoslavna_crkva1.jpg"}

            };
        }
        private Timer timer;
        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (CarouselSlike.Position == 4)
                {
                    CarouselSlike.Position = 0;
                    return;
                }
                CarouselSlike.Position += 1;
            });
        }
    }
}
