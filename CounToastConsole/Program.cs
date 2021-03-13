using CounToastLibrary;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace CounToastConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ObservableCollection<int> test = new ObservableCollection<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);

            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);

            Console.WriteLine();

            ObservableCollection<int> essai = new ObservableCollection<int>(test);

            Console.WriteLine(essai[0]);
            Console.WriteLine(essai[1]);
            Console.WriteLine(essai[2]);

            Console.WriteLine();
            test[0] = 99;

            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);

            Console.WriteLine();

            Console.WriteLine(essai[0]);
            Console.WriteLine(essai[1]);
            Console.WriteLine(essai[2]);
            

            Food a = new Food{ Name = "test", Price = 1.0, Quantity = 2 };
            Food b = a;

            Console.WriteLine(a.Name);
            Console.WriteLine(b.Name);
            a.Name = "essai";
            Console.WriteLine(a.Name);
            Console.WriteLine(b.Name);
            */

            /*
            Factory factory = new Factory();

            foreach (Food f in factory.Foods)
            {
                Console.WriteLine($"nom:{f.Name}, quantite:{f.Quantity}, prix:{f.Price}");
            }

            Console.WriteLine();

            foreach (Food f in factory.SortedFoods)
            {
                Console.WriteLine($"nom:{f.Name}, quantite:{f.Quantity}, prix:{f.Price}");
            }

            Console.WriteLine();

            foreach (Food f in factory.SortedFoods)
            {
                Console.WriteLine($"nom:{f.Name}, quantite:{f.Quantity}, prix:{f.Price}");
            }

            Console.WriteLine();
            Console.WriteLine("Operator ==");
            Food f1 = new Food { Name = "Patate", Price = 1.0, Quantity = 1, ImageURL = "" };
            Food f2 = new Food { Name = "Patate", Price = 1.0, Quantity = 1, ImageURL = "" };
            Food f3 = new Food { Name = "Patate", Price = 2.0, Quantity = 2, ImageURL = "different" };
            Food f4 = new Food { Name = "Patate" };
            Food f5 = new Food { Name = "different", Price = 1.0, Quantity = 1, ImageURL = "" }; // single different


            if (f1 == f2)
                Console.WriteLine("f1==f2");
            else
                Console.WriteLine("f1!=f2");

            if (f2 == f3)
                Console.WriteLine("f2==f3");
            else
                Console.WriteLine("f2!=f3");

            if (f3 == f4)
                Console.WriteLine("f3==f4");
            else
                Console.WriteLine("f3!=f4");

            if (f4 == f5)
                Console.WriteLine("f4==f5");
            else
                Console.WriteLine("f4!=f5");   
            
            */

            /*
            using(FoodDbContext context = new FoodDbContext())
            {
                context.Add(new Food { Name = "Apple", Price = 3.99, Quantity = 6, ImageURL = "https://www.spicemountain.co.uk/wp-content/uploads/2019/10/apple.jpg" });
                context.SaveChanges();
            }
            */

            /*
            using (FoodDbContext context = new FoodDbContext())
            {
                foreach(var f in context.FoodSet)
                {
                    Console.WriteLine($"{f.Id} {f.Name}, Price: {f.Price}, Quantity: {f.Quantity}");
                }
            }

            Console.WriteLine();

            using (FoodDbContext context = new FoodDbContext())
            {
                foreach (var f in context.FoodSet
                    .Where(food => food.Quantity == 6))
                {
                    Console.WriteLine($"{f.Id} {f.Name}, Price: {f.Price}, Quantity: {f.Quantity}");
                }
            }
            */

        }
    }
}