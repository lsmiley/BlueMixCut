using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SizingToolNew2.Models
{
    public class ProdCategory
    {

        [Display(Name = "Category")]
        public int ProdCategoryId { get; set; }
        public int SizingId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryNote { get; set; }

    //    public virtual ICollection<Sizing> Sizings { get; set; }

        public virtual ICollection<AvProduct> AvProducts { get; set; }

    }
}