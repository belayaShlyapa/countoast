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
    public partial class FoodDetailPage : ContentPage
    {
        public ApplicationViewModel ApplicationVM
        {
            get
            {
                return (Application.Current as App).ApplicationVM;
            }
        }
        public FoodDetailPage()
        {
            InitializeComponent();
            BindingContext = ApplicationVM.SelectedFood;
        }

        private void Add_To_Cart_Button_Clicked(object sender, EventArgs e)
        {
            Food foodToAdd = new Food {
                Name = name.Text,
                Price = Convert.ToDouble(price.Text),
                Quantity = Convert.ToInt32(quantity.Text),
                ImageURL = "https://media.istockphoto.com/vectors/hand-drawn-validation-icon-scanned-and-vectorized-brush-drawing-vector-id478369072?b=1&k=6&m=478369072&s=612x612&w=0&h=jAK7PMAvrIpS6eyKv8F6yiWdWYctn8ovM2eNt4Wyoxw="
            };

            using (var context = new FoodDbContext(ApplicationVM.databaseFileName))
            {
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