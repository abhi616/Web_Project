using Agrotech_Management_System_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agrotech_Management_System_Data;
using Newtonsoft.Json;

namespace Agrotech_Management_System_Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
       
        public ActionResult Product()
        {
            return View();
        }

        public ActionResult ProductDetails(string value)
        {
            Product p = new Product();
            using (DB_Agrotech_Mgt_SystemEntities ae = new DB_Agrotech_Mgt_SystemEntities())
            {
                var res = ae.Sp_Insert_Product(value).FirstOrDefault();
                p.Name = res.Product_Name;
                p.Category = res.Product_Category;
                p.Price = Convert.ToInt32(res.Price);
            }
                return View(p);
        }

        public ActionResult getProduct(Product product)
        {
            //var json = "0";

            //using (DB_Agrotech_Mgt_SystemEntities ae = new DB_Agrotech_Mgt_SystemEntities())
            //{
            //    Product_Details pd = new Product_Details();
            //    id = pd.Product_ID;
            //    name = pd.Product_Name;
            //    category = pd.Product_Category;
            //    price = Convert.ToInt32(pd.Price);

            //    json = JsonConvert.SerializeObject(ae);
            //};

            using (DB_Agrotech_Mgt_SystemEntities ae = new DB_Agrotech_Mgt_SystemEntities())
            {
                // doctors = CLE.Doctor_Details.Add(X=>X)
                //var result = ae.Sp_Insert_Product().ToList();
                //foreach (var item in result)
                //{
                //    Product l = new Product();
                //    name = item.Product_Name;
                //    category = item.Product_Category;
                   
                //}
            }

            return View();

            //return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}