using Mobile_Shop.Models;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebSockets;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Mobile_Shop.Controllers
{
    public class HomeController : Controller
    {
        public Mobile_ShopEntities MS = new Mobile_ShopEntities();
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Product()
        {
            
            ViewBag.Brand_Id = new SelectList(MS.Brand, "Brand_ID", "Brand_Name");
            return View();
        }

       
        [HttpPost]
        public ActionResult Product([Bind(Include = "ID,Product_Type,,Model_Id,Brand_Id,Rate")]Product product)
        {            
            if (ModelState.IsValid)
            {
                MS.Product.Add(product);
                MS.SaveChanges();

            }
            ViewBag.Brand_Id = new SelectList(MS.Brand, "Brand_ID", "Brand_Name",product.Brand_Id);
            return View();
        }
        [HttpGet]
        public ActionResult Customer()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Customer([Bind(Include = "Customer_ID,Customer_Name,Customer_Address,Email,City,State,Country,Pincode,Mobile,PAN_,Active")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                MS.Customer.Add(customer);
                MS.SaveChanges();

            }
            return View();
        }
        [HttpGet]
        public ActionResult Supplier()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Supplier([Bind(Include = "Supplier_ID,Supplier_Name,Address,,Email,City,State,Country,PinCode,Mobile,PAN_,Active")] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                MS.Supplier.Add(supplier);
                MS.SaveChanges();
                return RedirectToAction("Brand");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Brand()
        {
            
            return View();
           
        }

        [HttpPost]
        public ActionResult Brand(Brand brand)
        {
            if (brand != null)
            {
                MS.Brand.Add(brand);
                MS.SaveChanges();
                return RedirectToAction("Product");
            }
            return View();

        }
  
        public List<Product> LoadProductGroup()
        {
            var data = MS.Product.ToList();
            return data;
        }
        public List<Supplier> LoadSupplier()
        {
            var data = MS.Supplier.ToList();
            return data;                               
        }
            
        [HttpGet]
        public ActionResult Purchase()
        {
                      
            return View(new Purchase()
            {
                products =  LoadProductGroup(),
                suppliers = LoadSupplier(),
            });
        }
        [HttpPost]
        public ActionResult Purchase(Purchase purchase)
        {            

            if (ModelState.IsValid)
            {
                MS.Purchase_Master.Add(purchase.PM);
                MS.Purchase_Detail.Add(purchase.PD);
                MS.SaveChanges();
            }
            
            return View("Index");
        }
        public ActionResult Sales_Master()
        {
            return View();
        }
        public ActionResult Sales_Details()
        {
            return View();
        }
        public List<Customer> LoadCustomer()
        {
            var data = MS.Customer.ToList();
            return data;
        }
       
        public List<Product> LoadProduct()
        {
            var data = MS.Product.ToList();
            return data;
        }
        [HttpGet]
        public ActionResult Sales()
        {
            return View(new Sales()
            {
                customers=LoadCustomer(),
                products=LoadProduct(),
            });
        }
        [HttpPost]
        public ActionResult Sales(Sales sale)
        {

            if (ModelState.IsValid)
            {
                MS.Sales_Master.Add(sale.SM);
                MS.Sales_Details.Add(sale.SD);
                MS.SaveChanges();
            }

            return View();
        }
    }
}