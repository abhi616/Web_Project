using Agrotech_Management_System_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agrotech_Management_System_Data;

namespace Agrotech_Management_System_Web.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public string AddRegisters(Register register)
            {
                using (DB_Agrotech_Mgt_SystemEntities agro = new DB_Agrotech_Mgt_SystemEntities())
                {
                    Register_Details RD = new Register_Details();

                    RD.Name = register.Name;
                    RD.Username = register.Username;
                    RD.Password = register.Password;
                    RD.Mobile_No = register.Mobile_No;
                    RD.Email_ID = register.Email_ID;
                    RD.Date_Of_Birth = register.Date_Of_Birth;
                    RD.Confirm_Password = register.Confirm_Password;
                    RD.Address = register.Address;

                    agro.Register_Details.Add(RD);
                    agro.SaveChanges();
            }
                return "Success";
            }
        }
}