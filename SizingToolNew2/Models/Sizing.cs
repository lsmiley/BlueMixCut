using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SizingToolNew2.Models;
using System.Data.Entity;
using System.Collections;


namespace SizingToolNew2.Models
{
    public class Sizing
    {
        private DateTime _created;

        public Sizing()

        {

            #region " Start of default values "

            // Setting Field default values Start Here.

           // PrepardedBy = "Add your Name Here..!";
            StedyStateBase = 5000;
            // AcctName = "Select an Account";


            // Default Endpoint Counts
            NumWorkstation = 0;
            NumWorkstation1 = 0;
            NumWorkstation2 = 0;
            NumWorkstation3 = 0;


            NumServer = 0;
            NumServer1 = 0;
            NumServer2 = 0;
            NumServer3 = 0;


            NumIpAddress = 0;
            NumIpAddress1 = 0;
            NumIpAddress2 = 0;
            NumIpAddress3 = 0;





            NumAppChange = 0;
            NumAppChange1 = 0;
            NumAppChange2 = 0;
            NumAppChange3 = 0;
            NumAddlCon = 0;
            NumAddlCon1 = 0;
            NumAddlCon2 = 0;
            NumAddlCon3 = 0;



            // Testing of Yes/No conditions
            // SoftLifeWkstnYesNo = true;
            // SoftLifeSvrYesNo = true;
            // SecCompRptYesNo = true;
            // ReportingYesNo = true;
            // SLAReportingYesNo = true;

            // *** Start Hours Calculations
            //  WkstnsHoursCalc = ((NumWorkstation / 2) + TotalTransitionHoursItem) * 0.130625;
            SrvsHoursCalc = 0;
            // IPsHoursCalc = ((NumIpAddress / 2) + TotalTransitionHoursItem) * 0.130625;
            //   DCSHoursCalc = ((NumDCS / 2) + TotalTransitionHoursItem) * 0.130625;
            // ScanEngineHoursCalc = ((NumScanEngine / 2) + TotalTransitionHoursItem) * 0.130625;
            // AppChangeHoursCalc = ((NumScanEngine / 2) + TotalTransitionHoursItem) * 0.130625;
            // AddlConHoursCalc = (((NumAddlCon + NumAddlCon1 + NumAddlCon2 + NumAddlCon3 + NumAddlCon4 + NumAddlCon5 + NumAddlCon6 + NumAddlCon7) / 14) + TotalTransitionHoursItem) * 0.130625;



            // *** End  Hours Calculations ***

            // *** Start Section Hours Calculations *****

            //  #region "Start SoftLifeWkstnHoursCalc"

            // **** Start SoftLifeWkstnHoursCalc ****

            // if (SoftLifeWkstnYesNo == false)
            // {
            //      SoftLifeWkstnHoursCalc = 0;

            //  }
            //  else
            //  {

            //       SoftLifeWkstnHoursCalc = (((Total / 2) + TotalTransitionHoursItem) * 0.130625);
            //   }
            // ***  End SoftLifeWkstnHoursCalc ****







            #endregion


            #region  *** Start Section Hours Calculations *****
            // *** Start Section Hours Calculations *****


            // FTE Default values

            //  ServerFTE = ((NumServer * 0.130625) + 525) / 2100; //need to add L&D Band
            ServerFTE1 = ((NumServer1 * 0.130625) + 525) / 2100; //need to add L&D Band
            ServerFTE2 = ((NumServer2 * 0.130625) + 525) / 2100; //need to add L&D Band
            ServerFTE3 = ((NumServer3 * 0.130625) + 525) / 2100; //need to add L&D Band


            // WorkstationFTE = ((NumWorkstation * 0.130625) + 525) / 2100; //need to add L&D Band
          //  WorkstationFTE1 = ((NumWorkstation1 * 0.130625) + 525) / 2100; //need to add L&D Band
          //  WorkstationFTE2 = ((NumWorkstation2 * 0.130625) + 525) / 2100; //need to add L&D Band
          //  WorkstationFTE3 = ((NumWorkstation3 * 0.130625) + 525) / 2100; //need to add L&D Band


            // IPEndpointFTE = (NumIpAddress * 0.130625) / (2100); //need to add L&D Band
            //   DCSFTE = (((NumDCS * 0.130625) + 525) / 2100); //need to add L&D Band
            // ScanEngineFTE = (((NumScanEngine * 0.130625) + 263) / 2100); //need to add L&D Band
            AppChangeFTE = (((NumAppChange * 0.130625) + 263) / 2100); //need to add L&D Band;
            AppChangeFTE = (((NumAppChange1 * 0.130625) + 263) / 2100); //need to add L&D Band;
            AppChangeFTE = (((NumAppChange2 * 0.130625) + 263) / 2100); //need to add L&D Band;
            AppChangeFTE = (((NumAppChange3 * 0.130625) + 263) / 2100); //need to add L&D Band;

            // AddlConFTE = (((NumAddlCon * 0.130625) + 263) / 2100); //need to add L&D Band;;
            // AddlConFTE1 = (((NumAddlCon1 * 0.130625) + 263) / 2100); //need to add L&D Band;
            //  AddlConFTE2 = (((NumAddlCon2 * 0.130625) + 263) / 2100); //need to add L&D Band;;
            //  AddlConFTE3 = (((NumAddlCon3 * 0.130625) + 263) / 2100); //need to add L&D Band;;


            #endregion  *** Start Section Hours Calculations *****


            // SoftLifeWkstnFTE = (((SoftLifeWkstnHoursCalc * 0.130625) + 263) / 2100); //need to add L&D Band;;
            // SoftLifeSvrFTE = (((SoftLifeSrvHoursCalc * 0.130625) + 263) / 2100); //need to add L&D Band;;
            //   SecComplRptFTE = (((SecCompHoursCalc * 0.130625) + 263) / 2100); //need to add L&D Band;;
            // ReportingFTE = (((RportingHoursCalc * 0.130625) + 263) / 2100); //need to add L&D Band;;
            //   SlaRprtFTE = (((SlaRptHoursCalc * 0.130625) + 263) / 2100); //need to add L&D Band;;

            // End FTE Default Values


            // Sub Section Default Values - Product Drop Down Values
            Product1 = ("Select Product");

            // Setting Field default values End Here.



            #region Other Cost Calc Section
            // Other Cost Calc Section

            // TravelCostCount = 0;
            // TravelCost = 3500.00;

            #endregion Other Cost Section

            NumMonths_1 = 12;
            NumMonths_2 = 12;
            NumMonths_3 = 12;
            NumMonths_4 = 12;

            TransitionWeeks = 12;
            TransformationWeeks = 12;

            // SelectPDF Defaults

            Password = "PdfMalware";
            Username = "pdfadmin";

            // Prod1WorkWeek = LaborDelivery.WorkWeek;
            //Prod1WorkWeek = 38;

            // Management Modifiers
            ManagementMod1stLine = (0.05);
            ManagementMod2ndLine = (.0083);

        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SizingId { get; set; }
        
        public int ConfigId { get; set; }
        public int AcctCustId { get; set; }
        [Display(Name = "Product")]
        public int AvProductId { get; set; }
        public int SizingTypeId { get; set; }


       // public int ProdCategoryId { get; set; }
        public int LaborDeliveryId { get; set; }

        public int TnTId { get; set; }
        [ForeignKey("TnTId")]
        public virtual TnTWorksheet TnTWorksheet { get; set; }
        public virtual ICollection<TnTWorksheet> TnTWorksheets { get; set; }

        [Display(Name = "Status")]
        public int StatusStateId { get; set; }

        public int SizingDetailDataId { get; set; }

    //    [ForeignKey("SizingDetailDataId")]
    //    public SizingDetail SizingDetailData { get; set; }

        
        public virtual SizingDetail SizingDetail { get; set; }

        [Display(Name = "ID #")]
        public int DisplayForSizingID { get { return SizingId + 000500; } set { } }

        public string SizingName { get; set; }

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


        // ********** Status
        [Display(Name = "Status")]
        public string SizingStatus { get; set; }


        // ********Start Section - Date and Time Calculations - ValidToDate

        [Display(Name = "Valid Until")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ValidToDate
        { get { return ValidToDate = Created.AddDays(90); } set { } }

        // ********End Section - Date and Time Calculations - ValidToDate


        [Display(Name = "Sales/Connect#")]
        public string SalesConnectNum { get; set; }

        [Display(Name = "RFS#")]
        public string RFSNum { get; set; }
        [Display(Name = "Prepared By:")]
        public string PrepardedBy { get; set; }

        public string RiskRating { get; set; }

        [Display(Name = "Sizing-Type")]
        public string TypeSizing { get; set; }

        // Field identified for recovery
       public string TransitionChrg { get; set; }
        // Field identified for recovery
        public string TransformationChrg { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote { get; set; }


        [Display(Name = "Steady/State-Base")]
        public double StedyStateBase { get; set; }

        // Start of Foreign Keys

        [ForeignKey("ConfigId")]
        public virtual ConfigTable ConfigTable { get; set; }

        [ForeignKey("AvProductId")]
        public virtual AvProduct AvProduct { get; set; }
        public virtual ICollection<AvProduct> AvProducts { get; set; }

        [ForeignKey("AcctCustId")]
        public virtual AcctCust AcctCust { get; set; }
        public virtual ICollection<AcctCust> AcctCusts { get; set; }

        [ForeignKey("SizingTypeId")]
        public virtual SizingType SizingType { get; set; }

         [ForeignKey("LaborDeliveryId")]
         public virtual LaborDelivery LaborDelivery { get; set; }
        //public virtual ICollection<LaborDelivery> LaborDeliverys { get; set; }

        [ForeignKey("StatusStateId")]
        public virtual StatusState StatusState { get; set; }


        public virtual ProdCategory ProdCategory { get; set; }


        


        #region " NBIE Sizer Info and Input "
        // NBIE Sizer Info and Input
        //   public int BbieId { get; set; }
        //   public string DeliveryLocation { get; set; }
        //   public double TransitionHrsChrg { get; set; }
        //   public double StedyStateHrs { get; set; }
        //   public double XrnOneTimeCost { get; set; }
        //   public double XrnOneTimePrice { get; set; }
        //   public double SsMonthlyCost { get; set; }
        //   public double SsMonthlyPrice { get; set; }
        //   public decimal TotalCost { get; set; }
        //   public decimal TotalPrice { get; set; }

        #endregion

        [Display(Name = "#Svrs")]
        public double NumServer { get; set; }
        public double NumServer1 { get; set; }
        public double NumServer2 { get; set; }
        public double NumServer3 { get; set; }
     //   public double NumServer4 { get; set; }
     //   public double NumServer5 { get; set; }
     //   public double NumServer6 { get; set; }
    //    public double NumServer7 { get; set; }


        [Display(Name = "#Wkstns")]
        public double NumWorkstation { get; set; }
        public double NumWorkstation1 { get; set; }
        public double NumWorkstation2 { get; set; }
        public double NumWorkstation3 { get; set; }

        //Calculation to total up the number of Endpoints
        [Display(Name = "#Endpoints")]
        public double Total { get { return ((NumServer + NumServer1 + NumServer2 + NumServer3) + NumWorkstation + NumWorkstation1 + NumWorkstation2 + NumWorkstation3) + NumIpAddress; } set { } }


        // Calculate FTE Section  ++++++++++++++++++++++++++++

        #region Calculate Workstation FTE

        //Calculate Wkstn FTE - ((NumWorkstation / 2) + TotalTransitionHoursItem) * 0.130625;
        [Display(Name = "Total WorkstationFTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double WorkstationFTE { get; set; }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double WorkstationFTE1 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double WorkstationFTE2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double WorkstationFTE3 { get; set; }



        #endregion Calculate Workstation FTE


        #region Calculate Workstation Hours

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double WkstnsHoursCalc { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double WkstnsHoursCalc1 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double WkstnsHoursCalc2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double WkstnsHoursCalc3 { get; set; }



        #endregion  Calculate Workstation Hours


        #region Caculate Server FTE

        //Calculate Server FTE

        [Display(Name = "Total ServerFTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double ServerFTE { get; set; }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double ServerFTE1 { get; set; }

            [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double ServerFTE2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double ServerFTE3 { get; set; }



        #endregion Caculate Server FTE


        #region Calculate Server Hours

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double SrvsHoursCalc { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double SrvsHoursCalc1 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double SrvsHoursCalc2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double SrvsHoursCalc3 { get; set; }


        #endregion Calculate Server Hours


        #region Calculate IP - Scan On Behalf FTE
        //Calculate IP Address FTE

        [Display(Name = "Total IPEndPointFTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double IPEndpointFTE { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double IPEndpointFTE1 { get { return ((NumIpAddress1 * 0.130625) / (2100)); } set { } }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double IPEndpointFTE2 { get { return ((NumIpAddress2 * 0.130625) / (2100)); } set { } }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double IPEndpointFTE3 { get { return ((NumIpAddress3 * 0.130625) / (2100)); } set { } }



        #endregion Calculate IP - Scan On Behalf FTE


        #region IP - Scan On Behalf Hours Calc
        //IP - Scan On Behalf Hours Calc

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double IPsHoursCalc { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double IPsHoursCalc1 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double IPsHoursCalc2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double IPsHoursCalc3 { get; set; }


        #endregion IP - Scan On Behalf Hours Calc


        [Display(Name = "#IP/Scan")]
        public double NumIpAddress { get; set; }
        public double NumIpAddress1 { get; set; }
        public double NumIpAddress2 { get; set; }
        public double NumIpAddress3 { get; set; }



    //Calculate DataCenter Security FTE
    //  [Display(Name = "Data Ctr Security FTE")]
    //  [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
    //  public double DCSFTE { get { return ((NumDCS * 0.130625) / (2100)); } set { } }
    //  [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
    //  public double DCSHoursCalc { get { return ((NumDCS / 2) + TotalTransitionHoursItem) * 0.130625; } set { } }
    //  public double NumDCS { get; set; }

    //Calculate NAS ScanEngine FTE
    //  [Display(Name = "ScanEngine  FTE")]
    // [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
    //public double ScanEngineFTE { get { return ((NumScanEngine * 0.130625) / (2100)); } set { } }
    // [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
    // public double ScanEngineHoursCalc { get; set; }
    // public double NumScanEngine { get; set; }

    //Calculate Application and Change Control FTE
    [Display(Name = "Application and Change Control FTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AppChangeFTE { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AppChangeFTE1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AppChangeFTE2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AppChangeFTE3 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AppChangeHoursCalc { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AppChangeHoursCalc1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AppChangeHoursCalc2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AppChangeHoursCalc3 { get; set; }


        public double NumAppChange { get; set; }
        public double NumAppChange1 { get; set; }
        public double NumAppChange2 { get; set; }
        public double NumAppChange3 { get; set; }


        //Calculate Additional Consoles FTE
        [Display(Name = "Additional Consoles FTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AddlConFTE { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AddlConFTE1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AddlConFTE2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AddlConFTE3 { get; set; }


        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double AddlConHoursCalc { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double NumAddlCon { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]

        public double NumAddlCon1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double AddlConHoursCalc1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]

        public double NumAddlCon2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double AddlConHoursCalc2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double NumAddlCon3 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public double AddlConHoursCalc3 { get; set; }



        //Calculate Software Life Wkstn FTE
        [Display(Name = "Software Life Cycle WKstn FTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SoftLifeWkstnFTE { get; set; }
       
     //   public double SoftLifeWkstnHoursCalc { get; set; }


      //  public bool SoftLifeWkstnYesNo { get; set; }

        //Calculate Software Life Cycle Svr FTE
        [Display(Name = "Software Life Cycle WKstnFTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SoftLifeSvrFTE { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SoftLifeSrvHoursCalc { get; set; }
        public bool SoftLifeSvrYesNo { get; set; }

        //Calculate Security Compliance Review FTE
        [Display(Name = "Security Compliance Review")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SecComplRptFTE { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SecCompHoursCalc { get; set; }
        public bool SecCompRptYesNo { get; set; }



        //Calculate Detection Reporting FTE
        [Display(Name = "Detection Reporting FTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double ReportingFTE { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double RportingHoursCalc { get; set; }
        public bool ReportingYesNo { get; set; }


        //Calculate Health/SLA Reports FTE
        [Display(Name = "Health/SLA Reports")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SlaRprtFTE { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SlaRptHoursCalc { get; set; }
        public bool SLAReportingYesNo { get; set; }


        //Calculate Total FTE
        [Display(Name = "Total FTE")]
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double FTE
        {
            get
            {
                return (ServerFTE + WorkstationFTE + IPEndpointFTE + AppChangeFTE + AddlConFTE + SoftLifeWkstnFTE + SoftLifeSvrFTE + SecComplRptFTE + ReportingFTE + SlaRprtFTE + ServerFTE1 + ServerFTE2 + ServerFTE3 +
  + WorkstationFTE1 + WorkstationFTE2 + WorkstationFTE3 + IPEndpointFTE1 + IPEndpointFTE2 + IPEndpointFTE3
  );
            }
            set { }
        }



        // Calculate Hours of Work based "Total" Endpoint, times "ConfigTable.FractionalHours", Plus "Base"
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double HoursCalc { get; set; }


        // ****** Start Steady State Totals
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalHours { get; set; }

        
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalBand3 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalBand4 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalBand5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalBand6 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalBand7 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalBand8 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalBand9 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateBandsTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double FirstLineMangerBand8Hours { get { return (SteadyStateTotalHours * .05); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double FirstLineMangerBand8Total { get { return (FirstLineMangerBand8Hours * .05); } set { } }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double FirstLineMangerBand8TotalFTE { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SecondLineMangerBand9Hours { get { return (SteadyStateTotalHours * 0.0083); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SecondLineMangerBand9Total { get { return (SecondLineMangerBand9Hours * 0.0083); } set { } }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SecondLineMangerBand9TotalFTE { get { return (SecondLineMangerBand9Total * 0.0083); } set { } }



        // Steady States SubTotals
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalHours { get { return ((SteadyStateTotalHours + FirstLineMangerBand8Hours) + SecondLineMangerBand9Hours + AdditionalServices + TotalComponents_Hours + TotalCustomHours); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalBand3 { get { return (SteadyStateTotalBand3); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalBand4 { get { return (SteadyStateTotalBand4); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalBand5 { get { return (SteadyStateTotalBand5); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalBand6 { get { return (SteadyStateTotalBand6); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalBand7 { get { return (SteadyStateTotalBand7); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalBand8 { get { return (SteadyStateTotalBand8); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalBand9 { get { return (SteadyStateTotalBand9); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateSubTotalTotal { get { return (FTE + FirstLineMangerBand8TotalFTE + SecondLineMangerBand9Total); } set { } }


        // ****** End Steady State Totals

        // Other Cost section of Calculate FTE Form
        //  [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public double TravelCostCount { get; set; }
        //[DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public string TravelCostDesc { get; set; }
        // [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TravelCost { get; set; }
        // [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TravelCostAmt { get; set; }

        //  [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public double RemoteConsoleCostCount { get; set; }
        //  [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]//
        public string RemoteConsoleDesc { get; set; }
        //  [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public double RemoteConsoleCost { get; set; }
        //  [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public double RemoteConsoleCostAmt { get; set; }

        //  [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public double EducationCostCount { get; set; }
        //  [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public string EducationCostDesc { get; set; }
        //[DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double EducationCost { get; set; }
        // [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double EducationCostAmt { get; set; }

        //  [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public double OtherCostCount1 { get; set; }
        //  [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public string OtherCostDesc1 { get; set; }
        //   [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double OtherCost1 { get; set; }
        //   [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double OtherCost1Amt { get; set; }

        //   [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public double OtherCostCount2 { get; set; }
        //   [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public string OtherCostDesc2 { get; set; }
        //   [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double OtherCost2 { get; set; }
        //   [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double OtherCost2Amt { get; set; }


        //   [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public double OtherCostCount3 { get; set; }
        //   [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public string OtherCostDesc3 { get; set; }
        //   [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double OtherCost3 { get; set; }
        //   [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double OtherCost3Amt { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double OtherCostsDollarSubTotal { get { return (TravelCostAmt + RemoteConsoleCostAmt + EducationCostAmt + OtherCost1Amt + OtherCost2Amt + OtherCost3Amt); } set { } }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateFTE { get { return (TotalSteadyStateBand3 + TotalSteadyStateBand4 + TotalSteadyStateBand5 + TotalSteadyStateBand6 + TotalSteadyStateBand7 + TotalSteadyStateBand8 + TotalSteadyStateBand9 + TotalSteadyStateTotal1stLineMgr + TotalSteadyStateTotal2ndLineMgr); } set { } }
        // [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateHours { get { return (SteadyStateSubTotalHours); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateBand3 { get { return (SteadyStateSubTotalBand3); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateBand4 { get { return (SteadyStateSubTotalBand4); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateBand5 { get { return (SteadyStateSubTotalBand5); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateBand6 { get { return (SteadyStateSubTotalBand6); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateBand7 { get { return (SteadyStateSubTotalBand7); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateBand8 { get { return (SteadyStateSubTotalBand8); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateBand9 { get { return (SteadyStateSubTotalBand9); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateTotal1stLineMgr { get { return (FirstLineMangerBand8TotalFTE); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalSteadyStateTotal2ndLineMgr { get { return (SecondLineMangerBand9Total); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateTotalFTE { get { return (SteadyStateTotalBand3 + SteadyStateTotalBand4 + SteadyStateTotalBand5 + SteadyStateTotalBand6 + SteadyStateTotalBand7 + SteadyStateTotalBand8 + SteadyStateTotalBand9 + TotalSteadyStateTotal1stLineMgr + TotalSteadyStateTotal2ndLineMgr); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortFTE { get { return (SubTotalTotalEffortBand3 + SubTotalTotalEffortBand4 + SubTotalTotalEffortBand5 + SubTotalTotalEffortBand6 + SubTotalTotalEffortBand7 + SubTotalTotalEffortBand8 + SubTotalTotalEffortBand9 + SubTotalTotalEffort1stLineMgr + SubTotalTotalEffort2ndLineMgr); } set { } }
        // [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortHours { get; set; }
    [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortBand3 { get { return (TotalSteadyStateBand3); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortBand4 { get { return (TotalSteadyStateBand4); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortBand5 { get { return (TotalSteadyStateBand5); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortBand6 { get { return (TotalSteadyStateBand6); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortBand7 { get { return (TotalSteadyStateBand7); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortBand8 { get { return (TotalSteadyStateBand8); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortBand9 { get { return (TotalSteadyStateBand9); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffort1stLineMgr { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffort2ndLineMgr { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SubTotalTotalEffortTotalFTE { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double RiskRatingTotalFTE { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateGrandTotalFTE { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double GrandTotalFTE { get; set; }
        // Start of Other Cost on Calculate FTE Sheet


        // End of Other Cost on Calculate FTE Sheet
    

        #region  Start of Band Calc Fields across Technologies
        // Removed and Replaced with RunTime Variables

        #endregion End of Band Calc Fields across Technologies



        // Transition Weeks
        public double TransitionWeeks { get; set; }

        // Transformation Weeks
        public double TransformationWeeks { get; set; }

        // Product DropDown
        public string Product1 { get; set; }



        // Transition and Transformation Yes/No
        public Boolean TransitionYesNo { get; set; }
        public Boolean TransformationYesNo { get; set; }



        #region Product Components


        // Component Hours and Selection

        #region Component #1
        //....., Component Descriotion
        public string Prod1Compnent1Desc { get; set; }
        public string Prod2Compnent1Desc { get; set; }
        public string Prod3Compnent1Desc { get; set; }
        public string Prod4Compnent1Desc { get; set; }


        public bool Prod1Component1 { get; set; }
        public bool Prod2Component1 { get; set; }
        public bool Prod3Component1 { get; set; }
        public bool Prod4Component1 { get; set; }

        //....., Component Hours
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours1 { get; set; }

        //Wkstns
        public bool Prod1Component1_Wkstn { get; set; }
        public bool Prod2Component1_Wkstn { get; set; }
        public bool Prod3Component1_Wkstn { get; set; }
        public bool Prod4Component1_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component1_Svr { get; set; }
        public bool Prod2Component1_Svr { get; set; }
        public bool Prod3Component1_Svr { get; set; }
        public bool Prod4Component1_Svr { get; set; }

        // IPs
        public bool Prod1Component1_IP { get; set; }
        public bool Prod2Component1_IP { get; set; }
        public bool Prod3Component1_IP { get; set; }
        public bool Prod4Component1_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty1 { get; set; }
        public int Prod2Component_Qty1 { get; set; }
        public int Prod3Component_Qty1 { get; set; }
        public int Prod4Component_Qty1 { get; set; }


        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component1_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component1_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component1_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component1_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component1_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component1_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component1_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component1_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component1_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component1_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component1_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component1_IPHours { get; set; }




        #endregion Component #1

        #region Component #2

        //Component #2
        //....., Component Descriotion
        public string Prod1Compnent2Desc { get; set; }
        public string Prod2Compnent2Desc { get; set; }
        public string Prod3Compnent2Desc { get; set; }
        public string Prod4Compnent2Desc { get; set; }


        //....., Component Hours
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours2 { get; set; }

        public bool Prod1Component2 { get; set; }
        public bool Prod2Component2 { get; set; }
        public bool Prod3Component2 { get; set; }
        public bool Prod4Component2 { get; set; }

        //Wkstns
        public bool Prod1Component2_Wkstn { get; set; }
        public bool Prod2Component2_Wkstn { get; set; }
        public bool Prod3Component2_Wkstn { get; set; }
        public bool Prod4Component2_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component2_Svr { get; set; }
        public bool Prod2Component2_Svr { get; set; }
        public bool Prod3Component2_Svr { get; set; }
        public bool Prod4Component2_Svr { get; set; }

        // IPs
        public bool Prod1Component2_IP { get; set; }
        public bool Prod2Component2_IP { get; set; }
        public bool Prod3Component2_IP { get; set; }
        public bool Prod4Component2_IP { get; set; }

        // Quantity
        public int Prod1Component_Qty2 { get; set; }
        public int Prod2Component_Qty2 { get; set; }
        public int Prod3Component_Qty2 { get; set; }
        public int Prod4Component_Qty2 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component2_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component2_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component2_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component2_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component2_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component2_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component2_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component2_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component2_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component2_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component2_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component2_IPHours { get; set; }



        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentComplexityFac1_1 { get; set; }
        public double Prod1ComponentComplexityFac2_1 { get; set; }
        public double Prod1ComponentComplexityFac3_1 { get; set; }
        public double Prod1ComponentComplexityFac4_1 { get; set; }
        public double Prod1ComponentComplexityFac5_1 { get; set; }
        public double Prod1ComponentComplexityFac6_1 { get; set; }
        public double Prod1ComponentComplexityFac7_1 { get; set; }
        public double Prod1ComponentComplexityFac8_1 { get; set; }
        public double Prod1ComponentComplexityFac9_1 { get; set; }
        public double Prod1ComponentComplexityFac10_1 { get; set; }
        public double Prod1ComponentComplexityFac11_1 { get; set; }
        public double Prod1ComponentComplexityFac12_1 { get; set; }
        public double Prod1ComponentComplexityFac13_1 { get; set; }
        public double Prod1ComponentComplexityFac14_1 { get; set; }
        public double Prod1ComponentComplexityFac15_1 { get; set; }
        // ProductBase Placeholder field
        public double Prod1ComplexityBase { get; set; }

        //ComplexityFactors - Prod2ComponentComplexityFac1_2
        public double Prod1ComplexityFac { get; set; }
      

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentComplexityFac1_1 { get; set; }
        public double Prod2ComponentComplexityFac2_1 { get; set; }
        public double Prod2ComponentComplexityFac3_1 { get; set; }
        public double Prod2ComponentComplexityFac4_1 { get; set; }
        public double Prod2ComponentComplexityFac5_1 { get; set; }
        public double Prod2ComponentComplexityFac6_1 { get; set; }
        public double Prod2ComponentComplexityFac7_1 { get; set; }
        public double Prod2ComponentComplexityFac8_1 { get; set; }
        public double Prod2ComponentComplexityFac9_1 { get; set; }
        public double Prod2ComponentComplexityFac10_1 { get; set; }
        public double Prod2ComponentComplexityFac11_1 { get; set; }
        public double Prod2ComponentComplexityFac12_1 { get; set; }
        public double Prod2ComponentComplexityFac13_1 { get; set; }
        public double Prod2ComponentComplexityFac14_1 { get; set; }
        public double Prod2ComponentComplexityFac15_1 { get; set; }
        public double Prod2ComplexityBase { get; set; }
        public double Prod2ComplexityFac { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentComplexityFac1_1 { get; set; }
        public double Prod3ComponentComplexityFac2_1 { get; set; }
        public double Prod3ComponentComplexityFac3_1 { get; set; }
        public double Prod3ComponentComplexityFac4_1 { get; set; }
        public double Prod3ComponentComplexityFac5_1 { get; set; }
        public double Prod3ComponentComplexityFac6_1 { get; set; }
        public double Prod3ComponentComplexityFac7_1 { get; set; }
        public double Prod3ComponentComplexityFac8_1 { get; set; }
        public double Prod3ComponentComplexityFac9_1 { get; set; }
        public double Prod3ComponentComplexityFac10_1 { get; set; }
        public double Prod3ComponentComplexityFac11_1 { get; set; }
        public double Prod3ComponentComplexityFac12_1 { get; set; }
        public double Prod3ComponentComplexityFac13_1 { get; set; }
        public double Prod3ComponentComplexityFac14_1 { get; set; }
        public double Prod3ComponentComplexityFac15_1 { get; set; }
        public double Prod3ComplexityBase { get; set; }
        public double Prod3ComplexityFac { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentComplexityFac1_1 { get; set; }
        public double Prod4ComponentComplexityFac2_1 { get; set; }
        public double Prod4ComponentComplexityFac3_1 { get; set; }
        public double Prod4ComponentComplexityFac4_1 { get; set; }
        public double Prod4ComponentComplexityFac5_1 { get; set; }
        public double Prod4ComponentComplexityFac6_1 { get; set; }
        public double Prod4ComponentComplexityFac7_1 { get; set; }
        public double Prod4ComponentComplexityFac8_1 { get; set; }
        public double Prod4ComponentComplexityFac9_1 { get; set; }
        public double Prod4ComponentComplexityFac10_1 { get; set; }
        public double Prod4ComponentComplexityFac11_1 { get; set; }
        public double Prod4ComponentComplexityFac12_1 { get; set; }
        public double Prod4ComponentComplexityFac13_1 { get; set; }
        public double Prod4ComponentComplexityFac14_1 { get; set; }
        public double Prod4ComponentComplexityFac15_1 { get; set; }
        public double Prod4ComplexityBase { get; set; }
        public double Prod4ComplexityFac { get; set; }

        #endregion Component #2

        #region Component #3

        //Component #3

        //....., Component Descriotion
        public string Prod1Compnent3Desc { get; set; }
        public string Prod2Compnent3Desc { get; set; }
        public string Prod3Compnent3Desc { get; set; }
        public string Prod4Compnent3Desc { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours3 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours3 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours3 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours3 { get; set; }


        public bool Prod1Component3 { get; set; }
        public bool Prod2Component3 { get; set; }
        public bool Prod3Component3 { get; set; }
        public bool Prod4Component3 { get; set; }

        //Wkstns
        public bool Prod1Component3_Wkstn { get; set; }
        public bool Prod2Component3_Wkstn { get; set; }
        public bool Prod3Component3_Wkstn { get; set; }
        public bool Prod4Component3_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component3_Svr { get; set; }
        public bool Prod2Component3_Svr { get; set; }
        public bool Prod3Component3_Svr { get; set; }
        public bool Prod4Component3_Svr { get; set; }

        // IPs
        public bool Prod1Component3_IP { get; set; }
        public bool Prod2Component3_IP { get; set; }
        public bool Prod3Component3_IP { get; set; }
        public bool Prod4Component3_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty3 { get; set; }
        public int Prod2Component_Qty3 { get; set; }
        public int Prod3Component_Qty3 { get; set; }
        public int Prod4Component_Qty3 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component3_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component3_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component3_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component3_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component3_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component3_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component3_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component3_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component3_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component3_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component3_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component3_IPHours { get; set; }

        #endregion Component #3

        #region Component #4


        //Component #4

        //....., Component Descriotion
        public string Prod1Compnent4Desc { get; set; }
        public string Prod2Compnent4Desc { get; set; }
        public string Prod3Compnent4Desc { get; set; }
        public string Prod4Compnent4Desc { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours4 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours4 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours4 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours4 { get; set; }

        public bool Prod1Component4 { get; set; }
        public bool Prod2Component4 { get; set; }
        public bool Prod3Component4 { get; set; }
        public bool Prod4Component4 { get; set; }

        //Wkstns
        public bool Prod1Component4_Wkstn { get; set; }
        public bool Prod2Component4_Wkstn { get; set; }
        public bool Prod3Component4_Wkstn { get; set; }
        public bool Prod4Component4_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component4_Svr { get; set; }
        public bool Prod2Component4_Svr { get; set; }
        public bool Prod3Component4_Svr { get; set; }
        public bool Prod4Component4_Svr { get; set; }

        // IPs
        public bool Prod1Component4_IP { get; set; }
        public bool Prod2Component4_IP { get; set; }
        public bool Prod3Component4_IP { get; set; }
        public bool Prod4Component4_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty4 { get; set; }
        public int Prod2Component_Qty4 { get; set; }
        public int Prod3Component_Qty4 { get; set; }
        public int Prod4Component_Qty4 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component4_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component4_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component4_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component4_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component4_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component4_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component4_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component4_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component4_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component4_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component4_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component4_IPHours { get; set; }

        #endregion Component #4

        #region Component #5


        //Component #5

        //....., Component Descriotion
        public string Prod1Compnent5Desc { get; set; }
        public string Prod2Compnent5Desc { get; set; }
        public string Prod3Compnent5Desc { get; set; }
        public string Prod4Compnent5Desc { get; set; }



        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours5 { get; set; }

        public bool Prod1Component5 { get; set; }
        public bool Prod2Component5 { get; set; }
        public bool Prod3Component5 { get; set; }
        public bool Prod4Component5 { get; set; }

        //Wkstns
        public bool Prod1Component5_Wkstn { get; set; }
        public bool Prod2Component5_Wkstn { get; set; }
        public bool Prod3Component5_Wkstn { get; set; }
        public bool Prod4Component5_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component5_Svr { get; set; }
        public bool Prod2Component5_Svr { get; set; }
        public bool Prod3Component5_Svr { get; set; }
        public bool Prod4Component5_Svr { get; set; }

        // IPs
        public bool Prod1Component5_IP { get; set; }
        public bool Prod2Component5_IP { get; set; }
        public bool Prod3Component5_IP { get; set; }
        public bool Prod4Component5_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty5 { get; set; }
        public int Prod2Component_Qty5 { get; set; }
        public int Prod3Component_Qty5 { get; set; }
        public int Prod4Component_Qty5 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component5_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component5_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component5_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component5_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component5_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component5_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component5_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component5_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component5_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component5_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component5_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component5_IPHours { get; set; }

        #endregion Component #5

        #region Component #6

        //Component #6

        //....., Component Descriotion
        public string Prod1Compnent6Desc { get; set; }
        public string Prod2Compnent6Desc { get; set; }
        public string Prod3Compnent6Desc { get; set; }
        public string Prod4Compnent6Desc { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours6 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours6 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours6 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours6 { get; set; }



        public bool Prod1Component6 { get; set; }
        public bool Prod2Component6 { get; set; }
        public bool Prod3Component6 { get; set; }
        public bool Prod4Component6 { get; set; }

        //Wkstns
        public bool Prod1Component6_Wkstn { get; set; }
        public bool Prod2Component6_Wkstn { get; set; }
        public bool Prod3Component6_Wkstn { get; set; }
        public bool Prod4Component6_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component6_Svr { get; set; }
        public bool Prod2Component6_Svr { get; set; }
        public bool Prod3Component6_Svr { get; set; }
        public bool Prod4Component6_Svr { get; set; }

        // IPs
        public bool Prod1Component6_IP { get; set; }
        public bool Prod2Component6_IP { get; set; }
        public bool Prod3Component6_IP { get; set; }
        public bool Prod4Component6_IP { get; set; }


        // Quantity
        public int Prod1Component_Qty6 { get; set; }
        public int Prod2Component_Qty6 { get; set; }
        public int Prod3Component_Qty6 { get; set; }
        public int Prod4Component_Qty6 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component6_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component6_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component6_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component6_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component6_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component6_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component6_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component6_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component6_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component6_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component6_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component6_IPHours { get; set; }

        #endregion Component #6

        #region Component #7
        //....., Component Descriotion
        public string Prod1Compnent7Desc { get; set; }
        public string Prod2Compnent7Desc { get; set; }
        public string Prod3Compnent7Desc { get; set; }
        public string Prod4Compnent7Desc { get; set; }


        //Component #7
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours7 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours7 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours7 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours7 { get; set; }



        public bool Prod1Component7 { get; set; }
        public bool Prod2Component7 { get; set; }
        public bool Prod3Component7 { get; set; }
        public bool Prod4Component7 { get; set; }

        //Wkstns
        public bool Prod1Component7_Wkstn { get; set; }
        public bool Prod2Component7_Wkstn { get; set; }
        public bool Prod3Component7_Wkstn { get; set; }
        public bool Prod4Component7_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component7_Svr { get; set; }
        public bool Prod2Component7_Svr { get; set; }
        public bool Prod3Component7_Svr { get; set; }
        public bool Prod4Component7_Svr { get; set; }

        // IPs
        public bool Prod1Component7_IP { get; set; }
        public bool Prod2Component7_IP { get; set; }
        public bool Prod3Component7_IP { get; set; }
        public bool Prod4Component7_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty7 { get; set; }
        public int Prod2Component_Qty7 { get; set; }
        public int Prod3Component_Qty7 { get; set; }
        public int Prod4Component_Qty7 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component7_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component7_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component7_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component7_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component7_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component7_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component7_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component7_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component7_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component7_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component7_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component7_IPHours { get; set; }

        #endregion Component #7

        #region Component #8

        //....., Component Descriotion
        public string Prod1Compnent8Desc { get; set; }
        public string Prod2Compnent8Desc { get; set; }
        public string Prod3Compnent8Desc { get; set; }
        public string Prod4Compnent8Desc { get; set; }



        //Component #8
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours8 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours8 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours8 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours8 { get; set; }


        public bool Prod1Component8 { get; set; }
        public bool Prod2Component8 { get; set; }
        public bool Prod3Component8 { get; set; }
        public bool Prod4Component8 { get; set; }

        //Wkstns
        public bool Prod1Component8_Wkstn { get; set; }
        public bool Prod2Component8_Wkstn { get; set; }
        public bool Prod3Component8_Wkstn { get; set; }
        public bool Prod4Component8_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component8_Svr { get; set; }
        public bool Prod2Component8_Svr { get; set; }
        public bool Prod3Component8_Svr { get; set; }
        public bool Prod4Component8_Svr { get; set; }

        // IPs
        public bool Prod1Component8_IP { get; set; }
        public bool Prod2Component8_IP { get; set; }
        public bool Prod3Component8_IP { get; set; }
        public bool Prod4Component8_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty8 { get; set; }
        public int Prod2Component_Qty8 { get; set; }
        public int Prod3Component_Qty8 { get; set; }
        public int Prod4Component_Qty8 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component8_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component8_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component8_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component8_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component8_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component8_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component8_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component8_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component8_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component8_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component8_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component8_IPHours { get; set; }

        #endregion Component #8

        #region Component #9

        //Component #9
                //....., Component Descriotion
        public string Prod1Compnent9Desc { get; set; }
        public string Prod2Compnent9Desc { get; set; }
        public string Prod3Compnent9Desc { get; set; }
        public string Prod4Compnent9Desc { get; set; }


        //....., Component Hours
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours9 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours9 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours9 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours9 { get; set; }



        public bool Prod1Component9 { get; set; }
        public bool Prod2Component9 { get; set; }
        public bool Prod3Component9 { get; set; }
        public bool Prod4Component9 { get; set; }

        //Wkstns
        public bool Prod1Component9_Wkstn { get; set; }
        public bool Prod2Component9_Wkstn { get; set; }
        public bool Prod3Component9_Wkstn { get; set; }
        public bool Prod4Component9_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component9_Svr { get; set; }
        public bool Prod2Component9_Svr { get; set; }
        public bool Prod3Component9_Svr { get; set; }
        public bool Prod4Component9_Svr { get; set; }

        // IPs
        public bool Prod1Component9_IP { get; set; }
        public bool Prod2Component9_IP { get; set; }
        public bool Prod3Component9_IP { get; set; }
        public bool Prod4Component9_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty9 { get; set; }
        public int Prod2Component_Qty9 { get; set; }
        public int Prod3Component_Qty9 { get; set; }
        public int Prod4Component_Qty9 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component9_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component9_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component9_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component9_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component9_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component9_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component9_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component9_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component9_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component9_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component9_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component9_IPHours { get; set; }


        #endregion Component #9

        #region Component #10



        //Component #10


        //....., Component Descriotion
        public string Prod1Compnent10Desc { get; set; }
        public string Prod2Compnent10Desc { get; set; }
        public string Prod3Compnent10Desc { get; set; }
        public string Prod4Compnent10Desc { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours10 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours10 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours10 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours10 { get; set; }



        public bool Prod1Component10 { get; set; }
        public bool Prod2Component10 { get; set; }
        public bool Prod3Component10 { get; set; }
        public bool Prod4Component10 { get; set; }

        //Wkstns
        public bool Prod1Component10_Wkstn { get; set; }
        public bool Prod2Component10_Wkstn { get; set; }
        public bool Prod3Component10_Wkstn { get; set; }
        public bool Prod4Component10_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component10_Svr { get; set; }
        public bool Prod2Component10_Svr { get; set; }
        public bool Prod3Component10_Svr { get; set; }
        public bool Prod4Component10_Svr { get; set; }

        // IPs
        public bool Prod1Component10_IP { get; set; }
        public bool Prod2Component10_IP { get; set; }
        public bool Prod3Component10_IP { get; set; }
        public bool Prod4Component10_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty10 { get; set; }
        public int Prod2Component_Qty10 { get; set; }
        public int Prod3Component_Qty10 { get; set; }
        public int Prod4Component_Qty10 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component10_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component10_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component10_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double Prod4Component10_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component10_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component10_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component10_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component10_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component10_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component10_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component10_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component10_IPHours { get; set; }


        #endregion Component #9\10

        #region Component #11

        //Component #11

        //....., Component Descriotion
        public string Prod1Compnent11Desc { get; set; }
        public string Prod2Compnent11Desc { get; set; }
        public string Prod3Compnent11Desc { get; set; }
        public string Prod4Compnent11Desc { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours11 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours11 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours11 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours11 { get; set; }

        public bool Prod1Component11 { get; set; }
        public bool Prod2Component11 { get; set; }
        public bool Prod3Component11 { get; set; }
        public bool Prod4Component11 { get; set; }

        //Wkstns
        public bool Prod1Component11_Wkstn { get; set; }
        public bool Prod2Component11_Wkstn { get; set; }
        public bool Prod3Component11_Wkstn { get; set; }
        public bool Prod4Component11_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component11_Svr { get; set; }
        public bool Prod2Component11_Svr { get; set; }
        public bool Prod3Component11_Svr { get; set; }
        public bool Prod4Component11_Svr { get; set; }

        // IPs
        public bool Prod1Component11_IP { get; set; }
        public bool Prod2Component11_IP { get; set; }
        public bool Prod3Component11_IP { get; set; }
        public bool Prod4Component11_IP { get; set; }


        // Quantity
        public int Prod1Component_Qty11 { get; set; }
        public int Prod2Component_Qty11 { get; set; }
        public int Prod3Component_Qty11 { get; set; }
        public int Prod4Component_Qty11 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component11_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component11_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component11_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component11_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component11_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component11_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component11_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component11_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component11_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component11_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component11_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component11_IPHours { get; set; }


        #endregion Component #11

        #region Component #12

        //Component #12

        //....., Component Descriotion
        public string Prod1Compnent12Desc { get; set; }
        public string Prod2Compnent12Desc { get; set; }
        public string Prod3Compnent12Desc { get; set; }
        public string Prod4Compnent12Desc { get; set; }



        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours12 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours12 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours12 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours12 { get; set; }

        public bool Prod1Component12 { get; set; }
        public bool Prod2Component12 { get; set; }
        public bool Prod3Component12 { get; set; }
        public bool Prod4Component12 { get; set; }

        //Wkstns
        public bool Prod1Component12_Wkstn { get; set; }
        public bool Prod2Component12_Wkstn { get; set; }
        public bool Prod3Component12_Wkstn { get; set; }
        public bool Prod4Component12_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component12_Svr { get; set; }
        public bool Prod2Component12_Svr { get; set; }
        public bool Prod3Component12_Svr { get; set; }
        public bool Prod4Component12_Svr { get; set; }

        // IPs
        public bool Prod1Component12_IP { get; set; }
        public bool Prod2Component12_IP { get; set; }
        public bool Prod3Component12_IP { get; set; }
        public bool Prod4Component12_IP { get; set; }


        // Quantity
        public int Prod1Component_Qty12 { get; set; }
        public int Prod2Component_Qty12 { get; set; }
        public int Prod3Component_Qty12 { get; set; }
        public int Prod4Component_Qty12 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component12_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component12_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component12_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component12_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component12_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component12_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component12_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component12_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component12_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component12_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component12_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component12_IPHours { get; set; }


        #endregion Component #12

        #region Component #13

        //Component #13

        //....., Component Descriotion
        public string Prod1Compnent13Desc { get; set; }
        public string Prod2Compnent13Desc { get; set; }
        public string Prod3Compnent13Desc { get; set; }
        public string Prod4Compnent13Desc { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours13 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours13 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours13 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours13 { get; set; }

        public bool Prod1Component13 { get; set; }
        public bool Prod2Component13 { get; set; }
        public bool Prod3Component13 { get; set; }
        public bool Prod4Component13 { get; set; }

        //Wkstns
        public bool Prod1Component13_Wkstn { get; set; }
        public bool Prod2Component13_Wkstn { get; set; }
        public bool Prod3Component13_Wkstn { get; set; }
        public bool Prod4Component13_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component13_Svr { get; set; }
        public bool Prod2Component13_Svr { get; set; }
        public bool Prod3Component13_Svr { get; set; }
        public bool Prod4Component13_Svr { get; set; }

        // IPs
        public bool Prod1Component13_IP { get; set; }
        public bool Prod2Component13_IP { get; set; }
        public bool Prod3Component13_IP { get; set; }
        public bool Prod4Component13_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty13 { get; set; }
        public int Prod2Component_Qty13 { get; set; }
        public int Prod3Component_Qty13 { get; set; }
        public int Prod4Component_Qty13 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component13_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component13_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component13_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component13_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component13_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component13_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component13_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component13_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component13_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component13_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component13_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component13_IPHours { get; set; }


        #endregion Component #13

        #region Component #14

        //Component #14

        //....., Component Descriotion
        public string Prod1Compnent14Desc { get; set; }
        public string Prod2Compnent14Desc { get; set; }
        public string Prod3Compnent14Desc { get; set; }
        public string Prod4Compnent14Desc { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours14 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours14 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours14 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours14 { get; set; }


        public bool Prod1Component14 { get; set; }
        public bool Prod2Component14 { get; set; }
        public bool Prod3Component14 { get; set; }
        public bool Prod4Component14 { get; set; }

        //Wkstns
        public bool Prod1Component14_Wkstn { get; set; }
        public bool Prod2Component14_Wkstn { get; set; }
        public bool Prod3Component14_Wkstn { get; set; }
        public bool Prod4Component14_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component14_Svr { get; set; }
        public bool Prod2Component14_Svr { get; set; }
        public bool Prod3Component14_Svr { get; set; }
        public bool Prod4Component14_Svr { get; set; }

        // IPs
        public bool Prod1Component14_IP { get; set; }
        public bool Prod2Component14_IP { get; set; }
        public bool Prod3Component14_IP { get; set; }
        public bool Prod4Component14_IP { get; set; }


        // Quantity
        public int Prod1Component_Qty14 { get; set; }
        public int Prod2Component_Qty14 { get; set; }
        public int Prod3Component_Qty14 { get; set; }
        public int Prod4Component_Qty14 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component14_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component14_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component14_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component14_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component14_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component14_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component14_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component14_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component14_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component14_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component14_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component14_IPHours { get; set; }


        #endregion Component #14

        #region Component #15

        //....., Component Descriotion
        public string Prod1Compnent15Desc { get; set; }
        public string Prod2Compnent15Desc { get; set; }
        public string Prod3Compnent15Desc { get; set; }
        public string Prod4Compnent15Desc { get; set; }

        //Component #15
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1ComponentHours15 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2ComponentHours15 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3ComponentHours15 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4ComponentHours15 { get; set; }

        public bool Prod1Component15 { get; set; }
        public bool Prod2Component15 { get; set; }
        public bool Prod3Component15 { get; set; }
        public bool Prod4Component15 { get; set; }

        //Wkstns
        public bool Prod1Component15_Wkstn { get; set; }
        public bool Prod2Component15_Wkstn { get; set; }
        public bool Prod3Component15_Wkstn { get; set; }
        public bool Prod4Component15_Wkstn { get; set; }

        // Svrs
        public bool Prod1Component15_Svr { get; set; }
        public bool Prod2Component15_Svr { get; set; }
        public bool Prod3Component15_Svr { get; set; }
        public bool Prod4Component15_Svr { get; set; }

        // IPs
        public bool Prod1Component15_IP { get; set; }
        public bool Prod2Component15_IP { get; set; }
        public bool Prod3Component15_IP { get; set; }
        public bool Prod4Component15_IP { get; set; }



        // Quantity
        public int Prod1Component_Qty15 { get; set; }
        public int Prod2Component_Qty15 { get; set; }
        public int Prod3Component_Qty15 { get; set; }
        public int Prod4Component_Qty15 { get; set; }

        // Calc Hours
        //....., Wkstns
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component15_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component15_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component15_WkstnHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component15_WkstnHours { get; set; }


        //...., Svrs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component15_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component15_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component15_SvrHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component15_SvrHours { get; set; }


        //....., IPs
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod1Component15_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod2Component15_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod3Component15_IPHours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double Prod4Component15_IPHours { get; set; }



        #endregion Component #15

        //Custom Component section added for flexibility

        #region Custom Component section added for flexibility

        public int CustomComponent_Qty1 { get; set; }
        public int CustomComponent_Qty2 { get; set; }
        public int CustomComponent_Qty3 { get; set; }
        public int CustomComponent_Qty4 { get; set; }
        public int CustomComponent_Qty5 { get; set; }


        public bool CustomComponent1 { get; set; }
        public string CustomComponent1Desc { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent1_Hours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent1_TotalHours { get; set; }


        public bool CustomComponent2 { get; set; }
        public string CustomComponent2Desc { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent2_Hours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent2_TotalHours { get; set; }


        public bool CustomComponent3 { get; set; }
        public string CustomComponent3Desc { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent3_Hours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent3_TotalHours { get; set; }


        public bool CustomComponent4 { get; set; }
        public string CustomComponent4Desc { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent4_Hours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent4_TotalHours { get; set; }


        public bool CustomComponent5 { get; set; }
        public string CustomComponent5Desc { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent5_Hours { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double CustomComponent5_TotalHours { get; set; }


        public double TotalCustomHours { get { return CustomComponent1_TotalHours + CustomComponent2_TotalHours + CustomComponent3_TotalHours + CustomComponent4_TotalHours + CustomComponent5_TotalHours; } set { } }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double TotalCustomFTE { get; set; }
        





        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double TotalComponents_Hours { get { return Prod1ComponentHours1 + Prod1ComponentHours2 + Prod1ComponentHours3 + Prod1ComponentHours4 + Prod1ComponentHours5 + Prod1ComponentHours6 + Prod1ComponentHours7 + Prod1ComponentHours8 + Prod1ComponentHours9 + Prod1ComponentHours10 + Prod1ComponentHours11 + Prod1ComponentHours12 + Prod1ComponentHours13 + Prod1ComponentHours14 + Prod1ComponentHours15 + Prod2ComponentHours1 + Prod2ComponentHours2 + Prod2ComponentHours3 + Prod2ComponentHours4 + Prod2ComponentHours5 + Prod2ComponentHours6 + Prod2ComponentHours7 + Prod2ComponentHours8 + Prod2ComponentHours9 + Prod2ComponentHours10 + Prod2ComponentHours11 + Prod2ComponentHours12 + Prod2ComponentHours13 + Prod2ComponentHours14 + Prod2ComponentHours15 + Prod3ComponentHours1 + Prod3ComponentHours2 + Prod3ComponentHours3 + Prod3ComponentHours4 + Prod3ComponentHours5 + Prod3ComponentHours6 + Prod3ComponentHours7 + Prod3ComponentHours8 + Prod3ComponentHours9 + Prod3ComponentHours10 + Prod3ComponentHours11 + Prod3ComponentHours12 + Prod3ComponentHours13 + Prod3ComponentHours14 + Prod3ComponentHours15 + Prod4ComponentHours1 + Prod4ComponentHours2 + Prod4ComponentHours3 + Prod4ComponentHours4 + Prod4ComponentHours5 + Prod4ComponentHours6 + Prod4ComponentHours7 + Prod4ComponentHours8 + Prod4ComponentHours9 + Prod4ComponentHours10 + Prod4ComponentHours11 + Prod4ComponentHours12 + Prod4ComponentHours13 + Prod4ComponentHours14 + Prod4ComponentHours15; } set { } }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double TotalComponentsFTE { get; set; }


        #endregion Custom Component section added for flexibility





        #endregion Product Components

        public double NumMonths_1 { get; set; }
        public double NumMonths_2 { get; set; }
        public double NumMonths_3 { get; set; }
        public double NumMonths_4 { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double AdditionalServices { get { return AppChangeHoursCalc + SoftLifeSrvHoursCalc + SecCompHoursCalc + RportingHoursCalc + SlaRptHoursCalc; } set { } }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double AdditionalFTE { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SteadyStateHoursTtl { get { return WkstnsHoursCalc + SrvsHoursCalc + IPsHoursCalc + AddlConHoursCalc + WkstnsHoursCalc1 + SrvsHoursCalc1 + IPsHoursCalc1 + AddlConHoursCalc1 + WkstnsHoursCalc2 + SrvsHoursCalc2 + IPsHoursCalc2 + AddlConHoursCalc2 + WkstnsHoursCalc3 + SrvsHoursCalc3 + IPsHoursCalc3 + AddlConHoursCalc3; } set { } }

        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double SteadyStateFTETtl { get { return WorkstationFTE + WorkstationFTE1 + WorkstationFTE2 + WorkstationFTE3 + ServerFTE + ServerFTE1 + ServerFTE2 + ServerFTE3 + IPEndpointFTE + IPEndpointFTE1 + IPEndpointFTE2 + IPEndpointFTE3 + AddlConFTE + AddlConFTE1 + AddlConFTE2 + AddlConFTE3; } set { } }

        

        public double NewSteadyStateSubTtl { get; set; }

        // For Product DropDowns -SecProducts1
        //   public double SecProducts1 { get; set; }

        //   public int SecProductsList_01 { get; set; }
        //   public int SecProductsList_02 { get; set; }
        //   public int SecProductsList_03 { get; set; }
        //  public int SecProductsList_04 { get; set; }

        //   public double TestField_2_ForceDB_Update { get; set; }

        //   public string Prod1Code { get; set; }
        //   public string Prod1Name { get; set; }
        //   public string Prod1Base { get; set; }
        //   public string Prod1Fac { get; set; }

        //   public int Prod2RegionId { get; set; }
        //   public string Prod2Region { get; set; }
        //   public double Prod2DefaultYear { get; set; }
        //   public double Prod2WorkWeek { get; set; }

        public double Prod1WorkWeek { get; set; }
        public double Prod2WorkWeek { get; set; }
        public double Prod3WorkWeek { get; set; }
        public double Prod4WorkWeek { get; set; }
                      
        public double DeliveryCtrCostFactor_1 { get; set; }
        public double DeliveryCtrCostFactor_2 { get; set; }
        public double DeliveryCtrCostFactor_3 { get; set; }
        public double DeliveryCtrCostFactor_4 { get; set; }

        //   public int Prod2ProdId { get; set; }
        //   public string Prod2ProdName { get; set; }
        //   public int Prod2ProdFac { get; set; }
        //   public int Prod2ProdBase { get; set; }

        // Legend Product Totals
        public double ProdLegendTtl_1 { get { return NumWorkstation + NumIpAddress + NumServer; } set { } }
        public double ProdLegendTtl_2 { get { return NumWorkstation1 + NumIpAddress1 + NumServer1; } set { } }
        public double ProdLegendTtl_3 { get { return NumWorkstation2 + NumIpAddress2 + NumServer2; } set { } }
        public double ProdLegendTtl_4 { get { return NumWorkstation3 + NumIpAddress3 + NumServer3; } set { } }
        public double TotalOfProdLegendTtl { get { return ProdLegendTtl_1 + ProdLegendTtl_2 + ProdLegendTtl_3 + ProdLegendTtl_4; } set { } }

        //SelctPDF Convertor Required Field
        public string Password { get; set; }
        public string Username { get; set; }

        // Test for Prod Dropdow to see if Ajax can Populate Database Field
     //   public string TestProdDesc12 { get; set; }
     //   public string TestProdDesc13 { get; set; }

     //   public double TestProdValue12 { get; set; }
     //   public double TestProdValue13 { get; set; }

        // UserName, Role and Team Identity
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int TeamId { get; set; }

        //Navigation property Returns the Sizing Details

       // Product Desciption Fields for final View
        public string DescProduct_1 { get; set; }
        public string DescProduct_2 { get; set; }
        public string DescProduct_3 { get; set; }
        public string DescProduct_4 { get; set; }

        public string DescLaborDelivery_1 { get; set; }
        //[DisplayFormat(DataFormatString = "{0:n00}", ApplyFormatInEditMode = true)]
        public double Default_Yr_LaborDelivery_1 { get; set; }

        public string DescLaborDelivery_2 { get; set; }
        
        public double Default_Yr_LaborDelivery_2 { get; set; }

        public string DescLaborDelivery_3 { get; set; }
        
        public double Default_Yr_LaborDelivery_3 { get; set; }

        public string DescLaborDelivery_4 { get; set; }
        
        public double Default_Yr_LaborDelivery_4 { get; set; }

        // Hours Calc for GBO Output
        #region Hours Calc for GBO Output
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1_Band3_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1_Band4_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1_Band5_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1_Band6_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1_Band7_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1_Band8_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod1_Band9_Percentage { get; set; }

        // Prod2
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2_Band3_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2_Band4_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2_Band5_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2_Band6_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2_Band7_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2_Band8_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod2_Band9_Percentage { get; set; }


        //Prod3
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3_Band3_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3_Band4_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3_Band5_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3_Band6_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3_Band7_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3_Band8_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod3_Band9_Percentage { get; set; }

        //Prod4
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4_Band3_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4_Band4_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4_Band5_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4_Band6_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4_Band7_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4_Band8_Percentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double Prod4_Band9_Percentage { get; set; }

        #endregion


        // Base and Complexity Calc = AvProd1ProductComplexityBase
        //public double AvProd1ProductComplexityBase { get; set; }
        //public double AvProd2ProductComplexityBase { get; set; }
        //public double AvProd3ProductComplexityBase { get; set; }
        //public double AvProd4ProductComplexityBase { get; set; }

        //public double AvProd1ProductComplexityFac { get; set; }
        //public double AvProd2ProductComplexityFac { get; set; }
        //public double AvProd3ProductComplexityFac { get; set; }
        //public double AvProd4ProductComplexityFac { get; set; }

        //public double LaborProd1DefaultYr { get; set; }
        //public double LaborProd2DefaultYr { get; set; }
        //public double LaborProd3DefaultYr { get; set; }
        //public double LaborProd4DefaultYr { get; set; }




        #region Hours Over-ride Calc
        public double Prod1Hours_OverRide { get; set; }
           public double Prod2Hours_OverRide { get; set; }
           public double Prod3Hours_OverRide { get; set; }
           public double Prod4Hours_OverRide { get; set; }

            public double WorkstationModifier_1 { get; set; }
            public double ServrrModifier_1 { get; set; }
            public double IPScanModifier_1 { get; set; }
            public double AddlConsoleModifier_1 { get; set; }

            public double WorkstationModifier_2 { get; set; }
            public double ServrrModifier_2 { get; set; }
            public double IPScanModifier_2 { get; set; }
            public double AddlConsoleModifier_2 { get; set; }

            public double WorkstationModifier_3 { get; set; }
            public double ServrrModifier_3 { get; set; }
            public double IPScanModifier_3 { get; set; }
            public double AddlConsoleModifier_3 { get; set; }

            public double WorkstationModifier_4 { get; set; }
            public double ServrrModifier_4 { get; set; }
            public double IPScanModifier_4 { get; set; }
            public double AddlConsoleModifier_4 { get; set; }


        #endregion

        #region Memo Notes Section
        public string MemoNote2 { get; set; }
        public string MemoNote3 { get; set; }
        public string MemoNote4 { get; set; }
        public string MemoNote5 { get; set; }
        public string MemoNote6 { get; set; }

        #endregion End Memo Notes Section

        #region Transition and Transformation Calc

        //public double TotalTransitionHoursItem_BZ { get { return TransitionWeeks * Prod1WorkWeek; } set { } }
        //public double TotalTransformationHoursItem_BZ { get { return TransformationWeeks * Prod1WorkWeek; } set { } }



        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem1_TransitionHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem2_TransitionHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem3_TransitionHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem4_TransitionHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem5_TransitionHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransitionHoursItem_BZ { get { return  (TransitionWeeks * Prod1WorkWeek) +(SpecialItem1_TransitionHours + SpecialItem2_TransitionHours + SpecialItem3_TransitionHours + SpecialItem4_TransitionHours  + SpecialItem5_TransitionHours); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionFirstLineManagementBand8 { get { return (ManagementMod1stLine * TotalTransitionHoursItem_BZ); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionSecondLineManagementBand8 { get { return (ManagementMod2ndLine * TotalTransitionHoursItem_BZ); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionFirstLineManagementBand8Hours { get { return (ManagementMod1stLine * TotalTransitionHoursItem_BZ); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem1_TransformationHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem2_TransformationHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem3_TransformationHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem4_TransformationHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double SpecialItem5_TransformationHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransformationHoursItem_BZ { get { return (TransformationWeeks * Prod1WorkWeek) + (SpecialItem1_TransformationHours + SpecialItem2_TransformationHours + SpecialItem3_TransformationHours + SpecialItem4_TransformationHours + SpecialItem5_TransformationHours); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransformationFirstLineManagementBand8 { get { return (ManagementMod1stLine * TotalTransformationHoursItem_BZ); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransformationSecondLineManagementBand8 { get { return (ManagementMod2ndLine * TotalTransformationHoursItem_BZ); } set { } }


        // Management Modifiers (Variable)
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double ManagementMod1stLine { get { return (0.05); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double ManagementMod2ndLine { get { return (0.0083); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionHoursFTE { get { return ((ManagementMod2ndLine * TotalTransitionHoursItem_BZ) / 100); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransfortionHoursFTE { get { return ((ManagementMod2ndLine * TotalTransformationHoursItem_BZ) / 100); } set { } }





        #endregion Transition and Transformation Calc

        public int LaborDeliveryTypeId{ get; set; }
    }
}