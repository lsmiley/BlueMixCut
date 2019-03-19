using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SizingToolNew2.Models
{
    public class StatusState
    {

        [Key]
        [Display(Name = "Status")]
        public int StatusStateId { get; set; }
        [Display(Name = "Status")]
        public string StatusStateName { get; set; }
        public string StatusStateDesc { get; set; }
        public string StatusStateType { get; set; }
        public string Memo { get; set; }

        public virtual ICollection<Sizing> Sizings { get; set; }


    }
}