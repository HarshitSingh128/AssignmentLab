using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLab
{
    //2.	Create class Product. Add fields like id, name and price. Create properties for each field
    //Use object initializer syntax initialize the object.
    //Print product details using ToString()
    //3.	Use above Product class, create Discount method & accept the discount percentage.
    //Give discount to the price & Display actual price & discounted price
    public class Product
    {
        protected double dp;
        public int Id { get; set; }
        public double Price { get; set; }
        public String Name { get; set; }

        public void Discount(double discountPercentage)
        {
            double discountAmount = (discountPercentage / 100) * Price;
            double discountedPrice = Price - discountAmount;

            Console.WriteLine($"Actual Price: {Price}");
            Console.WriteLine($"Discounted Price({discountPercentage}%off): {discountedPrice}");
        }
        public override string ToString()
        {
            return $"PId:{Id},Pname:{Name},Price:{Price}";
        }



    }
}
