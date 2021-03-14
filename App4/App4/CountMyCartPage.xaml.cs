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
    public partial class CountMyCartPage : ContentPage
    {
        public ApplicationViewModel ApplicationVM
        {
            get
            {
                return (Application.Current as App).ApplicationVM;
            }
        }
        public CountMyCartPage()
        {
            InitializeComponent();
            BindingContext = ApplicationVM;
        }

        private async void CollectionView_ItemSelected(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new FoodDetailPage());
            ApplicationVM.SelectedFood = null;
        }

        private async void Add_New_Item_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddNewFoodPage());
        }
    }
}