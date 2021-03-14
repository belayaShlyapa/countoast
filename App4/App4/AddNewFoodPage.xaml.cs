using CounToastLibrary;
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
    public partial class AddNewFoodPage : ContentPage
    {
        private ApplicationViewModel ApplicationVM
        {
            get
            {
                return (Application.Current as App).ApplicationVM;
            }
        }
        public AddNewFoodPage()
        {
            InitializeComponent();
        }

        private void Add_To_Cart_Button_Clicked(object sender, EventArgs e)
        {
            using (var context = new FoodDbContext(ApplicationVM.databaseFileName))
            {
                Food foodToAdd = new Food
                {
                    Name = name.Text,
                    Price = Convert.ToDouble(price.Text),
                    Quantity = Convert.ToInt32(quantity.Text),
                    ImageURL = "https://media.istockphoto.com/vectors/tableware-line-icon-vector-id1040473414?k=6&m=1040473414&s=612x612&w=0&h=aZcXfva389LegX86VPFVEPVFArMCOkD5hvL-rE-mloQ="
                };

                context.Database.EnsureCreated();
                context.FoodSet.AddAsync(foodToAdd);
                context.SaveChangesAsync();
            }

            // TODO : Bad way to reload page
            Navigation.PopAsync();
            Navigation.PopAsync();
            Navigation.PushAsync(new CountMyCartPage());
        }
    }
}