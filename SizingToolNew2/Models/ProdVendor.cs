using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SizingToolNew2.Models
{
    public class ProdVendor
    { 
        //Primary Key
        [Key]
        public int ProdVendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorCodeName { get; set; }
        public string VendorCategory { get; set; }
        public string NumVendorProducts { get; set; }
        public string VendorNote { get; set; }
        public string VendorWebURL { get; set; }
        public string Contact1Name { get; set; }
        public string Contact1Phone { get; set; }
        public string Contact1Email { get; set; }
        public string Contact2Name { get; set; }
        public string Contact2Phone { get; set; }
        public string Contact2Email { get; set; }
        public string ContractNum { get; set; }


        public virtual ICollection<AvProduct> AvProducts { get; set; }

    }
}