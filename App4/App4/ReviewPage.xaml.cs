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

        private void Button_Clicked(object sender, EventArgs e)
        {
            // TODO
        }
    }
}