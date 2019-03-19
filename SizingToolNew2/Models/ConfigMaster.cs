using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SizingToolNew2.Models
{
    public class ConfigMaster
    {
        [Key]
        public int ConfigMasterId { get; set; }

        //  public DateTime ConfigMasterCreate Date { get; set; }

        // ******** Start Section - Date and Time Calculations - Created Date
        private DateTime _created = DateTime.MinValue;

        [Display(Name = "Created On")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Created
        {
            get
            {
                return (_created == DateTime.MinValue) ? DateTime.Now : _created;
            }
            set { _created = value; }
        }
        // ********Date and Time Calculations - Created

        [Display(Name = "Modified-On:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ConfigMasterModifyDate { get; set; }

        // Descriptive Info
        public string ConfigMasterName { get; set; }
        public string ConfigMasterDesc { get; set; }
        public string ConfigMasterNotes { get; set; }

        public virtual ICollection<ConfigTable> ConfigTables { get; set; }

    }
}