using Agrotech_Management_System_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agrotech_Management_System_Data;

namespace Agrotech_Management_System_Web.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult ContactUs()
        {
            return View();
        }

        public string AddContact(ContactUs contact)
        {
            using (DB_Agrotech_Mgt_SystemEntities ae = new DB_Agrotech_Mgt_SystemEntities())
            {
                Contact_Details cd = new Contact_Details();

                cd.Name = contact.Name;
                cd.Mobile_No = contact.Mobile_No;
                cd.Email_ID = contact.Email_ID;
                cd.Message = contact.Message;

                ae.Contact_Details.Add(cd);
                ae.SaveChanges();
            }
            return "Successfull";
        }
    }
}