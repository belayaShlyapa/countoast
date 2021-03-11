using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CounToast
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            Application.Current.Resources["secondary_color"] = Color.FromHex("D6D1B1");
            Application.Current.Resources["primary_color"] = Color.FromHex("FE5F55");
        }

        private async void Go_To_Count_My_Cart_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CountMyCartPage());
        }

        private async void Go_To_Review_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewPage());
        }

        private async void Go_To_Settings_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }
}
