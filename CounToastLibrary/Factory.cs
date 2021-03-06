using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounToastLibrary
{
    public class Factory
    {
        public static ObservableCollection<Food> SortFoods(ObservableCollection<Food> foods)
        {
            var sortedFood = foods
                    .GroupBy(f => f.Name)
                    .Select(g => new Food { Name = g.Key, Price = g.Average(f => f.Price / f.Quantity), Quantity = g.Sum(q => q.Quantity), ImageURL = g.First().ImageURL })
                    .OrderBy(f => f.Name);

            return new ObservableCollection<Food>(sortedFood);
        }

        public Factory()
        {

        }

        public static ObservableCollection<Food> SamplesFood = new ObservableCollection<Food>()
        {
            new Food
            {
                Name = "Banana",
                Price = 1.129,
                Quantity = 1,
                ImageURL = "https://resize.prod.docfr.doc-media.fr/img/var/doctissimo/storage/images/media/images/quels-sont-les-bienfaits-de-la-banane/7851433-1-fre-FR/Quels-sont-les-bienfaits-de-la-banane.jpg",
                AddedDateTime = new DateTime(2021, 2, 25, 15, 1, 2)
            },
            new Food
            {
                Name = "Chocolate",
                Price = 2.44,
                Quantity = 3,
                ImageURL = "https://prmeng.rosselcdn.net/sites/default/files/dpistyles_v2/ena_16_9_extra_big/2020/08/18/node_121674/37606901/public/2020/08/18/B9724320451Z.1_20200818203434_000%2BG9QGGPE5P.1-0.jpg?itok=4oaIZgcw1597775767",
                AddedDateTime = new DateTime(2021, 2, 25, 15, 1, 40)
            },
            new Food
            {
                Name = "Fish",
                Price = 6.98,
                Quantity = 2,
                ImageURL = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/slideshows/best_and_worst_fish_for_your_health_slideshow/1800x1200_best_and_worst_fish_for_your_health_slideshow.jpg",
                AddedDateTime = new DateTime(2021, 2, 25, 15, 2, 1)
            },
            new Food
            {
                Name = "Orange",
                Price = 3.99,
                Quantity = 8,
                ImageURL = "https://www.fruitsdelaplume.fr/wp-content/uploads/2020/03/orange-king-of-fruits.jpg",
                AddedDateTime = new DateTime(2021, 2, 25, 15, 2, 21)
            },
            new Food
            {
                Name = "Chocolate",
                Price = 4.88,
                Quantity = 4,
                ImageURL = "https://prmeng.rosselcdn.net/sites/default/files/dpistyles_v2/ena_16_9_extra_big/2020/08/18/node_121674/37606901/public/2020/08/18/B9724320451Z.1_20200818203434_000%2BG9QGGPE5P.1-0.jpg?itok=4oaIZgcw1597775767",
                AddedDateTime = new DateTime(2021, 3, 1, 13, 18, 56)
            },
            new Food
            {
                Name = "Chocolate",
                Price = 5,
                Quantity = 5,
                ImageURL = "https://prmeng.rosselcdn.net/sites/default/files/dpistyles_v2/ena_16_9_extra_big/2020/08/18/node_121674/37606901/public/2020/08/18/B9724320451Z.1_20200818203434_000%2BG9QGGPE5P.1-0.jpg?itok=4oaIZgcw1597775767",
                AddedDateTime = new DateTime(2021, 3, 10, 9, 4, 35)
            },
            new Food
            {
                Name = "Flour",
                Price = 1.05,
                Quantity = 1,
                ImageURL = "https://www.bakingbusiness.com/ext/resources/2020/5/WholeWheatFlour_Lead.jpg?t=1588771711&width=1080",
                AddedDateTime = new DateTime(2021, 3, 10, 9, 4, 51)
            },
            new Food
            {
                Name = "Bread",
                Price = 1.20,
                Quantity = 1,
                ImageURL = "https://odelices.ouest-france.fr/images/recettes/baguettes-pain-maison.jpg",
                AddedDateTime = new DateTime(2021, 3, 10, 9, 4, 59)
            },
            new Food
            {
                Name = "Jam",
                Price = 6.5,
                Quantity = 2,
                ImageURL = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/4B7C3510-7041-4B5D-8000-1D10B1BA4678/Derivates/6749ac4e-586d-4055-9df2-5a96832897f6.jpg",
                AddedDateTime = new DateTime(2021, 3, 10, 9, 5, 11)
            },
            new Food
            {
                Name = "Lemon",
                Price = 1,
                Quantity = 3,
                ImageURL = "https://media.healthyfood.com/wp-content/uploads/2017/03/What-to-do-with-lemons.jpg",
                AddedDateTime = new DateTime(2021, 3, 10, 9, 5, 18)
            }
        };

        public static string FindCorrespondingImageUrl(string foodName, FoodDbContext context)
        {
            return context.FoodSet.Where(f => f.Name == foodName).Select(f => f.ImageURL).First();
        }
    }
}
