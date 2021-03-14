using CounToastLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private ApplicationViewModel ApplicationVM
        {
            get
            {
                return (Application.Current as App).ApplicationVM;
            }
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

        private async void Clear_Database_Button_Clicked(object sender, EventArgs e)
        {
            using (var context = new FoodDbContext(ApplicationVM.databaseFileName))
            {
                await context.Database.EnsureCreatedAsync();
                await context.Database.EnsureDeletedAsync();
            }
        }

        private async void Create_Sample_Database_Button_Clicked(object sender, EventArgs e)
        {
            using (var context = new FoodDbContext(ApplicationVM.databaseFileName))
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();
                foreach(Food f in Factory.SamplesFood)
                {
                    await context.FoodSet.AddAsync(f);
                }
                await context.SaveChangesAsync();
            }
        }
    }
}