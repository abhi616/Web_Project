using Agrotech_Management_System_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agrotech_Management_System_Data;

namespace Agrotech_Management_System_Web.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakePayment(Payment payment)
        {
            using (DB_Agrotech_Mgt_SystemEntities ae = new DB_Agrotech_Mgt_SystemEntities())
            {
                Payment_Details pd = new Payment_Details();

                pd.Card_No = payment.Card_No;
                pd.Name = payment.Name;
                pd.Address = payment.Address;
                pd.Type = payment.Type;
                pd.Expiry = payment.Expiry;
                pd.CV = payment.CV;
                pd.Total_Amount = payment.Total_Amount;

                ae.Payment_Details.Add(pd);
                ae.SaveChanges();
                
            }
            return RedirectToAction("PaymentSuccess", "Payment");
        }

        public ActionResult payment()
        {
            return View();
        }

        public ActionResult PaymentSuccess()
        {
            return View();
        }

    }
}