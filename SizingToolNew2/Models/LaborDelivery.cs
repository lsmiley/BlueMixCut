using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace SizingToolNew2.Models
{
    public class LaborDelivery
    {


        public LaborDelivery()

        {
            #region " Start of default values "

            // Band2Percentage = (Band2Count / BandsTotalCount);
            Band2 = 1;
            Band3 = 0;
            Band4 = 0;
            Band5 = 0;
            Band6 = 0;
            Band7 = 0;
            Band8 = 0;
            Band9 = 0;
            Band10 = 0;

            Band2Count = 1;
            Band3Count = 0;
            Band4Count = 0;
            Band5Count = 0;
            Band6Count = 0;
            Band7Count = 0;
            Band8Count = 0;
            Band9Count = 0;
            Band10Count = 0;

            





            //  Band7Count = 2;
            // BandsTotalCount = (Band2Count + Band3Count + Band4Count + Band5Count + Band6Count + Band7Count + Band8Count + Band9Count + Band10Count);
            // BandsTotalCount = 2;


            #endregion
        }




        [Key]
        public int LaborDeliveryId { get; set; }

        public int RegionNumber { get { return LaborDeliveryId; } set { } }
        public string Regions { get; set; }
        public string DeliveryOption { get; set; }

        public int LaborDeliveryTypeId { get; set; }
       

        [Display(Name = "Currency")]
        public string CurrencyType { get; set; }

        [Display(Name = "FTE/Year")]
        public double DefaultFTE_Year { get; set; }

        [Display(Name = "Work/Week")]
        public double WorkWeek { get; set; }

        [Display(Name = "Cost/Factor")]
        public double DeliveryCtrCostFactor { get; set; }


        // Band designations

        // Band2 Breakdown
        [DataType(DataType.Currency)]
        public double Band2 { get; set; }

        [Display(Name = "Band Name")]
        public string Band2Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "Count - Number People at this Band")]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band2Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands
        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band2Percentage { get { return (((Band2Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }


        // Band3 Breakdown

        [DataType(DataType.Currency)]
        public double Band3 { get; set; }

        [Display(Name = "Band Name")]
        public string Band3Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "Count - Number People at this Band")]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band3Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands
        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band3Percentage { get { return (((Band3Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }



        // Band4 Breakdown
        [DataType(DataType.Currency)]
        public double Band4 { get; set; }

        [Display(Name = "Band Name")]
        public string Band4Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "Count - Number People at this Band")]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band4Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands

        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band4Percentage { get { return (((Band4Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }


        // Band5 Breakdown
        [DataType(DataType.Currency)]
        public double Band5 { get; set; }

        [Display(Name = "Band Name")]
        public string Band5Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "Count - Number People at this Band")]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band5Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands
        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band5Percentage { get { return (((Band5Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }

        // Band6 Breakdown

        [DataType(DataType.Currency)]
        public double Band6 { get; set; }

        [Display(Name = "Band Name")]
        public string Band6Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "Count - Number People at this Band"),]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band6Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands
        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band6Percentage { get { return (((Band6Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }



        // Band7 Breakdown

        [DataType(DataType.Currency)]
        public double Band7 { get; set; }

        [Display(Name = "Band Name")]
        public string Band7Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "Count - Number People at this Band")]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band7Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands
        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band7Percentage { get { return (((Band7Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }



        // Band8 Breakdown

        [DataType(DataType.Currency)]
        public double Band8 { get; set; }


        [Display(Name = "Band Name")]
        public string Band8Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "Count - Number People at this Band")]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band8Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands
        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band8Percentage { get { return (((Band8Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }




        // Band9 Breakdown

        [DataType(DataType.Currency)]
        public double Band9 { get; set; }

        [Display(Name = "Band Name")]
        public string Band9Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "Count - Number People at this Band")]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band9Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands
        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band9Percentage { get { return (((Band9Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }


        // Band10 Breakdown

        [DataType(DataType.Currency)]
        public double Band10 { get; set; }

        [Display(Name = "Band Name")]
        public string Band10Name { get; set; }

        // Is Count of Number of Employees at this Band
        [Display(Name = "# People Band 10")]
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Band10Count { get; set; }

        // Is Percentage based on Band Count and Total-Count across all Bands
        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Band10Percentage { get { return (((Band10Count + BandsTotalCount) / BandsTotalCount) - 1); } set { } }


        // public int PercentBand { get { return (Band10Count / BandsTotalCount) * 100; } set { } }


        // Totals Count for all Bands
        public double BandsTotalCount { get { return (Band2Count + Band3Count + Band4Count + Band5Count + Band6Count + Band7Count + Band8Count + Band9Count + Band10Count); } set { } }


        //// Removed and transfered to Controller in new form
        //public static List<SelectListItem> DeliveryTypeLists
        //{
        //    get
        //    {
        //        return new List<SelectListItem>() {
        //      new SelectListItem() {Text = "Standard GEO  Delivery", Value = "Std-GEO"},
        //      new SelectListItem() {Text = "Shared-Hosted / Cloud Support", Value = "Shared-H"},
        //      new SelectListItem() {Text = "Dedicated-Support", Value = "Dedicated"},
        //      new SelectListItem() {Text = "Project/RFS/NBD", Value = "Project"},
        //      new SelectListItem() {Text = "Custom", Value = "Custom"},
        //        };
        //    }
        //}

        public string DeliveryType { get; set; }
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

        [ForeignKey("LaborDeliveryTypeId")]
        public virtual LaborDeliveryType LaborDeliveryType { get; set; }


        public virtual ICollection<Sizing> Sizings { get; set; }
        
    }
}