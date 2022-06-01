using Agrotech_Management_System_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agrotech_Management_System_Data;

namespace Agrotech_Management_System_Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Register register)
        {
            using(DB_Agrotech_Mgt_SystemEntities check = new DB_Agrotech_Mgt_SystemEntities())
            {
                
                var res = check.Sp_Insert_Register(register.Username, register.Password).FirstOrDefault();
                if (res != null)
                {
                    return RedirectToAction("Product", "Product");
                }
                else
                {
                    return View();
                }

                //if(res.Username == login.Username && res.Password == login.Password)
                //{
                //    return RedirectToAction("Product","Product");
                //}
                //else
                //{
                //    return View();
                //}


            }
        }
   
    }
}