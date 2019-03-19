using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SizingToolNew2.Models;
namespace SizingToolNew2.ViewModels


{
    public class TestVM10
    {
        private DateTime _created;

        public TestVM10()

        {

            #region " Start of default values "

            // Setting Field default values Start Here.



            //        StedyStateBase = 5000;
            // AcctName = "Select an Account";


            // Default Endpoint Counts
            //        NumWorkstation = 0;
            //        NumWorkstation1 = 0;
            //        NumWorkstation2 = 0;
            //        NumWorkstation3 = 0;


            //        NumServer = 0;
            //        NumServer1 = 0;
            //        NumServer2 = 0;
            //        NumServer3 = 0;


            //        NumIpAddress = 0;
            //        NumIpAddress1 = 0;
            //        NumIpAddress2 = 0;
            //        NumIpAddress3 = 0;





            //        NumAppChange = 0;
            //        NumAppChange1 = 0;
            //        NumAppChange2 = 0;
            //        NumAppChange3 = 0;
            //        NumAddlCon = 0;
            //        NumAddlCon1 = 0;
            //        NumAddlCon2 = 0;
            //        NumAddlCon3 = 0;



            // Testing of Yes/No conditions
            // SoftLifeWkstnYesNo = true;
            // SoftLifeSvrYesNo = true;
            // SecCompRptYesNo = true;
            // ReportingYesNo = true;
            // SLAReportingYesNo = true;

            // *** Start Hours Calculations
            //  WkstnsHoursCalc = ((NumWorkstation / 2) + TotalTransitionHoursItem) * 0.130625;
            //        SrvsHoursCalc = 0;
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
            //        ServerFTE1 = ((NumServer1 * 0.130625) + 525) / 2100; //need to add L&D Band
            //        ServerFTE2 = ((NumServer2 * 0.130625) + 525) / 2100; //need to add L&D Band
            //        ServerFTE3 = ((NumServer3 * 0.130625) + 525) / 2100; //need to add L&D Band


            // WorkstationFTE = ((NumWorkstation * 0.130625) + 525) / 2100; //need to add L&D Band
            //  WorkstationFTE1 = ((NumWorkstation1 * 0.130625) + 525) / 2100; //need to add L&D Band
            //  WorkstationFTE2 = ((NumWorkstation2 * 0.130625) + 525) / 2100; //need to add L&D Band
            //  WorkstationFTE3 = ((NumWorkstation3 * 0.130625) + 525) / 2100; //need to add L&D Band


            // IPEndpointFTE = (NumIpAddress * 0.130625) / (2100); //need to add L&D Band
            //   DCSFTE = (((NumDCS * 0.130625) + 525) / 2100); //need to add L&D Band
            // ScanEngineFTE = (((NumScanEngine * 0.130625) + 263) / 2100); //need to add L&D Band
            //         AppChangeFTE = (((NumAppChange * 0.130625) + 263) / 2100); //need to add L&D Band;
            //        AppChangeFTE = (((NumAppChange1 * 0.130625) + 263) / 2100); //need to add L&D Band;
            //        AppChangeFTE = (((NumAppChange2 * 0.130625) + 263) / 2100); //need to add L&D Band;
            //         AppChangeFTE = (((NumAppChange3 * 0.130625) + 263) / 2100); //need to add L&D Band;

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
            //       Product1 = ("Select Product");

            // Setting Field default values End Here.



            #region Other Cost Calc Section
            // Other Cost Calc Section

            // TravelCostCount = 0;
            // TravelCost = 3500.00;

            #endregion Other Cost Section

            //      NumMonths_1 = 12;
            //      NumMonths_2 = 12;
            //      NumMonths_3 = 12;
            //      NumMonths_4 = 12;

            //      TransitionWeeks = 12;
            //      TransformationWeeks = 12;

            // SelectPDF Defaults

            //     Password = "PdfMalware";
            //      Username = "pdfadmin";



        }

        [Key]
        public int SizingId { get; set; }
        public int AcctCustId { get; set; }
        public int AvProductId { get; set; }
        public int LaborDeliveryId { get; set; }
        public int SizingTypeId { get; set; }
        public int NumWorkstation { get; set; }
        public int NumServer { get; set; }
        public int NumIpAddress { get; set; }
        public string SalesConnectNum { get; set; }
        public string RFSNum { get; set; }
        public string PrepardedBy { get; set; }

        public int ConfigId { get; set; }
        public int TnTId { get; set; }
        public int StatusStateId { get; set; }
        public int DisplayForSizingID { get; set; }


        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote { get; set; }




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



        // ********Start Section - Date and Time Calculations - ValidToDate

        [Display(Name = "Valid Until")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ValidToDate
        { get { return ValidToDate = Created.AddDays(90); } set { } }

        // ********End Section - Date and Time Calculations - ValidToDate

        //Custom attribute

        public string SizingData { get; set; }
        public string NoteDesc { get; set; }
        public string Note { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote1 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote2 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote3 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote4 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote5 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote6 { get; set; }

        [Display(Name = "Memo / Note")]
        [DataType(DataType.MultilineText)]
        public string MemoNote7 { get; set; }


        // Start of Foreign Keys

        [ForeignKey("ConfigId")]
        public virtual ConfigTable ConfigTable { get; set; }

        [ForeignKey("AvProductId")]
        public virtual AvProduct AvProduct { get; set; }

        [ForeignKey("TnTId")]
        public virtual TnTWorksheet TnTWorksheet { get; set; }

        [ForeignKey("AcctCustId")]
        public virtual AcctCust AcctCust { get; set; }
        //  public virtual ICollection<AcctCust> AcctCusts { get; set; }

        [ForeignKey("SizingTypeId")]
        public virtual SizingType SizingType { get; set; }



        [ForeignKey("LaborDeliveryId")]
        public virtual LaborDelivery LaborDelivery { get; set; }

        [ForeignKey("StatusStateId")]
        public virtual StatusState StatusState { get; set; }
    }
}
