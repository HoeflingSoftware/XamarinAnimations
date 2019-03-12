using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAnimations
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
{
    boxView.TranslateTo(0, boxView.TranslationY - 100, 2000);
}
    }
}
