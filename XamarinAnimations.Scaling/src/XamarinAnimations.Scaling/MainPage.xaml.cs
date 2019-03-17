using System;
using Xamarin.Forms;

namespace XamarinAnimations.Scaling
{
    public partial class MainPage : ContentPage
    {
        private double _scale = 0;
        public MainPage()
        {
            InitializeComponent();
            _scale = Icon.Scale;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Icon.ScaleTo(_scale * 1.5, 500);
            await Icon.ScaleTo(_scale, 500);
        }
    }
}
