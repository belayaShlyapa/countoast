using CounToastLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CounToast
{
    public class ApplicationViewModel
    {
        public Factory Factory { get; set; } = new Factory();
        public Food SelectedFood { get; set; } = null;
        public ObservableCollection<Food> MyFoods => myFoods;
        private ObservableCollection<Food> myFoods = new ObservableCollection<Food>();
    }
}
