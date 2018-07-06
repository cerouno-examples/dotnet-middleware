using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Creando producto...");

            //Product product = new Product
            //{
            //    Id = 1,
            //    Name = "Coca cola Lata 235 ml",
            //    Description = "Bebida refrescante muy sabrosa"
            //};

            //using (var db = new ProductsContext())
            //{  
            //    db.Product.Add(product);
            //    db.SaveChanges();
            //}

            using (var db = new ProductsContext())
            {


                foreach (var p in db.Product)
                {
                    Console.WriteLine(p.Id);
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.Description);
                }
            }
            
            Console.WriteLine("Produto creado");
            Console.ReadKey();
        }
    }
}
