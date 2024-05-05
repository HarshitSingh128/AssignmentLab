using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLab
{
    public class ProductInfo
    {
        static void Main(string[] args)
        {
            //property initializer syntax
            Product p1 = new Product();

            p1.Id = 1;//internallt calls set acessesor
            p1.Name = "Sugar";
            p1.Price = 100;

            // Console.WriteLine($"{p1.Code},{p1.Name},{p1.Price}");

            //object intialiser syntax
            Product p2 = new Product { Id = 101, Name = "Keyboard", Price = 1500 };
            // Console.WriteLine($"{p2.Id},{p2.Name},{p2.Price}");
            Console.WriteLine("Product Details:");
            Console.WriteLine(p2.ToString());


            Console.WriteLine("\nApplying Discount:");
            p2.Discount(10);

        }
    }
}
