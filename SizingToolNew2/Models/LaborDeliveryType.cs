using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
namespace SizingToolNew2.Models
{
    public class LaborDeliveryType
    {

        [Key]
        public int LaborDeliveryTypeId { get; set; }

        public string DeliveryTypeName { get; set; }
        public string DeliveryUseDescription { get; set; }

        [AllowHtml]
        public string MemoDeliveryNote1 { get; set; }

        [Display(Name = "First Name")]
        public string DeliveryOwnerFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string DeliveryOwnerLastName { get; set; }
        [Display(Name = "Full Name")]
        public string DeliveryOwnerFullName { get; set; }
        [Display(Name = "Owner Email")]
        public string DeliveryOwnerEmail { get; set; }

        public string CreateBy { get; set; }

        public virtual ICollection<LaborDelivery> LaborDeliveries { get; set; }
       
    }
}