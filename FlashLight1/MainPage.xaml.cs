using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace FlashLight1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void turnOn_Clicked(object sender, EventArgs e)
        {
          await Flashlight.TurnOnAsync();
        }

        private async void turnOff_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
        }
    }
}
