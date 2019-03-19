using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


using System.Web.Mvc;




namespace SizingToolNew2.Models
{
    public class AvProduct
    {

            public AvProduct()
            {
                ProductComplexityBase = 525;
                ProductComplexityFac = 0.25;
                PrimaryComplexity = 1;

                //Default Components -Default Values
                ComponentComplexityFac1 = 0;
                ComponentComplexityFac2 = 0;
                ComponentComplexityFac3 = 0;
                ComponentComplexityFac4 = 0;
                ComponentComplexityFac5 = 0;

                //Higher Complexity Components -Default Values
                ComponentComplexityFac6 = 0;
                ComponentComplexityFac7 = 0;
                ComponentComplexityFac8 = 0;
                ComponentComplexityFac9 = 0;
                ComponentComplexityFac10 = 0;

                //Higher Complexity Components -Default Values
                ComponentComplexityFac11 = 0;
                ComponentComplexityFac12 = 0;
                ComponentComplexityFac13 = 0;
                ComponentComplexityFac14 = 0;
                ComponentComplexityFac15 = 0;

                // Test for DropDowns
              //  AvProductsList_01 = 0;
             //   AvProductsList_02 = 0;
             //   AvProductsList_03 = 0;
             //   AvProductsList_04 = 0;


        }



            [Key]
            public int AvProductId { get; set; }


            // internal static object Select(Func<object, SelectListItem> p)
            // {
            //  throw new NotImplementedException();
            // }

            [Display(Name = "Vendor")]
            public int ProdVendorId { get; set; }
            public int ProdCategoryId { get; set; }
        [Display(Name = "Product")]
            public string ProductName { get; set; }
            public string ProductDesc { get; set; }
            public string ProductType { get; set; }
            public string ProductTypeFamily { get; set; }
            public string ProductNote { get; set; }
            public double ProductComplexityBase { get; set; }
            public double ProductComplexityFac { get; set; }
            public int Numcomponent { get; set; }
            public string PrimaryComp { get; set; }
            public string PrimaryCompDesc { get; set; }
            public double PrimaryComplexity { get; set; }
            public double TotalComplexity { get { return ((ProductComplexityBase + PrimaryComplexity) * ProductComplexityFac); } set { } }

            // Av Components Start
            public bool Component1 { get; set; }
            public string Component1Desc { get; set; }
            public double ComponentComplexityFac1 { get; set; }

            public bool Component2 { get; set; }
            public string Component2Desc { get; set; }
            public double ComponentComplexityFac2 { get; set; }

            public bool Component3 { get; set; }
            public string Component3Desc { get; set; }
            public double ComponentComplexityFac3 { get; set; }

            public bool Component4 { get; set; }
            public string Component4Desc { get; set; }
            public double ComponentComplexityFac4 { get; set; }

            public bool Component5 { get; set; }
            public string Component5Desc { get; set; }
            public double ComponentComplexityFac5 { get; set; }

            public bool Component6 { get; set; }
            public string Component6Desc { get; set; }
            public double ComponentComplexityFac6 { get; set; }

            public bool Component7 { get; set; }
            public string Component7Desc { get; set; }
            public double ComponentComplexityFac7 { get; set; }

            public bool Component8 { get; set; }
            public string Component8Desc { get; set; }
            public double ComponentComplexityFac8 { get; set; }

            public bool Component9 { get; set; }
            public string Component9Desc { get; set; }
            public double ComponentComplexityFac9 { get; set; }

            public bool Component10 { get; set; }
            public string Component10Desc { get; set; }
            public double ComponentComplexityFac10 { get; set; }

            public bool Component11 { get; set; }
            public string Component11Desc { get; set; }
            public double ComponentComplexityFac11 { get; set; }

            public bool Component12 { get; set; }
            public string Component12Desc { get; set; }
            public double ComponentComplexityFac12 { get; set; }

            public bool Component13 { get; set; }
            public string Component13Desc { get; set; }
            public double ComponentComplexityFac13 { get; set; }

            public bool Component14 { get; set; }
            public string Component14Desc { get; set; }
            public double ComponentComplexityFac14 { get; set; }

            public bool Component15 { get; set; }
            public string Component15Desc { get; set; }
            public double ComponentComplexityFac15 { get; set; }



            public int NumComponents { get; set; }

        // public int AvProductsList_01 { get; set; }
        // public int AvProductsList_02 { get; set; }
        // public int AvProductsList_03 { get; set; }
        // public int AvProductsList_04 { get; set; }


        [ForeignKey("ProdVendorId")]
            public virtual ProdVendor ProdVendor { get; set; }

            [ForeignKey("ProdCategoryId")]
            public virtual ProdCategory ProdCategory { get; set; }



        public virtual ICollection<Sizing> Sizings { get; set; }
            // public virtual ICollection<Sizing> Sizings { get; set; }

            public virtual ICollection<AvProdComponent> AvProdComponents { get; set; }
            public virtual ICollection<ProdCategory> ProdCategorys { get; set; }

            internal static AvProduct GetProduct(int v)
            {
                throw new NotImplementedException();
            }

            //     internal static AvProducts GetProduct(int v)
            //    {
            //       throw new NotImplementedException();
            //    }
            // public virtual ICollection<SizingDetail> SizingDetails { get; set; }
        }
    }
