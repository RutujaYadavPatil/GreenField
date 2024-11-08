using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogue;
using CRM;
using OrderProcessing;
using POCO;




namespace eCommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Order Order1 = new Order();
             Order1.OrderId = 22;
             Order1.Status = "Delivered";
             Order1.Amount =1000;
             Order1.Date = new DateTime(2023, 12, 10);

             Order Order2 = new Order();
             Order2.OrderId = 23;
             Order2.Status = "Reject";
             Order2.Amount = 4522;
             Order2.Date = new DateTime(2024, 12, 10);

             IOrderService OrderService = new OrderService();
             OrderService.Insert(Order1);
             OrderService.Insert(Order2);

             List<Order> allOrders = OrderService.GetAll();

             foreach (Order Order in allOrders)
             {
                 Console.WriteLine(Order.OrderId);
                 Console.WriteLine(Order.Date);
                 Console.WriteLine(Order.Amount);
                 Console.WriteLine(Order.Status);
             }

            
             Customer customer = new Customer();
            customer.Id = 22;
            customer.FirstName = "Chetan";
            customer.LastName = "More";
            customer.Email = "chetanmore@gmail.com";
 
            Customer customer1 = new Customer();
            customer1.Id = 23;
            customer1.FirstName = "Raj";
            customer1.LastName = "Awate";
            customer1.Email = "rajawate1307@gmail.com";
 
            ICustomerService customerService = new CustomerService();
            customerService.Insert(customer);
            customerService.Insert(customer1);
            List<Customer> allCustomers = customerService.GetAll();
            foreach(Customer Customer in allCustomers)
            {   
                Console.WriteLine(Customer.Id);
                Console.WriteLine(Customer.Email);
                Console.WriteLine(Customer.LastName);
                Console.WriteLine(Customer.FirstName);
            }
             

            Product  Product1 = new Product();
            Product1.Id = 22;
            Product1.Name = "Mobile";
            Product1.Description = " OnePlus 128GB 8GB RAM";
            Product1.Img = ("C:\\Users\\rutuja.patil\\Documents\\SQL Server Management Studio\\Code Snippets\\SQL");
            Product1.UnitPrice = 450000;
            Product1.Quantity = 10;

            Product Product2 = new Product();
            Product2.Id = 22;
            Product2.Name = "Mobile";
            Product2.Description = " Redmi Note5 128 8GB";
            Product2.Img = ("C:\\Users\\rutuja.patil\\Documents\\SQL Server Management Studio\\Code Snippets\\SQL");
            Product2.UnitPrice = 10000;
            Product2.Quantity = 10;



            IProductService productService = new ProductService();
           // IOrderService OrderService = new OrderService();
           productService.Insert(Product1);
            //productService.Insert(Product2);

            List<Product> products = productService.GetAll();

            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.Quantity);
                Console.WriteLine(product.Img);
            }
            productService.Update(Product2);
            Console.WriteLine("After :");
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.Quantity);
                Console.WriteLine(product.Img);
            }
            Console.ReadLine();
        }
    }
}
