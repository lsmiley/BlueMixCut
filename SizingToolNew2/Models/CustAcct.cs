using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SizingToolNew2.Models
{
    public class CustAcct
    {
        [Key]
        public int CustAcctId { get; set; }

        public string CustAcctName { get; set; }
        public string CustAcctCodeName { get; set; }
        public string SectorType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Web { get; set; }
        public string Contact1 { get; set; }
        public string Contact1Phone { get; set; }
        public string Contact1Email { get; set; }
        public string Contact2 { get; set; }
        public string Contact2Phone { get; set; }
        public string Contact2Email { get; set; }
        public int VendorNumProd { get; set; }
        public string VendorNote { get; set; }


        public virtual ICollection<Sizing> Sizing { get; set; }

    }
}