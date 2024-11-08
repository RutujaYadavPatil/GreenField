﻿using Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POCO;

namespace EcommerceWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        { 
            IProductService SVC  = new ProductService();
            List<Product> products =SVC.GetAll();
           
            return View(products);
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Insert()
        {
            return View();
        }     
        public ActionResult Update() 
        {
            return View();
        }
        public ActionResult Delete() 
        { 
            return View();
        }


    }
}