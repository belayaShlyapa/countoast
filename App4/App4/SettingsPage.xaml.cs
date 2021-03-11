using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CounToast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private static int backgroundColor = 0;

        private static Dictionary<int, Color> myColors = new Dictionary<int, Color>()
        {
            [0] = Color.FromHex("D6D1B1"),
            [1] = Color.FromHex("F0B67F"),

        };

        private void Change_Color_Button_Clicked(object sender, EventArgs e)
        {
            backgroundColor++;
            backgroundColor %= myColors.Count;
            Application.Current.Resources["secondary_color"] = myColors[backgroundColor];
        }
    }
}