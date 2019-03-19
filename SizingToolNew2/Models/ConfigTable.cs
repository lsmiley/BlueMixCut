using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SizingToolNew2.Models
{
    public class ConfigTable
    {

        [Key]
        public int ConfigId { get; set; }
        public int ConfigMasterId { get; set; }

        // ******** Start Section - Date and Time Calculations - Created Date
        private DateTime _created = DateTime.MinValue;

        [Display(Name = "Created On")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ConfigCreateDate
        {
            get
            {
                return (_created == DateTime.MinValue) ? DateTime.Now : _created;
            }
            set { _created = value; }
        }
        // ********Date and Time Calculations - Created

        //  public DateTime ConfigCreateDate { get; set; }
        [Display(Name = "Modified-On:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ConfigModifyDate { get; set; }

        // Descriptive Info
        public string ConfigName { get; set; }
        public string ConfigDesc { get; set; }
        public string ConfigType { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string ConfigNotes { get; set; }

        // Input - Output Info
        public double ConfigNummber { get; set; }
        public double ConfigText { get; set; }
        public string ConfigLink { get; set; }

        public double SizeModifier { get; set; }
        public double VendorModifier { get; set; }
        public double HoursModifier { get; set; }

        public double ManagementModifier1stLine { get; set; }
        public double ManagementModifier2ndLine { get; set; }


        public double RiskFactor_Low { get; set; }
        public double RiskFactor_Med { get; set; }
        public double RiskFactor_High { get; set; }

        public double OtherCost_Education { get; set; }
        public double OtherCost_Travel { get; set; }
        public double OtherCost_Equipment { get; set; }



        public double EndpointRangeModifier1 { get; set; }
        public double EndpointRangeModifier2 { get; set; }
        public double EndpointRangeModifier3 { get; set; }
        public double EndpointRangeModifier4 { get; set; }
        public double EndpointRangeModifier5 { get; set; }
        public double EndpointRangeModifier6 { get; set; }

        public double Rpt_BiWeeklyModifier { get; set; }
        public double Rpt_WeeklyModifier { get; set; }
        public double Rpt_DailyModifier { get; set; }
        public double Rpt_CustomModifier { get; set; }

        public double DefaultEndpointFac { get; set; }

        public double Fac_FracHrs { get; set; }
        public double Fac_AdjWkstn { get; set; }
        public double Fac_AdjSvrs { get; set; }
        public double Fac_AdjIPs { get; set; }
        public double Fac_SvrCalc { get; set; }

        // Default AvProduct Component Factors
        public double Frm_ComponentFac1 { get; set; }
        public double Frm_ComponentFac2 { get; set; }
        public double Frm_ComponentFac3 { get; set; }
        public double Frm_ComponentFac4 { get; set; }
        public double Frm_ComponentFac5 { get; set; }

        // Higher AvProduct Complexity Component Factors
        public double Frm_ComponentFac6 { get; set; }
        public double Frm_ComponentFac7 { get; set; }
        public double Frm_ComponentFac8 { get; set; }
        public double Frm_ComponentFac9 { get; set; }
        public double Frm_ComponentFac10 { get; set; }

        // High AvProduct Add-On Companion Product
        public double Frm_ComponentFac11 { get; set; }
        public double Frm_ComponentFac12 { get; set; }




        [ForeignKey("ConfigMasterId")]
        public virtual ConfigMaster ConfigMaster { get; set; }


        public virtual ICollection<Sizing> Sizings { get; set; }


    }
}