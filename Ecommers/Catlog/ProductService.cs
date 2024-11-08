using Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
namespace Catalogue
{
    public class ProductService : IProductService
    {
        private List<Product> products;

        public ProductService() 
        {
            this.products = new List<Product>();
        }
        public bool Delete(int id)
        {
           Product product=this.GetById(id);
            products.Remove(product);
            return true;
        }

        public List<Product> GetAll()
        {
            products.Add(new Product { Id = 1, Name = "Gerbera", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, Img = "/Images/Gerbera.jfif" });
            products.Add(new Product { Id = 2, Name = "Rose", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, Img = "/Images/Rose.jfif" });
            products.Add(new Product { Id = 3, Name = "Lily", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, Img = "/Images/Lily.jfif" });
            products.Add(new Product { Id = 4, Name = "Jasmin", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, Img = "/Images/Jasmine.jfif" });
            products.Add(new Product { Id = 5, Name = "Lotus", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, Img = "/Images/Lotus.jfif" });

            return products;
        }

        public Product GetById(int id)
        {
            //foreach (Product product in products)
            //{
            //    if (product.Id == id)
            //    {
            //        return product;
            //    }

            //}
            //return null;
            return new Product { Id = 1, Name = "Gerbera", Description = "Wedding Flower", UnitPrice = 12, Quantity = 5000, Img = "/Images/Gerbera.jfif" };
        }

        public bool Insert(Product product)
        {
            products.Add(product);
            return true;
        }

        public bool Update(Product product)
        {
            Product product1=GetById(product.Id);
            products.Remove(product1); 
            products.Add(product);
            return true;
        }
    }
}
