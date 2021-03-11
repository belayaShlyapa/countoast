using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CounToast
{
    public partial class App : Application
    {
        public ApplicationViewModel ApplicationVM { get; set; } = new ApplicationViewModel();
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MenuPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
