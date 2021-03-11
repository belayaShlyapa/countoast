using System;

namespace CounToastLibrary
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        private double price;
        public double Price
        {
            get => price;
            set
            {
                price = Math.Round(value, 2); // 2.053333.. become 2.05 || 1.129 become 1.13
            }
        }
        public string ImageURL { get; set; }
        
        public static bool operator ==(Food f1, Food f2)
        {
            return f1.Name.Equals(f2.Name);
        }

        public static bool operator !=(Food f1, Food f2)
        {
            return !(f1.Name.Equals(f2.Name));
        }
    }
}
