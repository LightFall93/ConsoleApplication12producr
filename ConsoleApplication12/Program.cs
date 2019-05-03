using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                var product = new Product(DateTime.Now,"Prouct"+i);
                Console.WriteLine(product.Id + " " + product.Name + "");
            }

            Console.ReadLine();
        }


        public class Product
        {
           public int Id;
            public DateTime ExpirationDate;
           public string Name;

            private static int IdCounter { get; set; }
            public Product(DateTime ExpirationDate,string Name)
            {
                this.Name = Name;
                
                Id = ++ IdCounter;
                this.ExpirationDate = ExpirationDate;
            }
            static Product()
            {
                IdCounter = 1000;//как будто выкачала из базы 1000
            }
        }
    }
}
