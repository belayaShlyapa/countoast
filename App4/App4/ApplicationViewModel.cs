using CounToastLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace CounToast
{
    public class ApplicationViewModel
    {
        public string databaseFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "myDbFood.db");
        public Factory Factory { get; set; } = new Factory();
        public Food SelectedFood { get; set; } = null;
        public ObservableCollection<Food> Foods
        {
            get
            {
                using (var context = new FoodDbContext(databaseFileName))
                {
                    context.Database.EnsureCreated();
                    return new ObservableCollection<Food>(context.FoodSet);
                }
            }
        }

        public ObservableCollection<Food> SortedFoods
        {
            get
            {
                return Factory.SortFoods(Foods);
            }
        }
    }
}
