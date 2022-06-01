using Agrotech_Management_System_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrotech_Management_System_Data.Services
{
    public interface IContactUs
    {
        IEnumerable<ContactUs> GetContacts();
    }
}
