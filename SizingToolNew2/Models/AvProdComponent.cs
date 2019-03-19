using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SizingToolNew2.Models
{
    public class AvProdComponent
    {
        [Key]
        public int AvProdComponentId { get; set; }
        public int SizingtId { get; set; }
        public int AvProductId { get; set; }
        public string ProductName { get; set; }
        public string ComponentDesc { get; set; }
        public string ComponentType { get; set; }
        public string ComponentTypeFamily { get; set; }
        public string ComponentNote { get; set; }
        public double ComponentComplexityBase { get; set; }
        public double ComponentComplexityFac { get; set; }
        public string CreatedBy { get; set; }
        public string CreteDate { get; set; }
        public string ModifyDate { get; set; }

        [ForeignKey("AvProductId")]
        public virtual AvProduct AvProducts { get; set; }


    }
}