using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrotech_Management_System_Data.Models
{
    public class Register
    {
        public int Register_ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
        public string Mobile_No { get; set; }
        public string Email_ID { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Address { get; set; }
    }
}
