//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agrotech_Management_System_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment_Details
    {
        public int ID { get; set; }
        public int Card_No { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public System.DateTime Expiry { get; set; }
        public int CV { get; set; }
        public int Total_Amount { get; set; }
        public string Address { get; set; }
    }
}