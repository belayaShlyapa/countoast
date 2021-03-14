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

        private void Delete_Button_Clicked(object sender, EventArgs e)
        {
            // Get item id
            Button button = (Button)sender;
            Grid listViewItem = (Grid)button.Parent;
            Label label = (Label)listViewItem.Children[0];
            int id = Convert.ToInt32(label.Text);

            using (var context = new FoodDbContext(ApplicationVM.databaseFileName))
            {
                context.Database.EnsureCreated();
                context.FoodSet.Remove(ApplicationVM.Foods.Where(f => f.Id == id).First());
                context.SaveChangesAsync();
            }

            // TODO : Bad way to reload page
            Navigation.PopAsync();
            Navigation.PopAsync();
            Navigation.PushAsync(new ReviewPage());
        }
    }
}