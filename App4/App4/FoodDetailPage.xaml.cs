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
            using (var context = new FoodDbContext(ApplicationVM.databaseFileName))
            {
                string correspondingImageUrl = Factory.FindCorrespondingImageUrl(name.Text, context);
                Food foodToAdd = new Food {
                    Name = name.Text,
                    Price = Convert.ToDouble(price.Text),
                    Quantity = Convert.ToInt32(quantity.Text),
                    ImageURL = correspondingImageUrl,
                    AddedDateTime = DateTime.Now
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