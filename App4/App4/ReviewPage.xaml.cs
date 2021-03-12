using CounToastLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CounToast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewPage : ContentPage
    {
        public ApplicationViewModel ApplicationVM
        {
            get
            {
                return (Application.Current as App).ApplicationVM;
            }
        }
        public ReviewPage()
        {
            InitializeComponent();
            BindingContext = ApplicationVM;
        }
        static string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "myDbFood.db");

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            
            using(var context = new FoodDbContext(filename))
            {
                context.Database.EnsureCreated();
                ApplicationVM.MyFoods.Clear();
                foreach(var f in context.FoodSet)
                {
                    ApplicationVM.MyFoods.Add(f);
                }
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            using (var context = new FoodDbContext(filename))
            {
                context.Database.EnsureCreated();
                var food = new Food { Name = "Apricot", Price = 4.05, Quantity = 1000 };
                context.FoodSet.Add(food);
                ApplicationVM.MyFoods.Add(food);
                await context.SaveChangesAsync();
            }
        }
    }
}