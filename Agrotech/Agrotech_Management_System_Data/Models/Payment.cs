using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrotech_Management_System_Data.Models
{
   public class Payment
    {
        public int ID { get; set; }
        public int Card_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public DateTime Expiry { get; set; }
        public int CV { get; set; }
        public int Total_Amount { get; set; }
    }
}
