using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SizingToolNew2.Models
{
    public class SizingType
    {

        [Key]
        public int SizingTypeId { get; set; }
        public int SizingId { get; set; }
        public string SizingTypeName { get; set; }
        public string SizingTypeDescription { get; set; }
        public string SizingTypeNote { get; set; }
        public string SizingPrimaryProduct { get; set; }
        public string SizingSecondProduct { get; set; }
        public string SizingThirdProduct { get; set; }
        public string SizingForthProduct { get; set; }
        public string SizingPrimaryService { get; set; }
        public string SizingSecondService { get; set; }
        public string SizingThirdService { get; set; }
        public string SizingForthService { get; set; }

        //     public virtual ICollection<Sizing> Sizings { get; set; }

        public virtual ICollection<AvProduct> AvProducts { get; set; }
        public virtual ICollection<Sizing> Sizings { get; set; }


    }
}