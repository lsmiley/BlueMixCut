using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SizingToolNew2.Models
{
    public class Team
    {
        //Primary Key
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamDesc { get; set; }
        public string TeamNote { get; set; }

     //   public virtual ICollection<User> Users { get; set; }


    }
}