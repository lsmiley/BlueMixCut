using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SizingToolNew2.Models
{
    public class SecurityService
    {

        public int SecurityServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDesc { get; set; }
        public int AvProductId { get; set; }
        public string ServiceRelatedProduct { get; set; }
        public string ServiceDeliveryMethod { get; set; }
        public string ServiceFrequency { get; set; }
        public double ServiceComplexity { get; set; }
        public double ServiceFTE { get; set; }

        public virtual ICollection<Sizing> Sizings { get; set; }
 //       public virtual ICollection<SizingDetail> SizingDetails { get; set; }


    }
}